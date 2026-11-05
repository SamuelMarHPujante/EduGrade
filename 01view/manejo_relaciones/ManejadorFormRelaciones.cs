using EduGrade._02aplication.gestion_relaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static EduGrade.Globales;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace EduGrade._01view.manejo_relaciones
{
    public class ManejadorFormRelaciones<TEnlace, T, U> where TEnlace : class, new() where T : class, new() where U : class, new()
    {
        protected Dictionary<Button, Action> _mapaBotones;
        private Dictionary<TextBox, Action> _mapaTextos;

        protected Formato estadoIdDominante;
        protected Formato estadoIdSeguidora;
        protected Formato estadoIdRelacional;
        private GestionRelaciones<TEnlace, T, U> gestionBackend;
        private readonly string _logArchivo;
        private readonly string _nombreEntidadUnificadora;

        private DataGridView dgvListaDominante;
        private DataGridView dgvListaSeguidora;
        private DataGridView dgvListaRelaciones;
        private Label lblMensajes;

        protected readonly string _tagDominante = "Dominante";
        protected readonly string _tagSeguidora = "Seguidora";
        protected readonly string _tagRelativa = "Relacional";

        public ManejadorFormRelaciones(
            Dictionary<Button, Action> mapaBotones, 
            Dictionary<TextBox, Action> mapaTextos,

            GestionRelaciones<TEnlace, T, U> gestionBackend, 
            string logArchivo, 
            string nombreEntidadUnificadora, 

            DataGridView dgvListaDominante, 
            DataGridView dgvListaSeguidora,
            DataGridView dgvListaRelaciones,
            Label lblMensajes)
        {
            _mapaBotones = mapaBotones;
            _mapaTextos = mapaTextos;

            this.estadoIdDominante = Formato.Vacio;
            this.estadoIdSeguidora = Formato.Vacio;
            this.estadoIdRelacional = Formato.Vacio;
            this.gestionBackend = gestionBackend;
            _logArchivo = logArchivo;
            _nombreEntidadUnificadora = nombreEntidadUnificadora;

            this.dgvListaDominante = dgvListaDominante;
            this.dgvListaSeguidora = dgvListaSeguidora;
            this.dgvListaRelaciones = dgvListaRelaciones;
            this.lblMensajes = lblMensajes;

            CargarTablaRelaciones();
            CargarTablaDominante();
            CargarTablaSeguidora();
            AsignarAcciones();

            InformarDeProceso("Conexión exitosa", esErrorProceso: false);
        }

        public void CargarTablaRelaciones() => CargarEnTabla(dgvListaRelaciones, gestionBackend.MostrarEnlaces());
        public void CargarTablaDominante() 
        {
            CargarEnTabla(dgvListaDominante, gestionBackend.MostrarDominante());
            CargarTablaRelaciones(); 
        }
        public void CargarTablaSeguidora() 
        {
            CargarEnTabla(dgvListaSeguidora, gestionBackend.MostrarSeguidora());
            CargarTablaRelaciones(); 
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

            dgvListaDominante.CellClick += Lista_CellClick;
            dgvListaDominante.CellMouseEnter += Lista_CellMouseEnter;
            dgvListaDominante.CellMouseLeave += Lista_CellMouseLeave;

            dgvListaSeguidora.CellClick += Lista_CellClick;
            dgvListaSeguidora.CellMouseEnter += Lista_CellMouseEnter;
            dgvListaSeguidora.CellMouseLeave += Lista_CellMouseLeave;

            dgvListaRelaciones.CellClick += Lista_CellClick;
            dgvListaRelaciones.CellMouseEnter += Lista_CellMouseEnter;
            dgvListaRelaciones.CellMouseLeave += Lista_CellMouseLeave;
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

        private void Lista_CellClick(object sender, DataGridViewCellEventArgs celda)
        {
            if (celda.RowIndex >= 0)
            {
                DataGridView lista = (DataGridView)sender;
                CopiarIdDesde(lista);
            }
        }

        private void Lista_CellMouseEnter(object sender, DataGridViewCellEventArgs celdas) => UIManager.EstilizarCeldaEn((DataGridView)sender, celdas, colorFondoCelda, colorFuenteCelda, colorCeldaFlotante);
        private void Lista_CellMouseLeave(object sender, DataGridViewCellEventArgs celdas) => UIManager.EstilizarCeldaEn((DataGridView)sender, celdas);

        #endregion


        #region Métodos de Utilidad Compartidos

        private void CargarEnTabla<URegistro>(DataGridView tablaPorCargar, List<URegistro> listaDeDatos) where URegistro : class, new()
        {
            tablaPorCargar.DataSource = listaDeDatos;
            InformarDeProceso($"Tabla {tablaPorCargar.Tag?.ToString().ToLower()} cargada con {listaDeDatos.Count} resultados", esErrorProceso: false);
            if (tablaPorCargar.RowCount > 0) SeleccionarPrimeraFila(tablaPorCargar);
        }

        private void SeleccionarPrimeraFila(DataGridView tablaCargada)
        {
            DataGridViewRow? filaPrimera = tablaCargada.Rows[0];
            if (filaPrimera == null) return;

            int indiceDeFila = filaPrimera.Index;
            if (indiceDeFila >= 0)
            {
                try
                {
                    tablaCargada.CurrentCell = filaPrimera.Cells[0];
                    tablaCargada.FirstDisplayedScrollingRowIndex = indiceDeFila;
                    CopiarIdDesde(tablaCargada);
                }
                catch (Exception error)
                {
                    InformarDeProceso($"Error en la tabla {tablaCargada.Name}: {error.Message}", esErrorProceso: true);
                }
            }
        }

        private void CopiarIdDesde(DataGridView tablaCargada)
        {
            if (tablaCargada.CurrentRow == null) return;
            
            string idCopiado = tablaCargada.CurrentRow.Cells[0].Value?.ToString() ?? "";
            string tagDestino = tablaCargada.Tag?.ToString();

            TextBox cajaDestino = _mapaTextos.Keys.FirstOrDefault(txt => txt.Tag?.ToString() == tagDestino);
            if (cajaDestino != null)
            {
                cajaDestino.Text = idCopiado;
                RegistroLogs.RegistrarEnLog($"ID {idCopiado} copiado a {cajaDestino.Name} desde la tabla {tablaCargada.Name}.", _logArchivo);
            }
        }

        #endregion

        #region Operaciones CRUD Comunes Y eventos Genéricos

        public void AccionBorrarDato(TextBox caja)
        {
            caja.Clear();
            RegistroLogs.RegistrarEnLog($"\"{caja.Name}\" borrada con éxito", _logArchivo);
        }

        public void AccionVincular(string idDominante, string idSeguidora, bool esUnico, Dictionary<string, object> columnasAdicionales = null)
        {

            DialogResult confirmacionDeUsuario = UIManager.PedirConfirmacion($"¿Seguro que deseas asignar una relación entre {idDominante} y {idSeguidora}?");
            if (confirmacionDeUsuario == DialogResult.OK)
            {
                string mensajeProceso = "";
                bool errorEnProceso = false;
                int proceso = gestionBackend.Vincular(idDominante, idSeguidora, esUnico, columnasAdicionales);
                
                if (proceso > 0)
                {
                    mensajeProceso = $"Elementos vinculados con éxito en {_nombreEntidadUnificadora}.";
                    CargarTablaRelaciones();
                }
                else if (proceso == -1)
                {
                    mensajeProceso = "La vinculación ya existía previamente.";
                    errorEnProceso = true;
                }
                else
                {
                    mensajeProceso = "Error al intentar realizar la vinculación.";
                    errorEnProceso = true;
                }
                InformarDeProceso(mensajeProceso, errorEnProceso);
            }
        }

        public void AccionDesvincular(string idRelacion)
        {
            DialogResult confirmacionDeUsuario = UIManager.PedirConfirmacion($"¿Seguro que deseas romper la relación número {idRelacion}?");
            if (confirmacionDeUsuario == DialogResult.OK)
            {
                string mensajeProceso = "";
                bool errorEnProceso = false;
                int proceso = gestionBackend.Desvincular(idRelacion);

                if (proceso > 0)
                {
                    mensajeProceso = $"Vínculo eliminado correctamente de {_nombreEntidadUnificadora}.";
                    CargarTablaRelaciones();
                }
                else
                {
                    mensajeProceso = "No se encontró ninguna relación activa para eliminar o hubo un error.";
                    errorEnProceso = true;
                }
                InformarDeProceso(mensajeProceso, errorEnProceso);
            }
        }

        public void AccionRelacionesDe(TextBox cajaFoco)
        {
            string tagDestino = cajaFoco.Tag?.ToString() ?? null;
            bool esDominante;
            if (tagDestino == _tagDominante)
            {
                CargarEnTabla(dgvListaSeguidora, gestionBackend.RelacionesDeDominante(cajaFoco.Text));
                esDominante = true;
            }
            else if (tagDestino == _tagSeguidora)
            {
                CargarEnTabla(dgvListaDominante, gestionBackend.RelacionesDeSeguidora(cajaFoco.Text));
                esDominante = false;
            }
            else esDominante = false;

            CargarEnTabla(dgvListaRelaciones, gestionBackend.DetallesRelaciones(cajaFoco.Text, esDominante));
        }

        #endregion

        #region Estilizado botones y Validación de textos

        public virtual void ProcesarCajaDeTexto(TextBox textEmisor, Regex regexValido, Regex regexSemicompleto = null)
        {
            string tipoTextBox = textEmisor.Tag?.ToString();
            Formato resultadoValidacion = UIManager.ValidarYEstilizarTextBox(textEmisor, regexValido, regexSemicompleto);

            if (tipoTextBox == _tagDominante) estadoIdDominante = resultadoValidacion;
            else if (tipoTextBox == _tagSeguidora) estadoIdSeguidora = resultadoValidacion;
            else if (tipoTextBox == _tagRelativa) estadoIdRelacional = resultadoValidacion;
            EstilizarBotonesVinculado();
            EstilizarBotonesPropios();
        }

        protected virtual void EstilizarBotonesVinculado()
        {
            var botonesEnlace = _mapaBotones.Keys.Where(btn => btn.Name.Contains("Vincular") || btn.Name.Contains("Desvincular"));
            UIManager.EstilizarGrupoBotones(
                botones: botonesEnlace,
                reglaDeActivacion: boton =>
                {
                    if (boton.Name.Contains("Vincular")) return (estadoIdDominante == Formato.Valido) &&
                                                                (estadoIdSeguidora == Formato.Valido);
                    if (boton.Name.Contains("Desvincular")) return estadoIdRelacional == Formato.Valido;
                    return false;
                },
                colorActivado: colorBotonesEnlazado
            );
        }

        private void EstilizarBotonesPropios()
        {
            ProcesarEstiloGrupo("Relaciones", colorBotonesRelacion);
            ProcesarEstiloGrupo("Borrar", colorBotonesBorrado);
        }

        private void ProcesarEstiloGrupo(string subNombre, Color colorObjetivo)
        {
            var botonesFiltrados = _mapaBotones.Keys.Where(btn => btn.Name.Contains(subNombre) && btn.Tag?.ToString() != null);

            UIManager.EstilizarGrupoBotones(
                botones: botonesFiltrados,
                reglaDeActivacion: boton =>
                {
                    string tag = boton.Tag?.ToString();
                    if (tag == _tagDominante) return estadoIdDominante != Formato.Vacio;
                    if (tag == _tagSeguidora) return estadoIdSeguidora != Formato.Vacio;
                    if (tag == _tagRelativa) return estadoIdRelacional != Formato.Vacio;
                    return false;
                },
                colorActivado: colorObjetivo
            );
        }

        #endregion

    }
}
