using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_relaciones;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static EduGrade.Globales;

namespace EduGrade._01view.manejo_relaciones
{
    class ManejadorCalificaciones : ManejadorFormRelaciones<Calificacion, Alumno, Modulo>
    {
        private List<RadioButton> _rbsTrimestre; 
        private ComboBox _cbTipo;
        private TextBox txtNota;
        private Formato estadoNota;

        public ManejadorCalificaciones(
            List<RadioButton> rbsTrimestre,
            ComboBox cbTipo,
            TextBox txtNota,

            Dictionary<Button, Action> mapaBotones, 
            Dictionary<TextBox, Action> mapaTextos,
            GestionRelaciones<Calificacion, Alumno, Modulo> gestionBackend, 
            string logArchivo, 
            string nombreEntidadUnificadora,
            DataGridView dgvListaDominante, 
            DataGridView dgvListaSeguidora,
            DataGridView dgvListaRelaciones,
            Label lblMensajes) 
            : base(mapaBotones, mapaTextos, gestionBackend, logArchivo, nombreEntidadUnificadora, dgvListaDominante, dgvListaSeguidora, dgvListaRelaciones, lblMensajes)
        {
            this._rbsTrimestre = rbsTrimestre;
            this._cbTipo = cbTipo;
            this.txtNota = txtNota;

            this.estadoNota = Formato.Vacio;
        }

        public void AccionVincularCalificacion(string dni, string codigoModulo)
        {
            int trimestre = 1;
            if (_rbsTrimestre[1].Checked) trimestre = 2;
            if (_rbsTrimestre[2].Checked) trimestre = 3;

            var datosAdicionales = new Dictionary<string, object>
            {
                { "codigo_trimestre", trimestre },
                { "nota", txtNota.Text },
                { "tipo", _cbTipo.SelectedItem?.ToString() ?? "Práctica" }
            };
            base.AccionVincular(dni, codigoModulo, esUnico: false, datosAdicionales);
        }

        public override void ProcesarCajaDeTexto(TextBox textEmisor, Regex regexValido, Regex regexSemicompleto = null)
        {
            Formato resultadoValidacion = UIManager.ValidarYEstilizarTextBox(textEmisor, regexValido, regexSemicompleto);
            if (textEmisor.Name.Contains("Nota")) estadoNota = resultadoValidacion;
            else base.ProcesarCajaDeTexto(textEmisor, regexValido, regexSemicompleto);
            EstilizarBotonesVinculado();
        }

        protected override void EstilizarBotonesVinculado()
        {
            var botonesEnlace = _mapaBotones.Keys.Where(btn => btn.Name.Contains("Vincular") || btn.Name.Contains("Desvincular"));
            UIManager.EstilizarGrupoBotones(
                botones: botonesEnlace,
                reglaDeActivacion: boton =>
                {
                    if (boton.Name.Contains("Vincular")) return (estadoIdDominante == Formato.Valido) &&
                                                                (estadoIdSeguidora == Formato.Valido) &&
                                                                (estadoNota == Formato.Valido);
                    if (boton.Name.Contains("Desvincular")) return estadoIdRelacional == Formato.Valido;
                    return false;
                },
                colorActivado: colorBotonesEnlazado
            );
        }
    }
}