using EduGrade._01view.manejo_individual;
using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_relaciones;
using EduGrade._02aplication.gestion_individual;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EduGrade.Globales;

namespace EduGrade._01view.manejo_relaciones
{
    public partial class FrmMatriculacion : Form
    {
        private Dictionary<Button, Action> mapaBotones;
        private Dictionary<TextBox, Action> mapaTextos;

        private GestionMatriculacion gestionBackend;
        private readonly string _logArchivo = _logMatriculacion;

        private ManejadorMatriculacion manejoForm;

        public FrmMatriculacion()
        {
            InitializeComponent();

            gestionBackend = new GestionMatriculacion();
            mapaBotones = new Dictionary<Button, Action>
            {
                // --- ACCIONES DE ENLAZADO ---
                [btnVincular] = () => manejoForm.AccionVincularMatricula(txtDominante.Text, txtSeguidora.Text),
                [btnDesvincular] = () => manejoForm.AccionDesvincular(txtRelacion.Text),

                // --- ACCIONES DE REFRESCADO ---
                [btnRefrescarDominante] = () => manejoForm.CargarTablaDominante(),
                [btnRefrescarSeguidora] = () => manejoForm.CargarTablaSeguidora(),

                // --- ACCIONES DE RELACIONES ---
                [btnRelacionesDominante] = () => manejoForm.AccionRelacionesDe(txtDominante),
                [btnRelacionesSeguidora] = () => manejoForm.AccionRelacionesDe(txtSeguidora),

                // --- ACCIONES DE BORRADO ---
                [btnBorrarDominante] = () => manejoForm.AccionBorrarDato(txtDominante),
                [btnBorrarSeguidora] = () => manejoForm.AccionBorrarDato(txtSeguidora),
                [btnBorrarRelacional] = () => manejoForm.AccionBorrarDato(txtRelacion),

                // --- ACCIONES DE LOG ---
                [btnAbrirLog] = () => UIManager.AbrirLog(_logArchivo),
                [btnBorrarLog] = () => UIManager.BorrarLog(_logArchivo),
            };
            mapaTextos = new Dictionary<TextBox, Action>
            {
                [txtRelacion] = () => manejoForm?.ProcesarCajaDeTexto(txtRelacion, _regexCodigos),
                [txtDominante] = () => manejoForm?.ProcesarCajaDeTexto(txtDominante, _regexDni, _regexDniNumerico),
                [txtSeguidora] = () => manejoForm?.ProcesarCajaDeTexto(txtSeguidora, _regexCodigos),
                [txtAnio] = () => manejoForm?.ProcesarCajaDeTexto(txtAnio, _regexAnio),
                [txtNota] = () => manejoForm?.ProcesarCajaDeTexto(txtNota, _regexNota)
            };
            manejoForm = new ManejadorMatriculacion(
                txtAnio: txtAnio,
                txtNota: txtNota,

                mapaBotones: mapaBotones,
                mapaTextos: mapaTextos,

                gestionBackend: gestionBackend,
                logArchivo: _logArchivo,
                nombreEntidadUnificadora: "cursa",

                dgvListaRelaciones: dgvListaRelaciones,
                dgvListaDominante: dgvListaDominante,
                dgvListaSeguidora: dgvListaSeguidor,
                lblMensajes: lblMensajes
            );

            foreach (TextBox txt in mapaTextos.Keys) mapaTextos[txt].Invoke();
        }
    }
}
