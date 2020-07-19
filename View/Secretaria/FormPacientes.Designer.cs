namespace cPaciente.View.Secretaria
{
    partial class FormPacientes
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
            this.dgPersonal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.tlPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.tlFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.lbFiltroNombre = new System.Windows.Forms.Label();
            this.lbFiltroGenero = new System.Windows.Forms.Label();
            this.cbGnero = new System.Windows.Forms.ComboBox();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).BeginInit();
            this.tlPersonal.SuspendLayout();
            this.tlFiltro.SuspendLayout();
            this.SuspendLayout();
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
            this.Column5});
            this.dgPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPersonal.Location = new System.Drawing.Point(3, 156);
            this.dgPersonal.Name = "dgPersonal";
            this.dgPersonal.ReadOnly = true;
            this.dgPersonal.Size = new System.Drawing.Size(730, 346);
            this.dgPersonal.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Foto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
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
            this.Column4.HeaderText = "Correo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Opciones";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBuscar.Location = new System.Drawing.Point(3, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(244, 20);
            this.tbBuscar.TabIndex = 17;
            // 
            // tlPersonal
            // 
            this.tlPersonal.ColumnCount = 1;
            this.tlPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPersonal.Controls.Add(this.tlFiltro, 0, 1);
            this.tlPersonal.Controls.Add(this.dgPersonal, 0, 3);
            this.tlPersonal.Controls.Add(this.btnAgregarPaciente, 0, 2);
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
            // 
            // tlFiltro
            // 
            this.tlFiltro.ColumnCount = 4;
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlFiltro.Controls.Add(this.lbFiltroNombre, 0, 1);
            this.tlFiltro.Controls.Add(this.lbFiltroGenero, 1, 1);
            this.tlFiltro.Controls.Add(this.tbBuscar, 0, 0);
            this.tlFiltro.Controls.Add(this.cbGnero, 1, 0);
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
            this.lbFiltroNombre.Size = new System.Drawing.Size(244, 13);
            this.lbFiltroNombre.TabIndex = 21;
            this.lbFiltroNombre.Text = "Filtrar por nombre";
            this.lbFiltroNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFiltroGenero
            // 
            this.lbFiltroGenero.AutoSize = true;
            this.lbFiltroGenero.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFiltroGenero.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFiltroGenero.Location = new System.Drawing.Point(253, 25);
            this.lbFiltroGenero.Name = "lbFiltroGenero";
            this.lbFiltroGenero.Size = new System.Drawing.Size(219, 13);
            this.lbFiltroGenero.TabIndex = 22;
            this.lbFiltroGenero.Text = "Filtrar por genero";
            this.lbFiltroGenero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbGnero
            // 
            this.cbGnero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGnero.FormattingEnabled = true;
            this.cbGnero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbGnero.Location = new System.Drawing.Point(253, 3);
            this.cbGnero.Name = "cbGnero";
            this.cbGnero.Size = new System.Drawing.Size(219, 21);
            this.cbGnero.TabIndex = 18;
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.Location = new System.Drawing.Point(3, 116);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(119, 34);
            this.btnAgregarPaciente.TabIndex = 0;
            this.btnAgregarPaciente.Text = "Agregar Paciente";
            this.btnAgregarPaciente.UseVisualStyleBackColor = true;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.tlPersonal);
            this.Name = "FormPacientes";
            this.Text = "FormPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).EndInit();
            this.tlPersonal.ResumeLayout(false);
            this.tlFiltro.ResumeLayout(false);
            this.tlFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.TableLayoutPanel tlPersonal;
        private System.Windows.Forms.TableLayoutPanel tlFiltro;
        private System.Windows.Forms.Label lbFiltroNombre;
        private System.Windows.Forms.Label lbFiltroGenero;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.ComboBox cbGnero;
    }
}