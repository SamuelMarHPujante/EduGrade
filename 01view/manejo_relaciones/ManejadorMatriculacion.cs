using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_relaciones;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static EduGrade.Globales;

namespace EduGrade._01view.manejo_relaciones
{
    class ManejadorMatriculacion : ManejadorFormRelaciones<Matricula, Alumno, Curso>
    {
        private TextBox txtAnio;
        private TextBox txtNota;
        private Formato estadoAnio;
        private Formato estadoNota;

        public ManejadorMatriculacion(
            TextBox txtAnio,
            TextBox txtNota,

            Dictionary<Button, Action> mapaBotones, 
            Dictionary<TextBox, Action> mapaTextos,
            GestionRelaciones<Matricula, Alumno, Curso> gestionBackend, 
            string logArchivo, string nombreEntidadUnificadora,
            DataGridView dgvListaDominante, 
            DataGridView dgvListaSeguidora,
            DataGridView dgvListaRelaciones,
            Label lblMensajes)
            : base(mapaBotones, mapaTextos, gestionBackend, logArchivo, nombreEntidadUnificadora, dgvListaDominante, dgvListaSeguidora, dgvListaRelaciones, lblMensajes)
        { 
            this.txtAnio = txtAnio;
            this.txtNota = txtNota;

            this.estadoAnio = Formato.Vacio;
            this.estadoNota = Formato.Vacio;
        }

        public void AccionVincularMatricula(string dni, string codigoCurso)
        {
            var datosAdicionales = new Dictionary<string, object>
            {
                { "anio", txtAnio.Text },
                { "nota", txtNota.Text }
            };
            base.AccionVincular(dni, codigoCurso, esUnico: true, datosAdicionales);
        }

        public override void ProcesarCajaDeTexto(TextBox textEmisor, Regex regexValido, Regex regexSemicompleto = null)
        {
            Formato resultadoValidacion = UIManager.ValidarYEstilizarTextBox(textEmisor, regexValido, regexSemicompleto);
            if (textEmisor.Name.Contains("Anio")) estadoAnio = resultadoValidacion;
            else if (textEmisor.Name.Contains("Nota")) estadoNota = resultadoValidacion;
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
                                                                (estadoAnio == Formato.Valido) &&
                                                                (estadoNota == Formato.Valido);
                    if (boton.Name.Contains("Desvincular")) return estadoIdRelacional == Formato.Valido;
                    return false;
                },
                colorActivado: colorBotonesEnlazado
            );
        }
    }
}