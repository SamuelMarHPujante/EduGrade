namespace EduGrade._01view.manejo_relaciones
{
    partial class FrmCalificaciones
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalificaciones));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnBorrarSeguidora = new Button();
            btnBorrarDominante = new Button();
            label3 = new Label();
            btnBorrarLog = new Button();
            label8 = new Label();
            btnAbrirLog = new Button();
            btnRefrescarSeguidora = new Button();
            btnRefrescarDominante = new Button();
            btnRelacionesSeguidora = new Button();
            btnRelacionesDominante = new Button();
            txtSeguidora = new TextBox();
            label2 = new Label();
            txtDominante = new TextBox();
            label1 = new Label();
            btnDesvincular = new Button();
            btnVincular = new Button();
            dgvListaSeguidor = new DataGridView();
            lblMensajes = new Label();
            dgvListaDominante = new DataGridView();
            txtNota = new TextBox();
            label5 = new Label();
            cbTipo = new ComboBox();
            rbsTrimestre1 = new RadioButton();
            label4 = new Label();
            rbsTrimestre3 = new RadioButton();
            rbsTrimestre2 = new RadioButton();
            pictureBox2 = new PictureBox();
            gbTrimestre = new GroupBox();
            dgvListaRelaciones = new DataGridView();
            txtRelacion = new TextBox();
            label7 = new Label();
            btnBorrarRelacional = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaSeguidor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaDominante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbTrimestre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaRelaciones).BeginInit();
            SuspendLayout();
            // 
            // btnBorrarSeguidora
            // 
            btnBorrarSeguidora.BackColor = Color.Red;
            btnBorrarSeguidora.FlatStyle = FlatStyle.Flat;
            btnBorrarSeguidora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarSeguidora.ForeColor = Color.White;
            btnBorrarSeguidora.Location = new Point(774, 58);
            btnBorrarSeguidora.Name = "btnBorrarSeguidora";
            btnBorrarSeguidora.Size = new Size(23, 23);
            btnBorrarSeguidora.TabIndex = 184;
            btnBorrarSeguidora.Tag = "Seguidora";
            btnBorrarSeguidora.Text = "X";
            btnBorrarSeguidora.UseVisualStyleBackColor = false;
            // 
            // btnBorrarDominante
            // 
            btnBorrarDominante.BackColor = Color.Red;
            btnBorrarDominante.FlatStyle = FlatStyle.Flat;
            btnBorrarDominante.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarDominante.ForeColor = Color.White;
            btnBorrarDominante.Location = new Point(639, 59);
            btnBorrarDominante.Name = "btnBorrarDominante";
            btnBorrarDominante.Size = new Size(23, 23);
            btnBorrarDominante.TabIndex = 183;
            btnBorrarDominante.Tag = "Dominante";
            btnBorrarDominante.Text = "X";
            btnBorrarDominante.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(685, 69);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 182;
            label3.Text = "Relaciones";
            // 
            // btnBorrarLog
            // 
            btnBorrarLog.FlatStyle = FlatStyle.Flat;
            btnBorrarLog.Location = new Point(1369, 48);
            btnBorrarLog.Name = "btnBorrarLog";
            btnBorrarLog.Size = new Size(55, 33);
            btnBorrarLog.TabIndex = 181;
            btnBorrarLog.Text = "Borrar";
            btnBorrarLog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(1308, 30);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 180;
            label8.Text = "Log de calificaciones";
            // 
            // btnAbrirLog
            // 
            btnAbrirLog.FlatStyle = FlatStyle.Flat;
            btnAbrirLog.Location = new Point(1308, 48);
            btnAbrirLog.Name = "btnAbrirLog";
            btnAbrirLog.Size = new Size(55, 33);
            btnAbrirLog.TabIndex = 179;
            btnAbrirLog.Text = "Abrir";
            btnAbrirLog.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarSeguidora
            // 
            btnRefrescarSeguidora.FlatStyle = FlatStyle.Flat;
            btnRefrescarSeguidora.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescarSeguidora.Location = new Point(957, 48);
            btnRefrescarSeguidora.Margin = new Padding(3, 2, 3, 2);
            btnRefrescarSeguidora.Name = "btnRefrescarSeguidora";
            btnRefrescarSeguidora.Size = new Size(82, 33);
            btnRefrescarSeguidora.TabIndex = 178;
            btnRefrescarSeguidora.Tag = "Seguidora";
            btnRefrescarSeguidora.Text = "Refrescar";
            btnRefrescarSeguidora.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarDominante
            // 
            btnRefrescarDominante.FlatStyle = FlatStyle.Flat;
            btnRefrescarDominante.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescarDominante.Location = new Point(397, 49);
            btnRefrescarDominante.Margin = new Padding(3, 2, 3, 2);
            btnRefrescarDominante.Name = "btnRefrescarDominante";
            btnRefrescarDominante.Size = new Size(82, 33);
            btnRefrescarDominante.TabIndex = 177;
            btnRefrescarDominante.Tag = "Dominante";
            btnRefrescarDominante.Text = "Refrescar";
            btnRefrescarDominante.UseVisualStyleBackColor = true;
            // 
            // btnRelacionesSeguidora
            // 
            btnRelacionesSeguidora.FlatStyle = FlatStyle.Flat;
            btnRelacionesSeguidora.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnRelacionesSeguidora.Location = new Point(668, 86);
            btnRelacionesSeguidora.Margin = new Padding(3, 2, 3, 2);
            btnRelacionesSeguidora.Name = "btnRelacionesSeguidora";
            btnRelacionesSeguidora.Size = new Size(48, 48);
            btnRelacionesSeguidora.TabIndex = 176;
            btnRelacionesSeguidora.Tag = "Seguidora";
            btnRelacionesSeguidora.Text = "<<";
            btnRelacionesSeguidora.UseVisualStyleBackColor = true;
            // 
            // btnRelacionesDominante
            // 
            btnRelacionesDominante.FlatStyle = FlatStyle.Flat;
            btnRelacionesDominante.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnRelacionesDominante.Location = new Point(720, 86);
            btnRelacionesDominante.Margin = new Padding(3, 2, 3, 2);
            btnRelacionesDominante.Name = "btnRelacionesDominante";
            btnRelacionesDominante.Size = new Size(48, 48);
            btnRelacionesDominante.TabIndex = 175;
            btnRelacionesDominante.Tag = "Dominante";
            btnRelacionesDominante.Text = ">>";
            btnRelacionesDominante.UseVisualStyleBackColor = true;
            // 
            // txtSeguidora
            // 
            txtSeguidora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSeguidora.Location = new Point(803, 58);
            txtSeguidora.Margin = new Padding(3, 2, 3, 2);
            txtSeguidora.Name = "txtSeguidora";
            txtSeguidora.Size = new Size(148, 23);
            txtSeguidora.TabIndex = 174;
            txtSeguidora.Tag = "Seguidora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(861, 41);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 173;
            label2.Text = "Código módulo";
            // 
            // txtDominante
            // 
            txtDominante.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDominante.Location = new Point(485, 59);
            txtDominante.Margin = new Padding(3, 2, 3, 2);
            txtDominante.Name = "txtDominante";
            txtDominante.Size = new Size(148, 23);
            txtDominante.TabIndex = 172;
            txtDominante.Tag = "Dominante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(485, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 171;
            label1.Text = "DNI alumno";
            // 
            // btnDesvincular
            // 
            btnDesvincular.FlatStyle = FlatStyle.Flat;
            btnDesvincular.Font = new Font("Segoe UI", 9F);
            btnDesvincular.Location = new Point(668, 175);
            btnDesvincular.Margin = new Padding(3, 2, 3, 2);
            btnDesvincular.Name = "btnDesvincular";
            btnDesvincular.Size = new Size(100, 33);
            btnDesvincular.TabIndex = 170;
            btnDesvincular.Text = "Desvincular";
            btnDesvincular.UseVisualStyleBackColor = true;
            // 
            // btnVincular
            // 
            btnVincular.FlatStyle = FlatStyle.Flat;
            btnVincular.Font = new Font("Segoe UI", 9F);
            btnVincular.Location = new Point(668, 138);
            btnVincular.Margin = new Padding(3, 2, 3, 2);
            btnVincular.Name = "btnVincular";
            btnVincular.Size = new Size(100, 33);
            btnVincular.TabIndex = 169;
            btnVincular.Text = "Vincular";
            btnVincular.UseVisualStyleBackColor = true;
            // 
            // dgvListaSeguidor
            // 
            dgvListaSeguidor.AllowUserToResizeColumns = false;
            dgvListaSeguidor.AllowUserToResizeRows = false;
            dgvListaSeguidor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListaSeguidor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListaSeguidor.ColumnHeadersHeight = 29;
            dgvListaSeguidor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaSeguidor.Location = new Point(774, 86);
            dgvListaSeguidor.Margin = new Padding(3, 2, 3, 2);
            dgvListaSeguidor.MultiSelect = false;
            dgvListaSeguidor.Name = "dgvListaSeguidor";
            dgvListaSeguidor.ReadOnly = true;
            dgvListaSeguidor.RowHeadersVisible = false;
            dgvListaSeguidor.RowHeadersWidth = 51;
            dgvListaSeguidor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListaSeguidor.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvListaSeguidor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaSeguidor.Size = new Size(650, 366);
            dgvListaSeguidor.TabIndex = 167;
            dgvListaSeguidor.Tag = "Seguidora";
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMensajes.Location = new Point(259, 12);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(125, 21);
            lblMensajes.TabIndex = 166;
            lblMensajes.Text = "Estado proceso";
            // 
            // dgvListaDominante
            // 
            dgvListaDominante.AllowUserToResizeColumns = false;
            dgvListaDominante.AllowUserToResizeRows = false;
            dgvListaDominante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvListaDominante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvListaDominante.ColumnHeadersHeight = 29;
            dgvListaDominante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaDominante.Location = new Point(12, 86);
            dgvListaDominante.Margin = new Padding(3, 2, 3, 2);
            dgvListaDominante.MultiSelect = false;
            dgvListaDominante.Name = "dgvListaDominante";
            dgvListaDominante.ReadOnly = true;
            dgvListaDominante.RowHeadersVisible = false;
            dgvListaDominante.RowHeadersWidth = 51;
            dgvListaDominante.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListaDominante.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvListaDominante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaDominante.Size = new Size(650, 366);
            dgvListaDominante.TabIndex = 165;
            dgvListaDominante.Tag = "Dominante";
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNota.Location = new Point(708, 212);
            txtNota.Margin = new Padding(3, 2, 3, 2);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(60, 23);
            txtNota.TabIndex = 190;
            txtNota.Tag = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(668, 215);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 189;
            label5.Text = "Nota:";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Práctica", "Examen" });
            cbTipo.Location = new Point(668, 255);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(100, 23);
            cbTipo.TabIndex = 191;
            // 
            // rbsTrimestre1
            // 
            rbsTrimestre1.AutoSize = true;
            rbsTrimestre1.Checked = true;
            rbsTrimestre1.Location = new Point(6, 22);
            rbsTrimestre1.Name = "rbsTrimestre1";
            rbsTrimestre1.Size = new Size(32, 19);
            rbsTrimestre1.TabIndex = 192;
            rbsTrimestre1.TabStop = true;
            rbsTrimestre1.Text = "1";
            rbsTrimestre1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(668, 237);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 193;
            label4.Text = "Tipo elemento";
            // 
            // rbsTrimestre3
            // 
            rbsTrimestre3.AutoSize = true;
            rbsTrimestre3.Location = new Point(6, 72);
            rbsTrimestre3.Name = "rbsTrimestre3";
            rbsTrimestre3.Size = new Size(32, 19);
            rbsTrimestre3.TabIndex = 195;
            rbsTrimestre3.TabStop = true;
            rbsTrimestre3.Text = "3";
            rbsTrimestre3.UseVisualStyleBackColor = true;
            // 
            // rbsTrimestre2
            // 
            rbsTrimestre2.AutoSize = true;
            rbsTrimestre2.Location = new Point(6, 47);
            rbsTrimestre2.Name = "rbsTrimestre2";
            rbsTrimestre2.Size = new Size(32, 19);
            rbsTrimestre2.TabIndex = 196;
            rbsTrimestre2.TabStop = true;
            rbsTrimestre2.Text = "2";
            rbsTrimestre2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 197;
            pictureBox2.TabStop = false;
            // 
            // gbTrimestre
            // 
            gbTrimestre.Controls.Add(rbsTrimestre1);
            gbTrimestre.Controls.Add(rbsTrimestre3);
            gbTrimestre.Controls.Add(rbsTrimestre2);
            gbTrimestre.Location = new Point(668, 284);
            gbTrimestre.Name = "gbTrimestre";
            gbTrimestre.Size = new Size(100, 101);
            gbTrimestre.TabIndex = 198;
            gbTrimestre.TabStop = false;
            gbTrimestre.Text = "Trimestres";
            // 
            // dgvListaRelaciones
            // 
            dgvListaRelaciones.AllowUserToResizeColumns = false;
            dgvListaRelaciones.AllowUserToResizeRows = false;
            dgvListaRelaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvListaRelaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvListaRelaciones.ColumnHeadersHeight = 29;
            dgvListaRelaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaRelaciones.Location = new Point(12, 456);
            dgvListaRelaciones.Margin = new Padding(3, 2, 3, 2);
            dgvListaRelaciones.MultiSelect = false;
            dgvListaRelaciones.Name = "dgvListaRelaciones";
            dgvListaRelaciones.ReadOnly = true;
            dgvListaRelaciones.RowHeadersVisible = false;
            dgvListaRelaciones.RowHeadersWidth = 51;
            dgvListaRelaciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListaRelaciones.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvListaRelaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaRelaciones.Size = new Size(1412, 200);
            dgvListaRelaciones.TabIndex = 202;
            dgvListaRelaciones.Tag = "Relacional";
            // 
            // txtRelacion
            // 
            txtRelacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtRelacion.Location = new Point(668, 429);
            txtRelacion.Margin = new Padding(3, 2, 3, 2);
            txtRelacion.Name = "txtRelacion";
            txtRelacion.Size = new Size(71, 23);
            txtRelacion.TabIndex = 204;
            txtRelacion.Tag = "Relacional";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(668, 412);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 203;
            label7.Text = "ID:";
            // 
            // btnBorrarRelacional
            // 
            btnBorrarRelacional.BackColor = Color.Red;
            btnBorrarRelacional.FlatStyle = FlatStyle.Flat;
            btnBorrarRelacional.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarRelacional.ForeColor = Color.White;
            btnBorrarRelacional.Location = new Point(745, 429);
            btnBorrarRelacional.Name = "btnBorrarRelacional";
            btnBorrarRelacional.Size = new Size(23, 23);
            btnBorrarRelacional.TabIndex = 205;
            btnBorrarRelacional.Tag = "Relacional";
            btnBorrarRelacional.Text = "X";
            btnBorrarRelacional.UseVisualStyleBackColor = false;
            // 
            // FrmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 666);
            Controls.Add(btnBorrarRelacional);
            Controls.Add(txtRelacion);
            Controls.Add(label7);
            Controls.Add(dgvListaRelaciones);
            Controls.Add(gbTrimestre);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(cbTipo);
            Controls.Add(txtNota);
            Controls.Add(label5);
            Controls.Add(btnBorrarSeguidora);
            Controls.Add(btnBorrarDominante);
            Controls.Add(label3);
            Controls.Add(btnBorrarLog);
            Controls.Add(label8);
            Controls.Add(btnAbrirLog);
            Controls.Add(btnRefrescarSeguidora);
            Controls.Add(btnRefrescarDominante);
            Controls.Add(btnRelacionesSeguidora);
            Controls.Add(btnRelacionesDominante);
            Controls.Add(txtSeguidora);
            Controls.Add(label2);
            Controls.Add(txtDominante);
            Controls.Add(label1);
            Controls.Add(btnDesvincular);
            Controls.Add(btnVincular);
            Controls.Add(dgvListaSeguidor);
            Controls.Add(lblMensajes);
            Controls.Add(dgvListaDominante);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmCalificaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)dgvListaSeguidor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaDominante).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbTrimestre.ResumeLayout(false);
            gbTrimestre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaRelaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrarSeguidora;
        private Button btnBorrarDominante;
        private Label label3;
        private Button btnBorrarLog;
        private Label label8;
        private Button btnAbrirLog;
        private Button btnRefrescarSeguidora;
        private Button btnRefrescarDominante;
        private Button btnRelacionesSeguidora;
        private Button btnRelacionesDominante;
        private TextBox txtSeguidora;
        private Label label2;
        private TextBox txtDominante;
        private Label label1;
        private Button btnDesvincular;
        private Button btnVincular;
        private DataGridView dgvListaSeguidor;
        private Label lblMensajes;
        private DataGridView dgvListaDominante;
        private TextBox txtNota;
        private Label label5;
        private ComboBox cbTipo;
        private RadioButton rbsTrimestre1;
        private Label label4;
        private RadioButton rbsTrimestre3;
        private RadioButton rbsTrimestre2;
        private PictureBox pictureBox2;
        private GroupBox gbTrimestre;
        private DataGridView dgvListaRelaciones;
        private TextBox txtRelacion;
        private Label label7;
        private Button btnBorrarRelacional;
    }
}