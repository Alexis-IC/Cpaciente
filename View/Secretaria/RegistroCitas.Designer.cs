namespace cPaciente.View.Secretaria
{
    partial class RegistroCitas
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
            this.lblEtiNombre = new System.Windows.Forms.Label();
            this.tbNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblEtiEspecialidad = new System.Windows.Forms.Label();
            this.cboElegirEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbelegirMedico = new System.Windows.Forms.ComboBox();
            this.lblEtiMeidoc = new System.Windows.Forms.Label();
            this.lblEtiFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEtiHora = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblAgregarNuevoPaciente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiNombre
            // 
            this.lblEtiNombre.AutoSize = true;
            this.lblEtiNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiNombre.Location = new System.Drawing.Point(143, 96);
            this.lblEtiNombre.Name = "lblEtiNombre";
            this.lblEtiNombre.Size = new System.Drawing.Size(73, 16);
            this.lblEtiNombre.TabIndex = 0;
            this.lblEtiNombre.Text = "Paciente:";
            // 
            // tbNombrePaciente
            // 
            this.tbNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombrePaciente.Location = new System.Drawing.Point(243, 93);
            this.tbNombrePaciente.Name = "tbNombrePaciente";
            this.tbNombrePaciente.Size = new System.Drawing.Size(263, 22);
            this.tbNombrePaciente.TabIndex = 1;
            // 
            // lblEtiEspecialidad
            // 
            this.lblEtiEspecialidad.AutoSize = true;
            this.lblEtiEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiEspecialidad.Location = new System.Drawing.Point(112, 143);
            this.lblEtiEspecialidad.Name = "lblEtiEspecialidad";
            this.lblEtiEspecialidad.Size = new System.Drawing.Size(104, 16);
            this.lblEtiEspecialidad.TabIndex = 2;
            this.lblEtiEspecialidad.Text = "Especialidad:";
            // 
            // cboElegirEspecialidad
            // 
            this.cboElegirEspecialidad.BackColor = System.Drawing.SystemColors.Window;
            this.cboElegirEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElegirEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboElegirEspecialidad.FormattingEnabled = true;
            this.cboElegirEspecialidad.Items.AddRange(new object[] {
            "General\t",
            "Pediatra\t",
            "Cirujano"});
            this.cboElegirEspecialidad.Location = new System.Drawing.Point(243, 140);
            this.cboElegirEspecialidad.Name = "cboElegirEspecialidad";
            this.cboElegirEspecialidad.Size = new System.Drawing.Size(263, 24);
            this.cboElegirEspecialidad.TabIndex = 3;
            // 
            // cbelegirMedico
            // 
            this.cbelegirMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbelegirMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbelegirMedico.FormattingEnabled = true;
            this.cbelegirMedico.Items.AddRange(new object[] {
            "Dr.Mario Callejas",
            "Dr.Jose Ramon\t",
            "Dra.Maria Polo"});
            this.cbelegirMedico.Location = new System.Drawing.Point(243, 192);
            this.cbelegirMedico.Name = "cbelegirMedico";
            this.cbelegirMedico.Size = new System.Drawing.Size(263, 24);
            this.cbelegirMedico.TabIndex = 5;
            // 
            // lblEtiMeidoc
            // 
            this.lblEtiMeidoc.AutoSize = true;
            this.lblEtiMeidoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiMeidoc.Location = new System.Drawing.Point(153, 195);
            this.lblEtiMeidoc.Name = "lblEtiMeidoc";
            this.lblEtiMeidoc.Size = new System.Drawing.Size(63, 16);
            this.lblEtiMeidoc.TabIndex = 4;
            this.lblEtiMeidoc.Text = "Medico:";
            // 
            // lblEtiFecha
            // 
            this.lblEtiFecha.AutoSize = true;
            this.lblEtiFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiFecha.Location = new System.Drawing.Point(161, 247);
            this.lblEtiFecha.Name = "lblEtiFecha";
            this.lblEtiFecha.Size = new System.Drawing.Size(55, 16);
            this.lblEtiFecha.TabIndex = 6;
            this.lblEtiFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblEtiHora
            // 
            this.lblEtiHora.AutoSize = true;
            this.lblEtiHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiHora.Location = new System.Drawing.Point(170, 310);
            this.lblEtiHora.Name = "lblEtiHora";
            this.lblEtiHora.Size = new System.Drawing.Size(46, 16);
            this.lblEtiHora.TabIndex = 8;
            this.lblEtiHora.Text = "Hora:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(243, 308);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblAgregarNuevoPaciente
            // 
            this.lblAgregarNuevoPaciente.AutoSize = true;
            this.lblAgregarNuevoPaciente.BackColor = System.Drawing.Color.White;
            this.lblAgregarNuevoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarNuevoPaciente.Location = new System.Drawing.Point(230, 21);
            this.lblAgregarNuevoPaciente.Name = "lblAgregarNuevoPaciente";
            this.lblAgregarNuevoPaciente.Size = new System.Drawing.Size(239, 24);
            this.lblAgregarNuevoPaciente.TabIndex = 12;
            this.lblAgregarNuevoPaciente.Text = "AGREGAR NUEVA CITA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::cPaciente.Properties.Resources.back;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(397, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "        Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Image = global::cPaciente.Properties.Resources.diskette__2_;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(222, 374);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 45);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "        Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // RegistroCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(742, 480);
            this.Controls.Add(this.lblAgregarNuevoPaciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblEtiHora);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblEtiFecha);
            this.Controls.Add(this.cbelegirMedico);
            this.Controls.Add(this.lblEtiMeidoc);
            this.Controls.Add(this.cboElegirEspecialidad);
            this.Controls.Add(this.lblEtiEspecialidad);
            this.Controls.Add(this.tbNombrePaciente);
            this.Controls.Add(this.lblEtiNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistroCitas";
            this.Text = "Registro Citas";
            this.Load += new System.EventHandler(this.RegistroCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiNombre;
        private System.Windows.Forms.TextBox tbNombrePaciente;
        private System.Windows.Forms.Label lblEtiEspecialidad;
        private System.Windows.Forms.ComboBox cboElegirEspecialidad;
        private System.Windows.Forms.ComboBox cbelegirMedico;
        private System.Windows.Forms.Label lblEtiMeidoc;
        private System.Windows.Forms.Label lblEtiFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEtiHora;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAgregarNuevoPaciente;
    }
}