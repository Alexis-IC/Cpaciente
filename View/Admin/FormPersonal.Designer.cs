﻿namespace cPaciente.View.Admin
{
    partial class FormPersonal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lbFiltroNombre = new System.Windows.Forms.Label();
            this.lbFiltroRol = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.lbHasta = new System.Windows.Forms.Label();
            this.tlPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.tlFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.dgPersonal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlPersonal.SuspendLayout();
            this.tlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 116);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Personal";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBuscar.Location = new System.Drawing.Point(3, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(244, 20);
            this.tbBuscar.TabIndex = 17;
            // 
            // cbRol
            // 
            this.cbRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(253, 3);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(219, 21);
            this.cbRol.TabIndex = 18;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(478, 3);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(114, 20);
            this.dtpInicio.TabIndex = 19;
            // 
            // dtpFin
            // 
            this.dtpFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(598, 3);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(129, 20);
            this.dtpFin.TabIndex = 20;
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
            // lbFiltroRol
            // 
            this.lbFiltroRol.AutoSize = true;
            this.lbFiltroRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFiltroRol.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFiltroRol.Location = new System.Drawing.Point(253, 25);
            this.lbFiltroRol.Name = "lbFiltroRol";
            this.lbFiltroRol.Size = new System.Drawing.Size(219, 13);
            this.lbFiltroRol.TabIndex = 22;
            this.lbFiltroRol.Text = "Filtrar por rol";
            this.lbFiltroRol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInicio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbInicio.Location = new System.Drawing.Point(478, 25);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(114, 13);
            this.lbInicio.TabIndex = 23;
            this.lbInicio.Text = "Desde";
            this.lbInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHasta
            // 
            this.lbHasta.AutoSize = true;
            this.lbHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHasta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbHasta.Location = new System.Drawing.Point(598, 25);
            this.lbHasta.Name = "lbHasta";
            this.lbHasta.Size = new System.Drawing.Size(129, 13);
            this.lbHasta.TabIndex = 24;
            this.lbHasta.Text = "Hasta";
            this.lbHasta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.tlPersonal.TabIndex = 1;
            // 
            // tlFiltro
            // 
            this.tlFiltro.ColumnCount = 4;
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlFiltro.Controls.Add(this.lbFiltroNombre, 0, 1);
            this.tlFiltro.Controls.Add(this.lbFiltroRol, 1, 1);
            this.tlFiltro.Controls.Add(this.lbInicio, 2, 1);
            this.tlFiltro.Controls.Add(this.lbHasta, 3, 1);
            this.tlFiltro.Controls.Add(this.tbBuscar, 0, 0);
            this.tlFiltro.Controls.Add(this.cbRol, 1, 0);
            this.tlFiltro.Controls.Add(this.dtpInicio, 2, 0);
            this.tlFiltro.Controls.Add(this.dtpFin, 3, 0);
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
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.tlPersonal);
            this.Name = "FormPersonal";
            this.Text = "FormPersonal";
            this.tlPersonal.ResumeLayout(false);
            this.tlFiltro.ResumeLayout(false);
            this.tlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lbHasta;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label lbFiltroRol;
        private System.Windows.Forms.Label lbFiltroNombre;
        private System.Windows.Forms.TableLayoutPanel tlPersonal;
        private System.Windows.Forms.DataGridView dgPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TableLayoutPanel tlFiltro;
    }
}