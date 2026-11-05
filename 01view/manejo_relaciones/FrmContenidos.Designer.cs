namespace EduGrade._01view.manejo_relaciones
{
    partial class FrmContenidos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContenidos));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvListaDominante = new DataGridView();
            dgvListaSeguidor = new DataGridView();
            btnDesvincular = new Button();
            btnVincular = new Button();
            label1 = new Label();
            txtDominante = new TextBox();
            txtSeguidora = new TextBox();
            label2 = new Label();
            btnRelacionesDominante = new Button();
            btnRelacionesSeguidora = new Button();
            btnRefrescarDominante = new Button();
            btnRefrescarSeguidora = new Button();
            btnBorrarLog = new Button();
            label8 = new Label();
            btnAbrirLog = new Button();
            label3 = new Label();
            btnBorrarDominante = new Button();
            btnBorrarSeguidora = new Button();
            pictureBox2 = new PictureBox();
            lblMensajes = new Label();
            dgvListaRelaciones = new DataGridView();
            btnBorrarRelacional = new Button();
            txtRelacion = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaDominante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaSeguidor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaRelaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvListaDominante
            // 
            dgvListaDominante.AllowUserToResizeColumns = false;
            dgvListaDominante.AllowUserToResizeRows = false;
            dgvListaDominante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaDominante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dgvListaDominante.TabIndex = 63;
            dgvListaDominante.Tag = "Dominante";
            // 
            // dgvListaSeguidor
            // 
            dgvListaSeguidor.AllowUserToResizeColumns = false;
            dgvListaSeguidor.AllowUserToResizeRows = false;
            dgvListaSeguidor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaSeguidor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dgvListaSeguidor.TabIndex = 65;
            dgvListaSeguidor.Tag = "Seguidora";
            // 
            // btnDesvincular
            // 
            btnDesvincular.FlatStyle = FlatStyle.Flat;
            btnDesvincular.Location = new Point(668, 175);
            btnDesvincular.Margin = new Padding(3, 2, 3, 2);
            btnDesvincular.Name = "btnDesvincular";
            btnDesvincular.Size = new Size(100, 33);
            btnDesvincular.TabIndex = 145;
            btnDesvincular.Text = "Desvincular";
            btnDesvincular.UseVisualStyleBackColor = true;
            // 
            // btnVincular
            // 
            btnVincular.FlatStyle = FlatStyle.Flat;
            btnVincular.Location = new Point(668, 138);
            btnVincular.Margin = new Padding(3, 2, 3, 2);
            btnVincular.Name = "btnVincular";
            btnVincular.Size = new Size(100, 33);
            btnVincular.TabIndex = 144;
            btnVincular.Text = "Vincular";
            btnVincular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(485, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 146;
            label1.Text = "Código curso";
            // 
            // txtDominante
            // 
            txtDominante.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDominante.Location = new Point(485, 59);
            txtDominante.Margin = new Padding(3, 2, 3, 2);
            txtDominante.Name = "txtDominante";
            txtDominante.Size = new Size(148, 23);
            txtDominante.TabIndex = 147;
            txtDominante.Tag = "Dominante";
            // 
            // txtSeguidora
            // 
            txtSeguidora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSeguidora.Location = new Point(803, 58);
            txtSeguidora.Margin = new Padding(3, 2, 3, 2);
            txtSeguidora.Name = "txtSeguidora";
            txtSeguidora.Size = new Size(148, 23);
            txtSeguidora.TabIndex = 149;
            txtSeguidora.Tag = "Seguidora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(861, 41);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 148;
            label2.Text = "Código módulo";
            // 
            // btnRelacionesDominante
            // 
            btnRelacionesDominante.FlatStyle = FlatStyle.Flat;
            btnRelacionesDominante.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnRelacionesDominante.Location = new Point(720, 86);
            btnRelacionesDominante.Margin = new Padding(3, 2, 3, 2);
            btnRelacionesDominante.Name = "btnRelacionesDominante";
            btnRelacionesDominante.Size = new Size(48, 48);
            btnRelacionesDominante.TabIndex = 152;
            btnRelacionesDominante.Tag = "Dominante";
            btnRelacionesDominante.Text = ">>";
            btnRelacionesDominante.UseVisualStyleBackColor = true;
            // 
            // btnRelacionesSeguidora
            // 
            btnRelacionesSeguidora.FlatStyle = FlatStyle.Flat;
            btnRelacionesSeguidora.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnRelacionesSeguidora.Location = new Point(668, 86);
            btnRelacionesSeguidora.Margin = new Padding(3, 2, 3, 2);
            btnRelacionesSeguidora.Name = "btnRelacionesSeguidora";
            btnRelacionesSeguidora.Size = new Size(48, 48);
            btnRelacionesSeguidora.TabIndex = 153;
            btnRelacionesSeguidora.Tag = "Seguidora";
            btnRelacionesSeguidora.Text = "<<";
            btnRelacionesSeguidora.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarDominante
            // 
            btnRefrescarDominante.FlatStyle = FlatStyle.Flat;
            btnRefrescarDominante.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescarDominante.Location = new Point(397, 49);
            btnRefrescarDominante.Margin = new Padding(3, 2, 3, 2);
            btnRefrescarDominante.Name = "btnRefrescarDominante";
            btnRefrescarDominante.Size = new Size(82, 33);
            btnRefrescarDominante.TabIndex = 155;
            btnRefrescarDominante.Tag = "Dominante";
            btnRefrescarDominante.Text = "Refrescar";
            btnRefrescarDominante.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarSeguidora
            // 
            btnRefrescarSeguidora.FlatStyle = FlatStyle.Flat;
            btnRefrescarSeguidora.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescarSeguidora.Location = new Point(957, 48);
            btnRefrescarSeguidora.Margin = new Padding(3, 2, 3, 2);
            btnRefrescarSeguidora.Name = "btnRefrescarSeguidora";
            btnRefrescarSeguidora.Size = new Size(82, 33);
            btnRefrescarSeguidora.TabIndex = 156;
            btnRefrescarSeguidora.Tag = "Seguidora";
            btnRefrescarSeguidora.Text = "Refrescar";
            btnRefrescarSeguidora.UseVisualStyleBackColor = true;
            // 
            // btnBorrarLog
            // 
            btnBorrarLog.FlatStyle = FlatStyle.Flat;
            btnBorrarLog.Location = new Point(1369, 48);
            btnBorrarLog.Name = "btnBorrarLog";
            btnBorrarLog.Size = new Size(55, 33);
            btnBorrarLog.TabIndex = 159;
            btnBorrarLog.Text = "Borrar";
            btnBorrarLog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(1308, 30);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 158;
            label8.Text = "Log de contenidos";
            // 
            // btnAbrirLog
            // 
            btnAbrirLog.FlatStyle = FlatStyle.Flat;
            btnAbrirLog.Location = new Point(1308, 48);
            btnAbrirLog.Name = "btnAbrirLog";
            btnAbrirLog.Size = new Size(55, 33);
            btnAbrirLog.TabIndex = 157;
            btnAbrirLog.Text = "Abrir";
            btnAbrirLog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(685, 69);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 160;
            label3.Text = "Relaciones";
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
            btnBorrarDominante.TabIndex = 162;
            btnBorrarDominante.Tag = "Dominante";
            btnBorrarDominante.Text = "X";
            btnBorrarDominante.UseVisualStyleBackColor = false;
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
            btnBorrarSeguidora.TabIndex = 164;
            btnBorrarSeguidora.Tag = "Seguidora";
            btnBorrarSeguidora.Text = "X";
            btnBorrarSeguidora.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 191;
            pictureBox2.TabStop = false;
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMensajes.Location = new Point(259, 12);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(125, 21);
            lblMensajes.TabIndex = 190;
            lblMensajes.Text = "Estado proceso";
            // 
            // dgvListaRelaciones
            // 
            dgvListaRelaciones.AllowUserToResizeColumns = false;
            dgvListaRelaciones.AllowUserToResizeRows = false;
            dgvListaRelaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListaRelaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dgvListaRelaciones.TabIndex = 203;
            dgvListaRelaciones.Tag = "Relacional";
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
            btnBorrarRelacional.TabIndex = 208;
            btnBorrarRelacional.Tag = "Relacional";
            btnBorrarRelacional.Text = "X";
            btnBorrarRelacional.UseVisualStyleBackColor = false;
            // 
            // txtRelacion
            // 
            txtRelacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtRelacion.Location = new Point(668, 429);
            txtRelacion.Margin = new Padding(3, 2, 3, 2);
            txtRelacion.Name = "txtRelacion";
            txtRelacion.Size = new Size(71, 23);
            txtRelacion.TabIndex = 207;
            txtRelacion.Tag = "Relacional";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(668, 412);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 206;
            label7.Text = "ID:";
            // 
            // FrmContenidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 666);
            Controls.Add(btnBorrarRelacional);
            Controls.Add(txtRelacion);
            Controls.Add(label7);
            Controls.Add(dgvListaRelaciones);
            Controls.Add(pictureBox2);
            Controls.Add(lblMensajes);
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
            Controls.Add(dgvListaDominante);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmContenidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contenidos";
            ((System.ComponentModel.ISupportInitialize)dgvListaDominante).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaSeguidor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaRelaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvListaDominante;
        private DataGridView dgvListaSeguidor;
        private Button btnDesvincular;
        private Button btnVincular;
        private Label label1;
        private TextBox txtDominante;
        private TextBox txtSeguidora;
        private Label label2;
        private Button btnRelacionesDominante;
        private Button btnRelacionesSeguidora;
        private Button btnRefrescarDominante;
        private Button btnRefrescarSeguidora;
        private Button btnBorrarLog;
        private Label label8;
        private Button btnAbrirLog;
        private Label label3;
        private Button btnBorrarDominante;
        private Button btnBorrarSeguidora;
        private PictureBox pictureBox2;
        private Label lblMensajes;
        private DataGridView dgvListaRelaciones;
        private Button btnBorrarRelacional;
        private TextBox txtRelacion;
        private Label label7;
    }
}