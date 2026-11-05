using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_individual;
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
    public partial class FrmModulos : Form
    {
        private Dictionary<Button, Action> mapaBotones;
        private Dictionary<TextBox, Action> mapaTextos;
        private Dictionary<TextBox, (Func<string> Get, Action<string> Set)> mapaEntidad;
     
        private GestionModulos gestionBackend;
        private readonly string _logArchivo = _logModulo;

        private ManejadorFormIndividual<Modulo> manejoForm;

        public FrmModulos()
        {
            InitializeComponent();
            InicializarDiccionarios();

            gestionBackend = new GestionModulos();
            manejoForm = new ManejadorFormIndividual<Modulo>(
                accionesBotones: mapaBotones,
                mapeadoEntidad: mapaEntidad,
                camposTxt: mapaTextos,

                clavePrimariaTxt: this.txtCodigo,
                gestionBackend: gestionBackend,
                archivoLog: _logArchivo,
                nombreEntidad: "modulo",

                dgvLista: dgvListaModulos,
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
                [btnCopiarN_practicas] = () => manejoForm.AccionCopiarDato(txtN_practicas),
                [btnCopiarN_examenes] = () => manejoForm.AccionCopiarDato(txtN_examenes),
                [btnCopiarTodo] = () => manejoForm.AccionCopiarDato(),

                // --- ACCIONES DE BORRADO ---
                [btnBorrarCodigo] = () => manejoForm.AccionBorrarDato(txtCodigo),
                [btnBorrarNombre] = () => manejoForm.AccionBorrarDato(txtNombre),
                [btnBorrarN_practicas] = () => manejoForm.AccionBorrarDato(txtN_practicas),
                [btnBorrarN_examenes] = () => manejoForm.AccionBorrarDato(txtN_examenes),
                [btnBorrarTodo] = () => manejoForm.AccionBorrarDato(),

                // --- OTRAS ACCIONES ---
                [btnAbrirLog] = () => UIManager.AbrirLog(_logArchivo),
                [btnBorrarLog] = () => UIManager.BorrarLog(_logArchivo),
                [btnRefrescar] = () => manejoForm.AccionRefrescado()
            };
            mapaTextos = new Dictionary<TextBox, Action>
            {
                [txtCodigo] = () => manejoForm?.ProcesarCajaDeTexto(this.txtCodigo, _regexCodigos),
                [txtNombre] = () => manejoForm?.AlterarBotonesDeTextBox(),
                [txtN_practicas] = () => manejoForm?.AlterarBotonesDeTextBox(),
                [txtN_examenes] = () => manejoForm?.AlterarBotonesDeTextBox()
            };
            mapaEntidad = new Dictionary<TextBox, (Func<string> Get, Action<string> Set)>
            {
                [txtCodigo] = (() => this.gestionBackend.Entidad.Codigo, val => this.gestionBackend.Entidad.Codigo = val),
                [txtNombre] = (() => this.gestionBackend.Entidad.Nombre, val => this.gestionBackend.Entidad.Nombre = val),
                [txtN_practicas] = (() => this.gestionBackend.Entidad.N_practicas, val => this.gestionBackend.Entidad.N_practicas = val),
                [txtN_examenes] = (() => this.gestionBackend.Entidad.N_examenes, val => this.gestionBackend.Entidad.N_examenes = val),
            };
        }
    }
}
