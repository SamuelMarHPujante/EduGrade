using EduGrade._01view;
using EduGrade._01view.manejo_individual;
using EduGrade._01view.manejo_relaciones;

namespace EduGrade
{
    public partial class FrmInicio : Form
    {
        private Dictionary<Button, Func<Form>> _gestionadores;

        public FrmInicio()
        {
            InitializeComponent();
            BorrarTodosLosLogs();
            _gestionadores = new Dictionary<Button, Func<Form>>()
            {
                [btnAlumnos] = () => new FrmAlumnos(),
                [btnCursos] = () => new FrmCursos(),
                [btnModulos] = () => new FrmModulos(),
                [btnMatriculas] = () => new FrmMatriculacion(),
                [btnContenidos] = () => new FrmContenidos(),
                [btnCalificaciones] = () => new FrmCalificaciones()
            };

            AsignarAcciones();
        }

        #region Asignación de eventos automático

        private void AsignarAcciones()
        {
            foreach (Button btn in _gestionadores.Keys)
            {
                btn.Click += Menus_Click;
            }
            btnAbrirLog.Click += AbrirLog_Click;
            btnBorrarLog.Click += BorrarLog_Click;
        }

        private void Menus_Click(object sender, EventArgs e)
        {
            Button emisor = (Button)sender;
            if (_gestionadores.ContainsKey(emisor))
            {
                this.Hide();
                Form pantalla = _gestionadores[emisor].Invoke();
                RegistroLogs.RegistrarEnLog($"Elemento {pantalla.Name} iniciado");
                pantalla.ShowDialog();
                pantalla.Dispose();
                this.Show();
            }
        }

        private void AbrirLog_Click(object sender, EventArgs e) => UIManager.AbrirLog();
        private void BorrarLog_Click(object sender, EventArgs e) => UIManager.BorrarLog();
        private void BorrarTodos_Click(object sender, EventArgs e) => BorrarTodosLosLogs();

        #endregion

        private void BorrarTodosLosLogs()
        {
            var rutasDeLogs = typeof(Globales)
                .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Where(campo => campo.FieldType == typeof(string) && campo.Name.StartsWith("_log"))
                .Select(campo => (string)campo.GetValue(null));

            foreach (string rutaLog in rutasDeLogs) RegistroLogs.BorrarLog(rutaLog);
        }
    }
}
