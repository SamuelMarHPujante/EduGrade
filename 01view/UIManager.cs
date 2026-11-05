using EduGrade._02aplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static EduGrade.Globales;

namespace EduGrade._01view
{
    public static class UIManager
    {
        #region Elementos informativos

        public static void InformarDeProceso(Label aviso, string errorBD, string mensajeProceso, bool esErrorProceso, string logArchivo)
        {
            bool esErrorBD = UIManager.VerificarCampoRelleno(errorBD);
            Color colorDeMensaje = esErrorBD || esErrorProceso ? Color.DarkRed : Color.DarkGreen;
            string mensajeAMostrar = esErrorBD ? $"ERROR BD: {errorBD}" : mensajeProceso;

            aviso.ForeColor = colorDeMensaje;
            aviso.Text = mensajeAMostrar;
            RegistroLogs.RegistrarEnLog(mensajeAMostrar, logArchivo);
        }

        public static DialogResult PedirConfirmacion(string consulta)
        {
            DialogResult confirmacion = MessageBox.Show(
                consulta,
                "Confirmación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            return confirmacion;
        }

        #endregion

        #region Métodos para gestión de logs

        public static void AbrirLog(string logPorAbrir = Globales._logUsuario)
        {
            if (!File.Exists(logPorAbrir))
            {
                DialogResult operacionFinal = MessageBox.Show(
                    "El fichero de log no existe",
                    "Error".ToUpper(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                RegistroLogs.AbrirLog(logPorAbrir);
            }
        }

        public static void BorrarLog(string logPorBorar = Globales._logUsuario)
        {
            DialogResult confirmacion = UIManager.PedirConfirmacion($"¿Estás seguro que deseas formatear el log?");
            bool procesoConfirmado = confirmacion == DialogResult.OK;
            bool romperBucle = false;

            while (!romperBucle)
            {
                if (procesoConfirmado)
                {
                    bool noHayLog = !File.Exists(logPorBorar);
                    RegistroLogs.BorrarLog(logPorBorar);

                    DialogResult operacionFinal = MessageBox.Show(
                        noHayLog ? "¡No hay log a formatear!".ToUpper() : "Log formateado con éxito",
                        noHayLog ? "Error".ToUpper() : "Operación exitosa",
                        noHayLog ? MessageBoxButtons.RetryCancel : MessageBoxButtons.OK,
                        noHayLog ? MessageBoxIcon.Error : MessageBoxIcon.Information
                    );

                    bool terminar = operacionFinal == DialogResult.OK || operacionFinal == DialogResult.Cancel;
                    romperBucle = terminar;
                }
                else
                {
                    romperBucle = true;
                }
            }
        }

        #endregion

        #region Limpieza de TextBoxes y pasado de datos

        public static void LimpiarControles(Dictionary<TextBox, Action> camposTxt, string logArchivo)
        {
            if (camposTxt == null) return;

            foreach (TextBox caja in camposTxt.Keys)
            {
                caja.Clear();
                RegistroLogs.RegistrarEnLog($"Caja de texto \"{caja.Name}\" borrada con éxito", logArchivo);
            }
        }

        public static void VolcarDatosAControles(
            Dictionary<TextBox, Action> camposTxt,
            Dictionary<TextBox, (Func<string> Get, Action<string> Set)> mapeoDatos,
            string logArchivo)
        {
            if (camposTxt == null || mapeoDatos == null) return;

            foreach (TextBox caja in camposTxt.Keys)
            {
                if (mapeoDatos.ContainsKey(caja))
                {
                    string datoObtenido = mapeoDatos[caja].Get();
                    caja.Text = datoObtenido;
                    RegistroLogs.RegistrarEnLog($"Dato copiado a \"{caja.Name}\": \"{datoObtenido}\"", logArchivo);
                }
            }
        }

        public static void VolcarControlesADatos(
            Dictionary<TextBox, Action> camposTxt,
            Dictionary<TextBox, (Func<string> Get, Action<string> Set)> mapeoDatos,
            string logArchivo)
        {
            foreach (TextBox caja in camposTxt.Keys)
            {
                if (mapeoDatos.ContainsKey(caja))
                {
                    string textoEscrito = caja.Text;
                    mapeoDatos[caja].Set(textoEscrito);
                    RegistroLogs.RegistrarEnLog($"Copiado al objeto: \"{textoEscrito}\"", logArchivo);
                }
            }
        }

        #endregion

        #region Estilizado de elementos varios

        private static void EstilizarTextBoxPorFormato(TextBox cajaTexto, Formato estadoFormato)
        {
            var (colorFuente, colorFondo) = estadoFormato switch
            {
                Formato.Invalido => (Color.White, Color.DarkRed),
                Formato.Semicompleto => (Color.Black, Color.Yellow),
                Formato.Valido => (Color.White, Color.DarkGreen),
                _ => (Color.Black, Color.White)
            };

            cajaTexto.ForeColor = colorFuente;
            cajaTexto.BackColor = colorFondo;
        }

        public static void EstilizarGrupoBotones(
            IEnumerable<Button> botones,
            Func<Button, bool> reglaDeActivacion,
            Color colorActivado,
            Color colorDesactivado = default)
        {
            if (botones == null) return;

            foreach (Button boton in botones)
            {
                bool debeActivarse = reglaDeActivacion(boton);

                boton.Enabled = debeActivarse;
                boton.BackColor = debeActivarse
                    ? colorActivado
                    : (colorDesactivado == default ? Color.Transparent : colorDesactivado);
            }
        }

        public static void EstilizarCheckBox(CheckBox checkEmisor, string logArchivo)
        {
            Color colorFuenteOn = Color.DarkGreen;
            Color colorFuenteOff = Color.DarkRed;
            Color colorFondoOn = Color.LightGreen;
            Color colorFondoOff = Color.PaleVioletRed;

            checkEmisor.ForeColor = checkEmisor.Checked ? colorFuenteOn : colorFuenteOff;
            checkEmisor.BackColor = checkEmisor.Checked ? colorFondoOn : colorFondoOff;
            RegistroLogs.RegistrarEnLog($"\"{checkEmisor.Name}\" alterado a \"{checkEmisor.Checked.ToString()}\"", logArchivo);
        }

        public static void EstilizarCeldaEn(
            DataGridView tabla, 
            DataGridViewCellEventArgs celdas, 
            Color fondoCelda = default, 
            Color fuenteCelda = default, 
            Color celdaActual = default)
        {
            int indiceFila = celdas.RowIndex;
            int indiceCelda = celdas.ColumnIndex;
            bool hayCelda = indiceFila >= 0 && indiceCelda >= 0;

            if (hayCelda)
            {
                DataGridViewCell indiceReal = tabla.Rows[indiceFila].Cells[indiceCelda];
                indiceReal.Style.BackColor = fondoCelda;
                indiceReal.Style.ForeColor = fuenteCelda;
                indiceReal.Style.SelectionBackColor = celdaActual;
            }
        }

        #endregion

        #region Validaciones de texto y formato

        public static Formato ValidarYEstilizarTextBox(TextBox cajaTexto, Regex regexValido, Regex regexSemicompleto = null)
        {
            Formato estado = ValidarFormatoTexto(cajaTexto.Text, regexValido, regexSemicompleto);
            EstilizarTextBoxPorFormato(cajaTexto, estado);
            return estado;
        }

        private static Formato ValidarFormatoTexto(string texto, Regex regexValido, Regex regexSemicompleto = null)
        {
            if (!VerificarCampoRelleno(texto)) return Formato.Vacio;
            if (regexSemicompleto != null && regexSemicompleto.IsMatch(texto)) return Formato.Semicompleto;
            if (regexValido.IsMatch(texto)) return Formato.Valido;
            return Formato.Invalido;
        }

        public static bool VerificarGrupoRelleno(Dictionary<TextBox, Action> campos)
        {
            if (campos == null) return false;
            foreach (TextBox caja in campos.Keys) if (VerificarCampoRelleno(caja.Text)) return true;
            return false;
        }

        public static bool VerificarCampoRelleno(string textoPorLeer) => textoPorLeer != null && textoPorLeer.Trim().Length > 0;

        #endregion

    }
}
