using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_individual;
using Org.BouncyCastle.Bcpg.OpenPgp;
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

namespace EduGrade._01view.manejo_individual
{
    public partial class FrmCursos : Form
    {
        private Dictionary<Button, Action> mapaBotones;
        private Dictionary<TextBox, Action> mapaTextos;
        private Dictionary<TextBox, (Func<string> Get, Action<string> Set)> mapaEntidad;
     
        private GestionCursos gestionBackend;
        private readonly string _logArchivo = _logCurso;

        private ManejadorFormIndividual<Curso> manejoForm;

        public FrmCursos()
        {
            InitializeComponent();
            InicializarDiccionarios();

            gestionBackend = new GestionCursos();
            manejoForm = new ManejadorFormIndividual<Curso>(
                accionesBotones: mapaBotones,
                camposTxt: mapaTextos,
                mapeadoEntidad: mapaEntidad,

                clavePrimariaTxt: this.txtCodigo,
                gestionBackend: gestionBackend,
                archivoLog: _logArchivo,
                nombreEntidad: "curso",

                dgvLista: dgvListaCursos,
                lblMensajes: lblMensajes,
                txtTotalFilas: txtTotalFilas,
                txtFilaActual: txtFilaActual,
                cbxCopiarTodo: cbxCopiarTodo,
                cbxBorrarTodo: cbxBorrarTodo
            );

            foreach (TextBox txt in mapaTextos.Keys) mapaTextos[txt].Invoke();
        }

        private void InicializarDiccionarios()
        {
            mapaBotones = new Dictionary<Button, Action>
            {
                // --- ACCIONES DE NAVEGACIÓN ---
                [btnPrimero] = () => manejoForm.AccionNavegacion(btnPrimero),
                [btnAnterior] = () => manejoForm.AccionNavegacion(btnAnterior),
                [btnSiguiente] = () => manejoForm.AccionNavegacion(btnSiguiente),
                [btnUltimo] = () => manejoForm.AccionNavegacion(btnUltimo),

                // --- ACCIONES DE GESTIÓN ---
                [btnInsertar] = () => manejoForm.AccionInsertar(),
                [btnBorrar] = () => manejoForm.AccionBorrar(),
                [btnEditar] = () => manejoForm.AccionEditar(),
                [btnBuscar] = () => manejoForm.AccionBuscar(),

                // --- ACCIONES DE COPIADO ---
                [btnCopiarCodigo] = () => manejoForm.AccionCopiarDato(txtCodigo),
                [btnCopiarNombre] = () => manejoForm.AccionCopiarDato(txtNombre),
                [btnCopiarTodo] = () => manejoForm.AccionCopiarDato(),

                // --- ACCIONES DE BORRADO ---
                [btnBorrarCodigo] = () => manejoForm.AccionBorrarDato(txtCodigo),
                [btnBorrarNombre] = () => manejoForm.AccionBorrarDato(txtNombre),
                [btnBorrarTodo] = () => manejoForm.AccionBorrarDato(),

                // --- OTRAS ACCIONES ---
                [btnAbrirLog] = () => UIManager.AbrirLog(_logArchivo),
                [btnBorrarLog] = () => UIManager.BorrarLog(_logArchivo),
                [btnRefrescar] = () => manejoForm.AccionRefrescado()
            };
            mapaTextos = new Dictionary<TextBox, Action>
            {
                [txtCodigo] = () => manejoForm?.ProcesarCajaDeTexto(this.txtCodigo, _regexCodigos),
                [txtNombre] = () => manejoForm?.AlterarBotonesDeTextBox()
            };
            mapaEntidad = new Dictionary<TextBox, (Func<string> Get, Action<string> Set)>
            {
                [txtCodigo] = (() => this.gestionBackend.Entidad.Codigo, val => this.gestionBackend.Entidad.Codigo = val),
                [txtNombre] = (() => this.gestionBackend.Entidad.Nombre, val => this.gestionBackend.Entidad.Nombre = val),
            };
        }
    }
}
