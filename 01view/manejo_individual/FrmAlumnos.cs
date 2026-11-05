using EduGrade._02aplication;
using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_individual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EduGrade.Globales;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace EduGrade._01view.manejo_individual
{
    public partial class FrmAlumnos : Form
    {
        private Dictionary<Button, Action> mapaBotones;
        private Dictionary<TextBox, Action> mapaTextos;
        private Dictionary<TextBox, (Func<string> Get, Action<string> Set)> mapaEntidad;

        private GestionAlumnos gestionBackend;
        private readonly string _logArchivo = _logAlumno;

        private ManejadorFormIndividual<Alumno> manejoForm;

        public FrmAlumnos()
        {
            InitializeComponent();
            InicializarDiccionarios();

            gestionBackend = new GestionAlumnos();
            manejoForm = new ManejadorFormIndividual<Alumno>(
                accionesBotones: mapaBotones,
                camposTxt: mapaTextos,
                mapeadoEntidad: mapaEntidad,

                clavePrimariaTxt: this.txtDni,
                gestionBackend: gestionBackend,
                archivoLog: _logArchivo,
                nombreEntidad: "alumno",

                dgvLista: dgvListaAlumnos,
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
                [btnCopiarDni] = () => manejoForm.AccionCopiarDato(txtDni),
                [btnCopiarNombre] = () => manejoForm.AccionCopiarDato(txtNombre),
                [btnCopiarApellidos] = () => manejoForm.AccionCopiarDato(txtApellidos),
                [btnCopiarTelefono] = () => manejoForm.AccionCopiarDato(txtTelefono),
                [btnCopiarPoblacion] = () => manejoForm.AccionCopiarDato(txtPoblacion),
                [btnCopiarTodo] = () => manejoForm.AccionCopiarDato(),

                // --- ACCIONES DE BORRADO ---
                [btnBorrarDni] = () => manejoForm.AccionBorrarDato(txtDni),
                [btnBorrarNombre] = () => manejoForm.AccionBorrarDato(txtNombre),
                [btnBorrarApellidos] = () => manejoForm.AccionBorrarDato(txtApellidos),
                [btnBorrarTelefono] = () => manejoForm.AccionBorrarDato(txtTelefono),
                [btnBorrarPoblacion] = () => manejoForm.AccionBorrarDato(txtPoblacion),
                [btnBorrarTodo] = () => manejoForm.AccionBorrarDato(),

                // --- OTRAS ACCIONES ---
                [btnAbrirLog] = () => UIManager.AbrirLog(_logArchivo),
                [btnBorrarLog] = () => UIManager.BorrarLog(_logArchivo),
                [btnRefrescar] = () => manejoForm.AccionRefrescado()
            };
            mapaTextos = new Dictionary<TextBox, Action>
            {
                [this.txtDni] = () => manejoForm?.ProcesarCajaDeTexto(this.txtDni, _regexDni, _regexDniNumerico),
                [this.txtNombre] = () => manejoForm?.AlterarBotonesDeTextBox(),
                [this.txtApellidos] = () => manejoForm?.AlterarBotonesDeTextBox(),
                [this.txtTelefono] = () => manejoForm?.AlterarBotonesDeTextBox(),
                [this.txtPoblacion] = () => manejoForm?.AlterarBotonesDeTextBox()
            };
            mapaEntidad = new Dictionary<TextBox, (Func<string> Get, Action<string> Set)>
            {
                [this.txtDni] = (() => this.gestionBackend.Entidad.Dni, val => this.gestionBackend.Entidad.Dni = val),
                [this.txtNombre] = (() => this.gestionBackend.Entidad.Nombre, val => this.gestionBackend.Entidad.Nombre = val),
                [this.txtApellidos] = (() => this.gestionBackend.Entidad.Apellidos, val => this.gestionBackend.Entidad.Apellidos = val),
                [this.txtTelefono] = (() => this.gestionBackend.Entidad.Telefono, val => this.gestionBackend.Entidad.Telefono = val),
                [this.txtPoblacion] = (() => this.gestionBackend.Entidad.Poblacion, val => this.gestionBackend.Entidad.Poblacion = val)
            };
        }
    }
}