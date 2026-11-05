using EduGrade._02aplication.gestion_individual;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static EduGrade.Globales;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace EduGrade._01view.manejo_individual
{
    public class ManejadorFormIndividual<T> where T : class, new()
    {
        private Dictionary<Button, Action> _mapaBotones;
        private Dictionary<TextBox, Action> _mapaTextos;
        private Dictionary<TextBox, (Func<string> Get, Action<string> Set)> _mapaEntidad;

        private Formato estadoClavePrimaria;
        private readonly TextBox _clavePrimariaTxt;
        private GestionIndividual<T> gestionBackend;
        private readonly string _logArchivo;
        private readonly string _nombreEntidadSingular;

        private DataGridView dgvLista;
        private Label lblMensajes;
        private TextBox txtTotalFilas;
        private TextBox txtFilaActual;
        private CheckBox cbxCopiarTodo;
        private CheckBox cbxBorrarTodo;

        public ManejadorFormIndividual(
            Dictionary<Button, Action> accionesBotones,
            Dictionary<TextBox, Action> camposTxt,
            Dictionary<TextBox, (Func<string> Get, Action<string> Set)> mapeadoEntidad,

            TextBox clavePrimariaTxt,
            GestionIndividual<T> gestionBackend,
            string archivoLog,
            string nombreEntidad,

            DataGridView dgvLista,
            Label lblMensajes,
            TextBox txtTotalFilas,
            TextBox txtFilaActual,
            CheckBox cbxCopiarTodo,
            CheckBox cbxBorrarTodo)
        {
            this._mapaBotones = accionesBotones;
            this._mapaTextos = camposTxt;
            this._mapaEntidad = mapeadoEntidad;

            this._clavePrimariaTxt = clavePrimariaTxt;
            this.gestionBackend = gestionBackend;
            this._logArchivo = archivoLog;
            this._nombreEntidadSingular = nombreEntidad;

            this.dgvLista = dgvLista;
            this.lblMensajes = lblMensajes;
            this.txtTotalFilas = txtTotalFilas;
            this.txtFilaActual = txtFilaActual;
            this.cbxCopiarTodo = cbxCopiarTodo;
            this.cbxBorrarTodo = cbxBorrarTodo;

            this.estadoClavePrimaria = Formato.Vacio;
            
            CargarTablaBase();
            AsignarAcciones();

            UIManager.EstilizarCheckBox(cbxCopiarTodo, _logArchivo);
            UIManager.EstilizarCheckBox(cbxBorrarTodo, _logArchivo);

            InformarDeProceso("Conexión exitosa", esErrorProceso: false);
        }

        private void InformarDeProceso(string mensajeProceso, bool esErrorProceso) => UIManager.InformarDeProceso(lblMensajes, gestionBackend.ErrorDeBD(), mensajeProceso, esErrorProceso, _logArchivo);

        #region Asignación de eventos automático

        private void AsignarAcciones()
        {
            foreach (Button btn in _mapaBotones.Keys)
            {
                btn.Click += BotonAccion_Click;
                RegistroLogs.RegistrarEnLog($"Evento \"{_mapaBotones[btn]}\" enlazado a botón \"{btn.Name}\"", _logArchivo);
            }

            foreach (TextBox txt in _mapaTextos.Keys)
            {
                txt.TextChanged += TextBox_TextChanged;
                RegistroLogs.RegistrarEnLog($"Evento \"{_mapaTextos[txt]}\" enlazado a texto \"{txt.Name}\"", _logArchivo);
            }

            cbxCopiarTodo.CheckedChanged += CheckBox_CheckedChanged;
            cbxBorrarTodo.CheckedChanged += CheckBox_CheckedChanged;

            dgvLista.CellClick += Lista_CellClick;
            dgvLista.CellMouseEnter += Lista_CellMouseEnter;
            dgvLista.CellMouseLeave += Lista_CellMouseLeave;
        }

        private void BotonAccion_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            if (_mapaBotones.ContainsKey(botonPresionado) && _mapaBotones[botonPresionado] != null)
            {
                _mapaBotones[botonPresionado].Invoke();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox cajaActual = (TextBox)sender;
            if (_mapaTextos != null && _mapaTextos.ContainsKey(cajaActual))
            {
                _mapaTextos[cajaActual].Invoke();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e) => UIManager.EstilizarCheckBox((CheckBox)sender, _logArchivo);

        private void Lista_CellClick(object sender, DataGridViewCellEventArgs celda)
        {
            if (celda.RowIndex >= 0)
            {
                DataGridView lista = (DataGridView)sender;
                CopiarFilaAEntidad();
                IlustrarFilaActual(lista.Rows[celda.RowIndex]);
            }
        }

        private void Lista_CellMouseEnter(object sender, DataGridViewCellEventArgs celdas) => UIManager.EstilizarCeldaEn((DataGridView)sender, celdas, colorFondoCelda, colorFuenteCelda, colorCeldaFlotante);
        private void Lista_CellMouseLeave(object sender, DataGridViewCellEventArgs celdas) => UIManager.EstilizarCeldaEn((DataGridView)sender, celdas);

        #endregion


        #region Métodos de Utilidad Compartidos

        private void CargarTablaBase(List<T>? lista = null, bool seleccionar = true)
        {
            dgvLista.DataSource = lista == null ? this.gestionBackend.GetListaDeObjetos() : lista;
            int cantidadFilas = dgvLista.RowCount;
            if (cantidadFilas > 0 && seleccionar)
            {
                AutoSeleccionarFila(dgvLista.Rows[0]);
            }
            else
            {
                EstilizarBotonesNavegacion();
                EstilizarBotonesCopiado();
            }

            txtTotalFilas.Text = cantidadFilas.ToString();
            RegistroLogs.RegistrarEnLog($"Tabla \"{gestionBackend.NombreTabla}\" refrescada", _logArchivo);
        }

        private void AutoSeleccionarFila(DataGridViewRow? filaSeleccionada)
        {
            if (filaSeleccionada == null) return;
            int indiceDeFila = filaSeleccionada.Index;
            if (indiceDeFila >= 0)
            {
                try
                {
                    dgvLista.CurrentCell = filaSeleccionada.Cells[0];
                    dgvLista.FirstDisplayedScrollingRowIndex = indiceDeFila;
                    IlustrarFilaActual(filaSeleccionada);
                }
                catch (Exception error)
                {
                    InformarDeProceso($"Error en la tabla {dgvLista.Name}: {error.Message}", esErrorProceso: true);
                }
            }
        }

        private void IlustrarFilaActual(DataGridViewRow filaSeleccionada)
        {
            int indice = filaSeleccionada.Index + 1;
            txtFilaActual.Text = indice.ToString();
            RegistroLogs.RegistrarEnLog($"Fila {indice} seleccionada", _logArchivo);

            string mensajeProceso = this.gestionBackend.Entidad.ToString();
            InformarDeProceso(mensajeProceso, esErrorProceso: false);

            EstilizarBotonesNavegacion();
            EstilizarBotonesCopiado();
            CopiarAutomatico();
        }

        private void CopiarFilaAEntidad()
        {
            if (dgvLista.CurrentRow == null) return;

            foreach (TextBox caja in _mapaTextos.Keys)
            {
                if (_mapaEntidad.ContainsKey(caja))
                {
                    string nombreColumnaBD = caja.Name.Replace("txt", "").ToLower();
                    if (dgvLista.Columns.Contains(nombreColumnaBD))
                    {
                        string valorCelda = dgvLista.CurrentRow.Cells[nombreColumnaBD].Value?.ToString() ?? "";
                        _mapaEntidad[caja].Set(valorCelda);
                    }
                }
            }
        }

        #endregion

        #region Operaciones CRUD Comunes

        public void AccionInsertar()
        {
            bool idValido = estadoClavePrimaria == Formato.Valido;
            UIManager.VolcarControlesADatos(_mapaTextos, _mapaEntidad, _logArchivo);

            int codigoProceso = idValido ? gestionBackend.Insertar() : -1;
            bool hayError = codigoProceso == -1;

            string mensajeProceso = hayError
                ? $"ERROR: El identificador indicado no es válido o ya existe".ToUpper()
                : $"El {_nombreEntidadSingular} fue registrado con éxito";

            if (!hayError) CargarTablaBase();
            InformarDeProceso(mensajeProceso, esErrorProceso: hayError);
            BorrarAutomatico();
        }

        public void AccionBorrar()
        {
            string idIntroducido = _clavePrimariaTxt.Text;
            ConfirmarYOperar(idIntroducido, () => gestionBackend.Borrar(idIntroducido));
        }

        public void AccionEditar()
        {
            UIManager.VolcarControlesADatos(_mapaTextos, _mapaEntidad, _logArchivo);
            string idIntroducido = _clavePrimariaTxt.Text;
            ConfirmarYOperar(idIntroducido, () => gestionBackend.Editar());
        }

        public void AccionBuscar()
        {
            UIManager.VolcarControlesADatos(_mapaTextos, _mapaEntidad, _logArchivo);
            List<T> resultados = gestionBackend.Buscar();

            if (resultados.Count > 0)
            {
                gestionBackend.Entidad = resultados[0];
                CargarTablaBase(resultados);
                InformarDeProceso($"Se encontraron {resultados.Count} registros.", esErrorProceso: false);
            }
            else
            {
                InformarDeProceso("No se encontraron registros con los criterios especificados.", esErrorProceso: true);
            }
            BorrarAutomatico();
        }

        private void ConfirmarYOperar(string idIntroducido, Func<int> operacionDeGestion)
        {
            DialogResult confirmacion = UIManager.PedirConfirmacion($"¿Quieres realizar la operación con el {_nombreEntidadSingular.ToLower()} \"{idIntroducido}\"?");
            RegistroLogs.RegistrarEnLog($"Respuesta de usuario \"{confirmacion}\"", _logArchivo);

            if (confirmacion == DialogResult.OK)
            {
                int codigoProceso = operacionDeGestion();
                bool hayError = codigoProceso == -1;

                string mensajeProceso = hayError ? $"ERROR: El identificador indicado NO existe".ToUpper() : $"Operación realizada con éxito";
                if (!hayError) CargarTablaBase();
                InformarDeProceso(mensajeProceso, esErrorProceso: hayError);
            }
            BorrarAutomatico();
        }

        #endregion

        #region Eventos Genéricos de Botones individuales (Copiar/Borrar/Navegación)

        public void AccionRefrescado()
        {
            CargarTablaBase();
            CopiarAutomatico();
            BorrarAutomatico();
            InformarDeProceso("Recarga exitosa", esErrorProceso: false);
        }

        public void AccionCopiarDato(TextBox caja = null)
        {
            if (caja == null)
            {
                UIManager.VolcarDatosAControles(_mapaTextos, _mapaEntidad, _logArchivo);
            }
            else
            {
                TextBox llaveDato = _mapaTextos.FirstOrDefault(campo => campo.Key == caja).Key;
                caja.Text = _mapaEntidad[llaveDato].Get();
                RegistroLogs.RegistrarEnLog($"\"{caja.Name}\" copiada con éxito", _logArchivo);
            }
        }

        public void AccionBorrarDato(TextBox caja = null)
        {
            if (caja == null)
            {
                UIManager.LimpiarControles(_mapaTextos, _logArchivo);
            }
            else
            {
                caja.Clear();
                RegistroLogs.RegistrarEnLog($"\"{caja.Name}\" borrada con éxito", _logArchivo);
            }
        }
        
        public void AccionNavegacion(object sender)
        {
            Button emisor = (Button)sender;
            string idActual = _mapaEntidad[_clavePrimariaTxt].Get() ?? string.Empty;
            gestionBackend.CambiarDeFila(emisor.Name, idActual);
            CargarTablaBase(null, false);

            string nombreColumna = _clavePrimariaTxt.Name.Replace("txt", "").ToLower();
            DataGridViewRow? filaSeleccionada = dgvLista.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[nombreColumna].Value?.ToString() == _mapaEntidad[_clavePrimariaTxt].Get());
            AutoSeleccionarFila(filaSeleccionada);
        }

        private void BorrarAutomatico() 
        {
            if (cbxBorrarTodo.Checked)
            {
                UIManager.LimpiarControles(_mapaTextos, _logArchivo);
            }
        }

        private void CopiarAutomatico()
        {
            if (cbxCopiarTodo.Checked)
            {
                CopiarFilaAEntidad();
                UIManager.VolcarDatosAControles(_mapaTextos, _mapaEntidad, _logArchivo);
            }
        }

        #endregion

        #region Elementos de Estilizado

        public void ProcesarCajaDeTexto(TextBox cajaEmisora, Regex regexValido, Regex regexSemicompleto = null)
        {
            if (cajaEmisora == _clavePrimariaTxt)
            {
                estadoClavePrimaria = UIManager.ValidarYEstilizarTextBox(cajaEmisora, regexValido, regexSemicompleto);
            }
            AlterarBotonesDeTextBox();
        }

        public void AlterarBotonesDeTextBox()
        {
            EstilizarBotonesGestion();
            EstilizarBotonesBorrado();
        }

        private void EstilizarBotonesBorrado()
        {
            var grupoBotones = _mapaBotones.Keys.Where(btn => btn.Tag?.ToString() == "Borrado");
            bool hayAlgoLleno = UIManager.VerificarGrupoRelleno(_mapaTextos);

            UIManager.EstilizarGrupoBotones(
                botones: grupoBotones,
                reglaDeActivacion: boton =>
                {
                    if (boton.Name.Contains("Todo"))
                    {
                        return hayAlgoLleno;
                    }

                    string nombreCampoPuro = boton.Name.Replace("btnBorrar", "").ToLower();
                    TextBox cajaAsociada = _mapaTextos.Keys.FirstOrDefault(txt => txt.Name.ToLower().EndsWith(nombreCampoPuro));

                    if (cajaAsociada == null) return false;
                    return UIManager.VerificarCampoRelleno(cajaAsociada.Text);
                },
                colorActivado: colorBotonesBorrado);
        }

        private void EstilizarBotonesCopiado()
        {
            var grupoBotones = _mapaBotones.Keys.Where(btn => btn.Tag?.ToString() == "Copiado");

            UIManager.EstilizarGrupoBotones(
                botones: grupoBotones,
                reglaDeActivacion: _ => dgvLista.CurrentRow != null,
                colorActivado: colorBotonesCopiado);
        }

        private void EstilizarBotonesGestion()
        {
            var grupoBotones = _mapaBotones.Keys.Where(btn => btn.Tag?.ToString() == "Gestion");
            bool hayAlgoLleno = UIManager.VerificarGrupoRelleno(_mapaTextos);
            bool hayId = estadoClavePrimaria == Formato.Valido;

            UIManager.EstilizarGrupoBotones(
                botones: grupoBotones,
                reglaDeActivacion: boton => boton.Name.ToLower().Contains("buscar") ? hayAlgoLleno : hayId,
                colorActivado: colorBotonesGestion);
        }

        private void EstilizarBotonesNavegacion()
        {
            var listaNavegacion = _mapaBotones.Keys.Where(btn => btn.Tag?.ToString() == "Navegacion");
            int indiceActual = dgvLista.CurrentRow?.Index ?? -1;
            int totalFilas = dgvLista.RowCount;
            bool hayFilas = totalFilas > 0;

            UIManager.EstilizarGrupoBotones(
                botones: listaNavegacion,
                reglaDeActivacion: boton =>
                {
                    if (!hayFilas) return false;
                    string nombre = boton.Name.ToLower();

                    if (nombre.Contains("primero") || nombre.Contains("anterior"))
                        return indiceActual > 0;

                    if (nombre.Contains("siguiente") || nombre.Contains("ultimo"))
                        return indiceActual < totalFilas - 1;

                    return false;
                },
                colorActivado: colorBotonesNavegacion);
        }

        #endregion

    }
}
