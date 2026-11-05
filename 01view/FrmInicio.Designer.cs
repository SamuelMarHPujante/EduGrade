namespace EduGrade
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            btnAlumnos = new Button();
            pictureBox1 = new PictureBox();
            btnAbrirLog = new Button();
            btnCursos = new Button();
            btnContenidos = new Button();
            btnMatriculas = new Button();
            btnModulos = new Button();
            btnCalificaciones = new Button();
            label1 = new Label();
            btnBorrarLog = new Button();
            btnBorrarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAlumnos
            // 
            btnAlumnos.BackColor = Color.Azure;
            btnAlumnos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAlumnos.Location = new Point(489, 12);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(158, 41);
            btnAlumnos.TabIndex = 0;
            btnAlumnos.Text = "- Alumnos -";
            btnAlumnos.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnAbrirLog
            // 
            btnAbrirLog.FlatStyle = FlatStyle.Flat;
            btnAbrirLog.Location = new Point(12, 255);
            btnAbrirLog.Name = "btnAbrirLog";
            btnAbrirLog.Size = new Size(55, 33);
            btnAbrirLog.TabIndex = 74;
            btnAbrirLog.Text = "Abrir";
            btnAbrirLog.UseVisualStyleBackColor = true;
            // 
            // btnCursos
            // 
            btnCursos.BackColor = Color.Azure;
            btnCursos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCursos.Location = new Point(489, 59);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(158, 41);
            btnCursos.TabIndex = 75;
            btnCursos.Text = "- Cursos -";
            btnCursos.UseVisualStyleBackColor = false;
            // 
            // btnContenidos
            // 
            btnContenidos.BackColor = Color.LemonChiffon;
            btnContenidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnContenidos.Location = new Point(489, 153);
            btnContenidos.Name = "btnContenidos";
            btnContenidos.Size = new Size(158, 41);
            btnContenidos.TabIndex = 76;
            btnContenidos.Text = "Contenidos";
            btnContenidos.UseVisualStyleBackColor = false;
            // 
            // btnMatriculas
            // 
            btnMatriculas.BackColor = Color.LemonChiffon;
            btnMatriculas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMatriculas.Location = new Point(489, 200);
            btnMatriculas.Name = "btnMatriculas";
            btnMatriculas.Size = new Size(158, 41);
            btnMatriculas.TabIndex = 77;
            btnMatriculas.Text = "Matriculación";
            btnMatriculas.UseVisualStyleBackColor = false;
            // 
            // btnModulos
            // 
            btnModulos.BackColor = Color.Azure;
            btnModulos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModulos.Location = new Point(489, 106);
            btnModulos.Name = "btnModulos";
            btnModulos.Size = new Size(158, 41);
            btnModulos.TabIndex = 78;
            btnModulos.Text = "- Módulos -";
            btnModulos.UseVisualStyleBackColor = false;
            // 
            // btnCalificaciones
            // 
            btnCalificaciones.BackColor = Color.LemonChiffon;
            btnCalificaciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalificaciones.Location = new Point(489, 247);
            btnCalificaciones.Name = "btnCalificaciones";
            btnCalificaciones.Size = new Size(158, 41);
            btnCalificaciones.TabIndex = 79;
            btnCalificaciones.Text = "Calificaciones";
            btnCalificaciones.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 237);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 81;
            label1.Text = "Log de usuario";
            // 
            // btnBorrarLog
            // 
            btnBorrarLog.FlatStyle = FlatStyle.Flat;
            btnBorrarLog.Location = new Point(73, 255);
            btnBorrarLog.Name = "btnBorrarLog";
            btnBorrarLog.Size = new Size(55, 33);
            btnBorrarLog.TabIndex = 82;
            btnBorrarLog.Text = "Borrar";
            btnBorrarLog.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodos
            // 
            btnBorrarTodos.FlatStyle = FlatStyle.Flat;
            btnBorrarTodos.Location = new Point(12, 153);
            btnBorrarTodos.Name = "btnBorrarTodos";
            btnBorrarTodos.Size = new Size(116, 33);
            btnBorrarTodos.TabIndex = 83;
            btnBorrarTodos.Text = "Borrar logs";
            btnBorrarTodos.UseVisualStyleBackColor = true;
            btnBorrarTodos.Click += BorrarTodos_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 300);
            Controls.Add(btnBorrarTodos);
            Controls.Add(btnBorrarLog);
            Controls.Add(label1);
            Controls.Add(btnCalificaciones);
            Controls.Add(btnModulos);
            Controls.Add(btnMatriculas);
            Controls.Add(btnContenidos);
            Controls.Add(btnCursos);
            Controls.Add(btnAbrirLog);
            Controls.Add(pictureBox1);
            Controls.Add(btnAlumnos);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlumnos;
        private PictureBox pictureBox1;
        private Button btnAbrirLog;
        private Button btnCursos;
        private Button btnContenidos;
        private Button btnMatriculas;
        private Button btnModulos;
        private Button btnCalificaciones;
        private Label label1;
        private Button btnBorrarLog;
        private Button btnBorrarTodos;
    }
}
