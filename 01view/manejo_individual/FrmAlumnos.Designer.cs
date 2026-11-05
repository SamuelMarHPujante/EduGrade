namespace EduGrade._01view.manejo_individual
{
    partial class FrmAlumnos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlumnos));
            cbxCopiarTodo = new CheckBox();
            btnCopiarTodo = new Button();
            btnBorrarPoblacion = new Button();
            btnCopiarPoblacion = new Button();
            btnBorrarTelefono = new Button();
            btnCopiarTelefono = new Button();
            btnBorrarApellidos = new Button();
            btnCopiarApellidos = new Button();
            btnBorrarNombre = new Button();
            btnCopiarNombre = new Button();
            btnBorrarDni = new Button();
            btnCopiarDni = new Button();
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
            dgvListaAlumnos = new DataGridView();
            txtPoblacion = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtApellidos = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDni = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnBorrarLog = new Button();
            label8 = new Label();
            btnAbrirLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbxCopiarTodo
            // 
            cbxCopiarTodo.AutoSize = true;
            cbxCopiarTodo.Checked = true;
            cbxCopiarTodo.CheckState = CheckState.Checked;
            cbxCopiarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbxCopiarTodo.Location = new Point(334, 260);
            cbxCopiarTodo.Name = "cbxCopiarTodo";
            cbxCopiarTodo.Size = new Size(53, 19);
            cbxCopiarTodo.TabIndex = 100;
            cbxCopiarTodo.Tag = "Global";
            cbxCopiarTodo.Text = "Auto";
            cbxCopiarTodo.UseVisualStyleBackColor = false;
            // 
            // btnCopiarTodo
            // 
            btnCopiarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarTodo.Location = new Point(228, 248);
            btnCopiarTodo.Name = "btnCopiarTodo";
            btnCopiarTodo.Size = new Size(100, 40);
            btnCopiarTodo.TabIndex = 99;
            btnCopiarTodo.Tag = "Copiado";
            btnCopiarTodo.Text = "Copiar todo";
            btnCopiarTodo.UseVisualStyleBackColor = true;
            // 
            // btnBorrarPoblacion
            // 
            btnBorrarPoblacion.BackColor = Color.Red;
            btnBorrarPoblacion.FlatStyle = FlatStyle.Flat;
            btnBorrarPoblacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarPoblacion.ForeColor = Color.White;
            btnBorrarPoblacion.Location = new Point(122, 206);
            btnBorrarPoblacion.Name = "btnBorrarPoblacion";
            btnBorrarPoblacion.Size = new Size(23, 23);
            btnBorrarPoblacion.TabIndex = 96;
            btnBorrarPoblacion.Tag = "Borrado";
            btnBorrarPoblacion.Text = "X";
            btnBorrarPoblacion.UseVisualStyleBackColor = false;
            // 
            // btnCopiarPoblacion
            // 
            btnCopiarPoblacion.FlatStyle = FlatStyle.Flat;
            btnCopiarPoblacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarPoblacion.Location = new Point(305, 206);
            btnCopiarPoblacion.Name = "btnCopiarPoblacion";
            btnCopiarPoblacion.Size = new Size(23, 23);
            btnCopiarPoblacion.TabIndex = 95;
            btnCopiarPoblacion.Tag = "Copiado";
            btnCopiarPoblacion.Text = "<";
            btnCopiarPoblacion.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTelefono
            // 
            btnBorrarTelefono.BackColor = Color.Red;
            btnBorrarTelefono.FlatStyle = FlatStyle.Flat;
            btnBorrarTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarTelefono.ForeColor = Color.White;
            btnBorrarTelefono.Location = new Point(122, 164);
            btnBorrarTelefono.Name = "btnBorrarTelefono";
            btnBorrarTelefono.Size = new Size(23, 23);
            btnBorrarTelefono.TabIndex = 92;
            btnBorrarTelefono.Tag = "Borrado";
            btnBorrarTelefono.Text = "X";
            btnBorrarTelefono.UseVisualStyleBackColor = false;
            // 
            // btnCopiarTelefono
            // 
            btnCopiarTelefono.FlatStyle = FlatStyle.Flat;
            btnCopiarTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarTelefono.Location = new Point(305, 164);
            btnCopiarTelefono.Name = "btnCopiarTelefono";
            btnCopiarTelefono.Size = new Size(23, 23);
            btnCopiarTelefono.TabIndex = 91;
            btnCopiarTelefono.Tag = "Copiado";
            btnCopiarTelefono.Text = "<";
            btnCopiarTelefono.UseVisualStyleBackColor = true;
            // 
            // btnBorrarApellidos
            // 
            btnBorrarApellidos.BackColor = Color.Red;
            btnBorrarApellidos.FlatStyle = FlatStyle.Flat;
            btnBorrarApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarApellidos.ForeColor = Color.White;
            btnBorrarApellidos.Location = new Point(122, 122);
            btnBorrarApellidos.Name = "btnBorrarApellidos";
            btnBorrarApellidos.Size = new Size(23, 23);
            btnBorrarApellidos.TabIndex = 88;
            btnBorrarApellidos.Tag = "Borrado";
            btnBorrarApellidos.Text = "X";
            btnBorrarApellidos.UseVisualStyleBackColor = false;
            // 
            // btnCopiarApellidos
            // 
            btnCopiarApellidos.FlatStyle = FlatStyle.Flat;
            btnCopiarApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarApellidos.Location = new Point(305, 122);
            btnCopiarApellidos.Name = "btnCopiarApellidos";
            btnCopiarApellidos.Size = new Size(23, 23);
            btnCopiarApellidos.TabIndex = 87;
            btnCopiarApellidos.Tag = "Copiado";
            btnCopiarApellidos.Text = "<";
            btnCopiarApellidos.UseVisualStyleBackColor = true;
            // 
            // btnBorrarNombre
            // 
            btnBorrarNombre.BackColor = Color.Red;
            btnBorrarNombre.FlatStyle = FlatStyle.Flat;
            btnBorrarNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarNombre.ForeColor = Color.White;
            btnBorrarNombre.Location = new Point(122, 80);
            btnBorrarNombre.Name = "btnBorrarNombre";
            btnBorrarNombre.Size = new Size(23, 23);
            btnBorrarNombre.TabIndex = 84;
            btnBorrarNombre.Tag = "Borrado";
            btnBorrarNombre.Text = "X";
            btnBorrarNombre.UseVisualStyleBackColor = false;
            // 
            // btnCopiarNombre
            // 
            btnCopiarNombre.FlatStyle = FlatStyle.Flat;
            btnCopiarNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarNombre.Location = new Point(305, 80);
            btnCopiarNombre.Name = "btnCopiarNombre";
            btnCopiarNombre.Size = new Size(23, 23);
            btnCopiarNombre.TabIndex = 83;
            btnCopiarNombre.Tag = "Copiado";
            btnCopiarNombre.Text = "<";
            btnCopiarNombre.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDni
            // 
            btnBorrarDni.BackColor = Color.Red;
            btnBorrarDni.FlatStyle = FlatStyle.Flat;
            btnBorrarDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarDni.ForeColor = Color.White;
            btnBorrarDni.Location = new Point(122, 38);
            btnBorrarDni.Name = "btnBorrarDni";
            btnBorrarDni.Size = new Size(23, 23);
            btnBorrarDni.TabIndex = 80;
            btnBorrarDni.Tag = "Borrado";
            btnBorrarDni.Text = "X";
            btnBorrarDni.UseVisualStyleBackColor = false;
            // 
            // btnCopiarDni
            // 
            btnCopiarDni.FlatStyle = FlatStyle.Flat;
            btnCopiarDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopiarDni.Location = new Point(305, 38);
            btnCopiarDni.Name = "btnCopiarDni";
            btnCopiarDni.Size = new Size(23, 23);
            btnCopiarDni.TabIndex = 79;
            btnCopiarDni.Tag = "Copiado";
            btnCopiarDni.Text = "<";
            btnCopiarDni.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(390, 355);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 78;
            label7.Text = "Fila:";
            // 
            // txtFilaActual
            // 
            txtFilaActual.Location = new Point(424, 352);
            txtFilaActual.Name = "txtFilaActual";
            txtFilaActual.ReadOnly = true;
            txtFilaActual.Size = new Size(33, 23);
            txtFilaActual.TabIndex = 77;
            txtFilaActual.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(381, 384);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 76;
            label6.Text = "Total:";
            // 
            // txtTotalFilas
            // 
            txtTotalFilas.Location = new Point(424, 381);
            txtTotalFilas.Name = "txtTotalFilas";
            txtTotalFilas.ReadOnly = true;
            txtTotalFilas.Size = new Size(33, 23);
            txtTotalFilas.TabIndex = 75;
            txtTotalFilas.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxBorrarTodo
            // 
            cbxBorrarTodo.AutoSize = true;
            cbxBorrarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbxBorrarTodo.Location = new Point(63, 260);
            cbxBorrarTodo.Name = "cbxBorrarTodo";
            cbxBorrarTodo.RightToLeft = RightToLeft.Yes;
            cbxBorrarTodo.Size = new Size(53, 19);
            cbxBorrarTodo.TabIndex = 74;
            cbxBorrarTodo.Tag = "Global";
            cbxBorrarTodo.Text = "Auto";
            cbxBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescar.Location = new Point(1083, 407);
            btnRefrescar.Margin = new Padding(3, 2, 3, 2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(82, 33);
            btnRefrescar.TabIndex = 72;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = Color.DarkRed;
            btnBorrarTodo.FlatStyle = FlatStyle.Flat;
            btnBorrarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarTodo.ForeColor = Color.White;
            btnBorrarTodo.Location = new Point(122, 248);
            btnBorrarTodo.Margin = new Padding(3, 2, 3, 2);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(100, 40);
            btnBorrarTodo.TabIndex = 71;
            btnBorrarTodo.Tag = "Borrado";
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(725, 408);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 33);
            btnBuscar.TabIndex = 70;
            btnBuscar.Tag = "Gestion";
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Location = new Point(638, 408);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(82, 33);
            btnBorrar.TabIndex = 69;
            btnBorrar.Tag = "Gestion";
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Location = new Point(550, 408);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(82, 33);
            btnInsertar.TabIndex = 68;
            btnInsertar.Tag = "Gestion";
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(463, 408);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 33);
            btnEditar.TabIndex = 67;
            btnEditar.Tag = "Gestion";
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnUltimo.Location = new Point(281, 293);
            btnUltimo.Margin = new Padding(3, 2, 3, 2);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(47, 47);
            btnUltimo.TabIndex = 66;
            btnUltimo.Tag = "Navegacion";
            btnUltimo.Text = ">>";
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnSiguiente.Location = new Point(229, 293);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(47, 47);
            btnSiguiente.TabIndex = 65;
            btnSiguiente.Tag = "Navegacion";
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnAnterior.Location = new Point(176, 293);
            btnAnterior.Margin = new Padding(3, 2, 3, 2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(47, 47);
            btnAnterior.TabIndex = 64;
            btnAnterior.Tag = "Navegacion";
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnPrimero.Location = new Point(123, 293);
            btnPrimero.Margin = new Padding(3, 2, 3, 2);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(47, 47);
            btnPrimero.TabIndex = 63;
            btnPrimero.Tag = "Navegacion";
            btnPrimero.Text = "<<";
            btnPrimero.UseVisualStyleBackColor = true;
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMensajes.Location = new Point(463, 8);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(125, 21);
            lblMensajes.TabIndex = 62;
            lblMensajes.Text = "Estado proceso";
            // 
            // dgvListaAlumnos
            // 
            dgvListaAlumnos.AllowUserToResizeColumns = false;
            dgvListaAlumnos.AllowUserToResizeRows = false;
            dgvListaAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaAlumnos.ColumnHeadersHeight = 29;
            dgvListaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaAlumnos.Location = new Point(463, 38);
            dgvListaAlumnos.Margin = new Padding(3, 2, 3, 2);
            dgvListaAlumnos.MultiSelect = false;
            dgvListaAlumnos.Name = "dgvListaAlumnos";
            dgvListaAlumnos.ReadOnly = true;
            dgvListaAlumnos.RowHeadersVisible = false;
            dgvListaAlumnos.RowHeadersWidth = 51;
            dgvListaAlumnos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListaAlumnos.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvListaAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaAlumnos.Size = new Size(702, 366);
            dgvListaAlumnos.TabIndex = 61;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Location = new Point(151, 206);
            txtPoblacion.Margin = new Padding(3, 2, 3, 2);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.Size = new Size(148, 23);
            txtPoblacion.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(147, 189);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 59;
            label5.Text = "Población:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(151, 164);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(148, 23);
            txtTelefono.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(147, 147);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 57;
            label3.Text = "Teléfono:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(151, 122);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(148, 23);
            txtApellidos.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(147, 105);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 55;
            label4.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 80);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 23);
            txtNombre.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(147, 63);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 53;
            label2.Text = "Nombre:";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDni.Location = new Point(151, 38);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(148, 23);
            txtDni.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(147, 21);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 51;
            label1.Text = "DNI:";
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
            btnBorrarLog.TabIndex = 145;
            btnBorrarLog.Text = "Borrar";
            btnBorrarLog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(12, 389);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 144;
            label8.Text = "Log de alumno";
            // 
            // btnAbrirLog
            // 
            btnAbrirLog.FlatStyle = FlatStyle.Flat;
            btnAbrirLog.Location = new Point(12, 407);
            btnAbrirLog.Name = "btnAbrirLog";
            btnAbrirLog.Size = new Size(55, 33);
            btnAbrirLog.TabIndex = 143;
            btnAbrirLog.Text = "Abrir";
            btnAbrirLog.UseVisualStyleBackColor = true;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 452);
            Controls.Add(btnBorrarLog);
            Controls.Add(label8);
            Controls.Add(btnAbrirLog);
            Controls.Add(pictureBox1);
            Controls.Add(cbxCopiarTodo);
            Controls.Add(btnCopiarTodo);
            Controls.Add(btnBorrarPoblacion);
            Controls.Add(btnCopiarPoblacion);
            Controls.Add(btnBorrarTelefono);
            Controls.Add(btnCopiarTelefono);
            Controls.Add(btnBorrarApellidos);
            Controls.Add(btnCopiarApellidos);
            Controls.Add(btnBorrarNombre);
            Controls.Add(btnCopiarNombre);
            Controls.Add(btnBorrarDni);
            Controls.Add(btnCopiarDni);
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
            Controls.Add(dgvListaAlumnos);
            Controls.Add(txtPoblacion);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmAlumnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumnado";
            ((System.ComponentModel.ISupportInitialize)dgvListaAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbxCopiarTodo;
        private Button btnCopiarTodo;
        private Button btnBorrarPoblacion;
        private Button btnCopiarPoblacion;
        private Button btnBorrarTelefono;
        private Button btnCopiarTelefono;
        private Button btnBorrarApellidos;
        private Button btnCopiarApellidos;
        private Button btnBorrarNombre;
        private Button btnCopiarNombre;
        private Button btnBorrarDni;
        private Button btnCopiarDni;
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
        private DataGridView dgvListaAlumnos;
        private TextBox txtPoblacion;
        private Label label5;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtApellidos;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDni;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnBorrarLog;
        private Label label8;
        private Button btnAbrirLog;
    }
}