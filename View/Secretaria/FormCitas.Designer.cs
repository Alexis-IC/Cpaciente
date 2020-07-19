namespace cPaciente.View.Secretaria
{
    partial class FormCitas
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
            this.tlPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.tlFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.lbFiltroNombre = new System.Windows.Forms.Label();
            this.lbFiltroRol = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.lbHasta = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lbEspecialidad = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dgPersonal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tlPersonal.SuspendLayout();
            this.tlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // tlPersonal
            // 
            this.tlPersonal.ColumnCount = 1;
            this.tlPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPersonal.Controls.Add(this.tlFiltro, 0, 1);
            this.tlPersonal.Controls.Add(this.dgPersonal, 0, 3);
            this.tlPersonal.Controls.Add(this.btnAgregar, 0, 2);
            this.tlPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersonal.Location = new System.Drawing.Point(0, 0);
            this.tlPersonal.Name = "tlPersonal";
            this.tlPersonal.RowCount = 5;
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.794008F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.26519F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.90052F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.040285F));
            this.tlPersonal.Size = new System.Drawing.Size(736, 511);
            this.tlPersonal.TabIndex = 2;
            this.tlPersonal.Paint += new System.Windows.Forms.PaintEventHandler(this.tlPersonal_Paint);
            // 
            // tlFiltro
            // 
            this.tlFiltro.ColumnCount = 5;
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlFiltro.Controls.Add(this.lbFiltroNombre, 0, 1);
            this.tlFiltro.Controls.Add(this.lbFiltroRol, 1, 1);
            this.tlFiltro.Controls.Add(this.lbInicio, 3, 1);
            this.tlFiltro.Controls.Add(this.lbHasta, 4, 1);
            this.tlFiltro.Controls.Add(this.dtpInicio, 0, 0);
            this.tlFiltro.Controls.Add(this.dtpFin, 1, 0);
            this.tlFiltro.Controls.Add(this.cbEspecialidad, 2, 0);
            this.tlFiltro.Controls.Add(this.lbEspecialidad, 2, 1);
            this.tlFiltro.Controls.Add(this.numericUpDown1, 3, 0);
            this.tlFiltro.Controls.Add(this.numericUpDown2, 4, 0);
            this.tlFiltro.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlFiltro.Location = new System.Drawing.Point(3, 49);
            this.tlFiltro.Name = "tlFiltro";
            this.tlFiltro.RowCount = 3;
            this.tlFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlFiltro.Size = new System.Drawing.Size(730, 61);
            this.tlFiltro.TabIndex = 5;
            // 
            // lbFiltroNombre
            // 
            this.lbFiltroNombre.AutoSize = true;
            this.lbFiltroNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFiltroNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFiltroNombre.Location = new System.Drawing.Point(3, 25);
            this.lbFiltroNombre.Name = "lbFiltroNombre";
            this.lbFiltroNombre.Size = new System.Drawing.Size(207, 13);
            this.lbFiltroNombre.TabIndex = 21;
            this.lbFiltroNombre.Text = "Desde";
            this.lbFiltroNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFiltroRol
            // 
            this.lbFiltroRol.AutoSize = true;
            this.lbFiltroRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFiltroRol.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFiltroRol.Location = new System.Drawing.Point(216, 25);
            this.lbFiltroRol.Name = "lbFiltroRol";
            this.lbFiltroRol.Size = new System.Drawing.Size(207, 13);
            this.lbFiltroRol.TabIndex = 22;
            this.lbFiltroRol.Text = "Hasta";
            this.lbFiltroRol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInicio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbInicio.Location = new System.Drawing.Point(585, 25);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(60, 13);
            this.lbInicio.TabIndex = 23;
            this.lbInicio.Text = "Hora min";
            this.lbInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHasta
            // 
            this.lbHasta.AutoSize = true;
            this.lbHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHasta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbHasta.Location = new System.Drawing.Point(651, 25);
            this.lbHasta.Name = "lbHasta";
            this.lbHasta.Size = new System.Drawing.Size(76, 13);
            this.lbHasta.TabIndex = 24;
            this.lbHasta.Text = "Hora max";
            this.lbHasta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInicio.Location = new System.Drawing.Point(3, 3);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(207, 20);
            this.dtpInicio.TabIndex = 19;
            // 
            // dtpFin
            // 
            this.dtpFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFin.Location = new System.Drawing.Point(216, 3);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(207, 20);
            this.dtpFin.TabIndex = 20;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Pendiente",
            "Realizada"});
            this.cbEspecialidad.Location = new System.Drawing.Point(429, 3);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(150, 21);
            this.cbEspecialidad.TabIndex = 25;
            // 
            // lbEspecialidad
            // 
            this.lbEspecialidad.AutoSize = true;
            this.lbEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEspecialidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbEspecialidad.Location = new System.Drawing.Point(429, 25);
            this.lbEspecialidad.Name = "lbEspecialidad";
            this.lbEspecialidad.Size = new System.Drawing.Size(150, 13);
            this.lbEspecialidad.TabIndex = 26;
            this.lbEspecialidad.Text = "Estado de la cita";
            this.lbEspecialidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(585, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 27;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Location = new System.Drawing.Point(651, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown2.TabIndex = 28;
            // 
            // dgPersonal
            // 
            this.dgPersonal.AllowUserToAddRows = false;
            this.dgPersonal.AllowUserToDeleteRows = false;
            this.dgPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPersonal.Location = new System.Drawing.Point(3, 156);
            this.dgPersonal.Name = "dgPersonal";
            this.dgPersonal.ReadOnly = true;
            this.dgPersonal.Size = new System.Drawing.Size(730, 346);
            this.dgPersonal.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estado";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Paciente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Hora";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Secretaria";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 116);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Nueva cita";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.tlPersonal);
            this.Name = "FormCitas";
            this.Text = "FormCitas";
            this.Load += new System.EventHandler(this.FormCitas_Load);
            this.tlPersonal.ResumeLayout(false);
            this.tlFiltro.ResumeLayout(false);
            this.tlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPersonal;
        private System.Windows.Forms.TableLayoutPanel tlFiltro;
        private System.Windows.Forms.Label lbFiltroNombre;
        private System.Windows.Forms.Label lbFiltroRol;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label lbHasta;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lbEspecialidad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridView dgPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnAgregar;
    }
}