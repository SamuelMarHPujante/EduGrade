namespace EduGrade._01view.manejo_individual
{
    partial class FrmCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            cbxCopiarTodo = new CheckBox();
            btnCopiarTodo = new Button();
            btnBorrarNombre = new Button();
            btnCopiarNombre = new Button();
            btnBorrarCodigo = new Button();
            btnCopiarCodigo = new Button();
            label7 = new Label();
            txtFilaActual = new TextBox();
            label6 = new Label();
            txtTotalFilas = new TextBox();
            cbxBorrarTodo = new CheckBox();
            btnRefrescar = new Button();
            btnBorrarTodo = new Button();
            btnBuscar = new Button();
            btnBorrar = new Button();
            btnInsertar = new Button();
            btnEditar = new Button();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            lblMensajes = new Label();
            dgvListaCursos = new DataGridView();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnBorrarLog = new Button();
            label8 = new Label();
            btnAbrirLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbxCopiarTodo
            // 
            cbxCopiarTodo.AutoSize = true;
            cbxCopiarTodo.Checked = true;
            cbxCopiarTodo.CheckState = CheckState.Checked;
            cbxCopiarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbxCopiarTodo.Location = new Point(334, 262);
            cbxCopiarTodo.Name = "cbxCopiarTodo";
            cbxCopiarTodo.Size = new Size(53, 19);
            cbxCopiarTodo.TabIndex = 140;
            cbxCopiarTodo.Tag = "Global";
            cbxCopiarTodo.Text = "Auto";
            cbxCopiarTodo.UseVisualStyleBackColor = false;
            // 
            // btnCopiarTodo
            // 
            btnCopiarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarTodo.Location = new Point(228, 250);
            btnCopiarTodo.Name = "btnCopiarTodo";
            btnCopiarTodo.Size = new Size(100, 40);
            btnCopiarTodo.TabIndex = 139;
            btnCopiarTodo.Tag = "Copiado";
            btnCopiarTodo.Text = "Copiar todo";
            btnCopiarTodo.UseVisualStyleBackColor = true;
            // 
            // btnBorrarNombre
            // 
            btnBorrarNombre.BackColor = Color.Red;
            btnBorrarNombre.FlatStyle = FlatStyle.Flat;
            btnBorrarNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarNombre.ForeColor = Color.White;
            btnBorrarNombre.Location = new Point(122, 145);
            btnBorrarNombre.Name = "btnBorrarNombre";
            btnBorrarNombre.Size = new Size(23, 23);
            btnBorrarNombre.TabIndex = 132;
            btnBorrarNombre.Tag = "Borrado";
            btnBorrarNombre.Text = "X";
            btnBorrarNombre.UseVisualStyleBackColor = false;
            // 
            // btnCopiarNombre
            // 
            btnCopiarNombre.FlatStyle = FlatStyle.Flat;
            btnCopiarNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarNombre.Location = new Point(305, 145);
            btnCopiarNombre.Name = "btnCopiarNombre";
            btnCopiarNombre.Size = new Size(23, 23);
            btnCopiarNombre.TabIndex = 131;
            btnCopiarNombre.Tag = "Copiado";
            btnCopiarNombre.Text = "<";
            btnCopiarNombre.UseVisualStyleBackColor = true;
            // 
            // btnBorrarCodigo
            // 
            btnBorrarCodigo.BackColor = Color.Red;
            btnBorrarCodigo.FlatStyle = FlatStyle.Flat;
            btnBorrarCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarCodigo.ForeColor = Color.White;
            btnBorrarCodigo.Location = new Point(122, 103);
            btnBorrarCodigo.Name = "btnBorrarCodigo";
            btnBorrarCodigo.Size = new Size(23, 23);
            btnBorrarCodigo.TabIndex = 130;
            btnBorrarCodigo.Tag = "Borrado";
            btnBorrarCodigo.Text = "X";
            btnBorrarCodigo.UseVisualStyleBackColor = false;
            // 
            // btnCopiarCodigo
            // 
            btnCopiarCodigo.FlatStyle = FlatStyle.Flat;
            btnCopiarCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarCodigo.Location = new Point(305, 103);
            btnCopiarCodigo.Name = "btnCopiarCodigo";
            btnCopiarCodigo.Size = new Size(23, 23);
            btnCopiarCodigo.TabIndex = 129;
            btnCopiarCodigo.Tag = "Copiado";
            btnCopiarCodigo.Text = "<";
            btnCopiarCodigo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(390, 357);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 128;
            label7.Text = "Fila:";
            // 
            // txtFilaActual
            // 
            txtFilaActual.Location = new Point(424, 354);
            txtFilaActual.Name = "txtFilaActual";
            txtFilaActual.ReadOnly = true;
            txtFilaActual.Size = new Size(33, 23);
            txtFilaActual.TabIndex = 127;
            txtFilaActual.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(381, 386);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 126;
            label6.Text = "Total:";
            // 
            // txtTotalFilas
            // 
            txtTotalFilas.Location = new Point(424, 383);
            txtTotalFilas.Name = "txtTotalFilas";
            txtTotalFilas.ReadOnly = true;
            txtTotalFilas.Size = new Size(33, 23);
            txtTotalFilas.TabIndex = 125;
            txtTotalFilas.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxBorrarTodo
            // 
            cbxBorrarTodo.AutoSize = true;
            cbxBorrarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbxBorrarTodo.Location = new Point(63, 262);
            cbxBorrarTodo.Name = "cbxBorrarTodo";
            cbxBorrarTodo.RightToLeft = RightToLeft.Yes;
            cbxBorrarTodo.Size = new Size(53, 19);
            cbxBorrarTodo.TabIndex = 124;
            cbxBorrarTodo.Tag = "Global";
            cbxBorrarTodo.Text = "Auto";
            cbxBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescar.Location = new Point(1083, 409);
            btnRefrescar.Margin = new Padding(3, 2, 3, 2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(82, 33);
            btnRefrescar.TabIndex = 122;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = Color.DarkRed;
            btnBorrarTodo.FlatStyle = FlatStyle.Flat;
            btnBorrarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarTodo.ForeColor = Color.White;
            btnBorrarTodo.Location = new Point(122, 250);
            btnBorrarTodo.Margin = new Padding(3, 2, 3, 2);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(100, 40);
            btnBorrarTodo.TabIndex = 121;
            btnBorrarTodo.Tag = "Borrado";
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(725, 410);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 33);
            btnBuscar.TabIndex = 120;
            btnBuscar.Tag = "Gestion";
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Location = new Point(638, 410);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(82, 33);
            btnBorrar.TabIndex = 119;
            btnBorrar.Tag = "Gestion";
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Location = new Point(550, 410);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(82, 33);
            btnInsertar.TabIndex = 118;
            btnInsertar.Tag = "Gestion";
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(463, 410);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 33);
            btnEditar.TabIndex = 117;
            btnEditar.Tag = "Gestion";
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnUltimo.Location = new Point(281, 295);
            btnUltimo.Margin = new Padding(3, 2, 3, 2);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(47, 47);
            btnUltimo.TabIndex = 116;
            btnUltimo.Tag = "Navegacion";
            btnUltimo.Text = ">>";
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnSiguiente.Location = new Point(229, 295);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(47, 47);
            btnSiguiente.TabIndex = 115;
            btnSiguiente.Tag = "Navegacion";
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnAnterior.Location = new Point(176, 295);
            btnAnterior.Margin = new Padding(3, 2, 3, 2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(47, 47);
            btnAnterior.TabIndex = 114;
            btnAnterior.Tag = "Navegacion";
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnPrimero.Location = new Point(123, 295);
            btnPrimero.Margin = new Padding(3, 2, 3, 2);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(47, 47);
            btnPrimero.TabIndex = 113;
            btnPrimero.Tag = "Navegacion";
            btnPrimero.Text = "<<";
            btnPrimero.UseVisualStyleBackColor = true;
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMensajes.Location = new Point(463, 10);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(125, 21);
            lblMensajes.TabIndex = 112;
            lblMensajes.Text = "Estado proceso";
            // 
            // dgvListaCursos
            // 
            dgvListaCursos.AllowUserToResizeColumns = false;
            dgvListaCursos.AllowUserToResizeRows = false;
            dgvListaCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaCursos.ColumnHeadersHeight = 29;
            dgvListaCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaCursos.Location = new Point(463, 40);
            dgvListaCursos.Margin = new Padding(3, 2, 3, 2);
            dgvListaCursos.MultiSelect = false;
            dgvListaCursos.Name = "dgvListaCursos";
            dgvListaCursos.ReadOnly = true;
            dgvListaCursos.RowHeadersVisible = false;
            dgvListaCursos.RowHeadersWidth = 51;
            dgvListaCursos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListaCursos.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvListaCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaCursos.Size = new Size(702, 366);
            dgvListaCursos.TabIndex = 111;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 145);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 23);
            txtNombre.TabIndex = 104;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(147, 128);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 103;
            label2.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCodigo.Location = new Point(151, 103);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(148, 23);
            txtCodigo.TabIndex = 102;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(147, 86);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 101;
            label1.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(151, 170);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 141;
            label3.Text = "*El nombre no puede repetirse";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 142;
            pictureBox1.TabStop = false;
            // 
            // btnBorrarLog
            // 
            btnBorrarLog.FlatStyle = FlatStyle.Flat;
            btnBorrarLog.Location = new Point(73, 407);
            btnBorrarLog.Name = "btnBorrarLog";
            btnBorrarLog.Size = new Size(55, 33);
            btnBorrarLog.TabIndex = 148;
            btnBorrarLog.Text = "Borrar";
            btnBorrarLog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(12, 389);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 147;
            label8.Text = "Log de curso";
            // 
            // btnAbrirLog
            // 
            btnAbrirLog.FlatStyle = FlatStyle.Flat;
            btnAbrirLog.Location = new Point(12, 407);
            btnAbrirLog.Name = "btnAbrirLog";
            btnAbrirLog.Size = new Size(55, 33);
            btnAbrirLog.TabIndex = 146;
            btnAbrirLog.Text = "Abrir";
            btnAbrirLog.UseVisualStyleBackColor = true;
            // 
            // FrmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 452);
            Controls.Add(btnBorrarLog);
            Controls.Add(label8);
            Controls.Add(btnAbrirLog);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(cbxCopiarTodo);
            Controls.Add(btnCopiarTodo);
            Controls.Add(btnBorrarNombre);
            Controls.Add(btnCopiarNombre);
            Controls.Add(btnBorrarCodigo);
            Controls.Add(btnCopiarCodigo);
            Controls.Add(label7);
            Controls.Add(txtFilaActual);
            Controls.Add(label6);
            Controls.Add(txtTotalFilas);
            Controls.Add(cbxBorrarTodo);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBuscar);
            Controls.Add(btnBorrar);
            Controls.Add(btnInsertar);
            Controls.Add(btnEditar);
            Controls.Add(btnUltimo);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnPrimero);
            Controls.Add(lblMensajes);
            Controls.Add(dgvListaCursos);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbxCopiarTodo;
        private Button btnCopiarTodo;
        private Button btnBorrarNombre;
        private Button btnCopiarNombre;
        private Button btnBorrarCodigo;
        private Button btnCopiarCodigo;
        private Label label7;
        private TextBox txtFilaActual;
        private Label label6;
        private TextBox txtTotalFilas;
        private CheckBox cbxBorrarTodo;
        private Button btnRefrescar;
        private Button btnBorrarTodo;
        private Button btnBuscar;
        private Button btnBorrar;
        private Button btnInsertar;
        private Button btnEditar;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private Label lblMensajes;
        private DataGridView dgvListaCursos;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnBorrarLog;
        private Label label8;
        private Button btnAbrirLog;
    }
}