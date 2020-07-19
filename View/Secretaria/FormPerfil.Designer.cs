namespace cPaciente.View.Secretaria
{
    partial class FormPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfil));
            this.tbDir = new System.Windows.Forms.TextBox();
            this.lbDirActual = new System.Windows.Forms.Label();
            this.lbTelActual = new System.Windows.Forms.Label();
            this.lbCorreoActual = new System.Windows.Forms.Label();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.lbDir = new System.Windows.Forms.Label();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.lbMunicipio = new System.Windows.Forms.Label();
            this.gbUbicacion = new System.Windows.Forms.GroupBox();
            this.tlUbicacion = new System.Windows.Forms.TableLayoutPanel();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.tbConfirmClave = new System.Windows.Forms.TextBox();
            this.lbConfirmClave = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lbRol = new System.Windows.Forms.Label();
            this.pbImgPerfil = new System.Windows.Forms.PictureBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.tlPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.lbClave = new System.Windows.Forms.Label();
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlPerfil = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.tlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUbicacion.SuspendLayout();
            this.tlUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfil)).BeginInit();
            this.gbPersonal.SuspendLayout();
            this.tlPersonal.SuspendLayout();
            this.tlPanel.SuspendLayout();
            this.tlBotones.SuspendLayout();
            this.tlPerfil.SuspendLayout();
            this.tlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDir
            // 
            this.tbDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDir.Location = new System.Drawing.Point(140, 126);
            this.tbDir.Multiline = true;
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(201, 47);
            this.tbDir.TabIndex = 22;
            this.tbDir.Text = "Canton Santa Lucia 45";
            // 
            // lbDirActual
            // 
            this.lbDirActual.AutoSize = true;
            this.lbDirActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDirActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirActual.Location = new System.Drawing.Point(3, 115);
            this.lbDirActual.Name = "lbDirActual";
            this.lbDirActual.Size = new System.Drawing.Size(186, 29);
            this.lbDirActual.TabIndex = 4;
            this.lbDirActual.Text = "Dirección:Canton Santa Lucia 45";
            this.lbDirActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTelActual
            // 
            this.lbTelActual.AutoSize = true;
            this.lbTelActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTelActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelActual.Location = new System.Drawing.Point(3, 92);
            this.lbTelActual.Name = "lbTelActual";
            this.lbTelActual.Size = new System.Drawing.Size(124, 23);
            this.lbTelActual.TabIndex = 3;
            this.lbTelActual.Text = "Teléfono : 7789-9887";
            this.lbTelActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCorreoActual
            // 
            this.lbCorreoActual.AutoSize = true;
            this.lbCorreoActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCorreoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreoActual.Location = new System.Drawing.Point(3, 69);
            this.lbCorreoActual.Name = "lbCorreoActual";
            this.lbCorreoActual.Size = new System.Drawing.Size(188, 23);
            this.lbCorreoActual.TabIndex = 2;
            this.lbCorreoActual.Text = "Correo:  ZGonza@cpaciente.com";
            this.lbCorreoActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCorreoActual.Click += new System.EventHandler(this.lbCorreoActual_Click);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Location = new System.Drawing.Point(140, 23);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(201, 24);
            this.cbMunicipio.TabIndex = 15;
            this.cbMunicipio.Text = "La Libertad";
            // 
            // lbDir
            // 
            this.lbDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDir.Location = new System.Drawing.Point(3, 123);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(131, 53);
            this.lbDir.TabIndex = 17;
            this.lbDir.Text = "Dirección:";
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartamento.Location = new System.Drawing.Point(3, 20);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(131, 51);
            this.lbDepartamento.TabIndex = 14;
            this.lbDepartamento.Text = "Departamento:";
            // 
            // lbMunicipio
            // 
            this.lbMunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMunicipio.Location = new System.Drawing.Point(3, 71);
            this.lbMunicipio.Name = "lbMunicipio";
            this.lbMunicipio.Size = new System.Drawing.Size(131, 52);
            this.lbMunicipio.TabIndex = 15;
            this.lbMunicipio.Text = "Municipio:";
            // 
            // gbUbicacion
            // 
            this.gbUbicacion.Controls.Add(this.tlUbicacion);
            this.gbUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUbicacion.Location = new System.Drawing.Point(370, 257);
            this.gbUbicacion.Name = "gbUbicacion";
            this.gbUbicacion.Size = new System.Drawing.Size(350, 205);
            this.gbUbicacion.TabIndex = 10;
            this.gbUbicacion.TabStop = false;
            this.gbUbicacion.Text = "Ubicación";
            // 
            // tlUbicacion
            // 
            this.tlUbicacion.ColumnCount = 2;
            this.tlUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlUbicacion.Controls.Add(this.cbMunicipio, 1, 1);
            this.tlUbicacion.Controls.Add(this.tbDir, 1, 3);
            this.tlUbicacion.Controls.Add(this.cbDepartamento, 1, 2);
            this.tlUbicacion.Controls.Add(this.lbDir, 0, 3);
            this.tlUbicacion.Controls.Add(this.lbDepartamento, 0, 1);
            this.tlUbicacion.Controls.Add(this.lbMunicipio, 0, 2);
            this.tlUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUbicacion.Location = new System.Drawing.Point(3, 26);
            this.tlUbicacion.Name = "tlUbicacion";
            this.tlUbicacion.RowCount = 4;
            this.tlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlUbicacion.Size = new System.Drawing.Size(344, 176);
            this.tlUbicacion.TabIndex = 17;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(140, 74);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(201, 24);
            this.cbDepartamento.TabIndex = 0;
            this.cbDepartamento.Text = "Quezaltepeque";
            // 
            // tbConfirmClave
            // 
            this.tbConfirmClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConfirmClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmClave.Location = new System.Drawing.Point(140, 147);
            this.tbConfirmClave.Name = "tbConfirmClave";
            this.tbConfirmClave.PasswordChar = '•';
            this.tbConfirmClave.Size = new System.Drawing.Size(201, 23);
            this.tbConfirmClave.TabIndex = 21;
            // 
            // lbConfirmClave
            // 
            this.lbConfirmClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConfirmClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmClave.Location = new System.Drawing.Point(3, 144);
            this.lbConfirmClave.Name = "lbConfirmClave";
            this.lbConfirmClave.Size = new System.Drawing.Size(131, 32);
            this.lbConfirmClave.TabIndex = 14;
            this.lbConfirmClave.Text = "Confirmar clave:";
            // 
            // tbClave
            // 
            this.tbClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClave.Location = new System.Drawing.Point(140, 116);
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '•';
            this.tbClave.Size = new System.Drawing.Size(201, 23);
            this.tbClave.TabIndex = 20;
            this.tbClave.Text = "010101";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(140, 23);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(201, 23);
            this.tbUsuario.TabIndex = 17;
            this.tbUsuario.Text = "Zgonza";
            // 
            // tbTel
            // 
            this.tbTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTel.Location = new System.Drawing.Point(140, 85);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(201, 23);
            this.tbTel.TabIndex = 19;
            this.tbTel.Text = "7789-9887";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(140, 54);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(201, 23);
            this.tbCorreo.TabIndex = 18;
            this.tbCorreo.Text = "ZGonza@cpaciente.com";
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.ForeColor = System.Drawing.Color.DarkRed;
            this.lbRol.Location = new System.Drawing.Point(3, 46);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(106, 23);
            this.lbRol.TabIndex = 1;
            this.lbRol.Text = "Rol:    Secretaria";
            this.lbRol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbImgPerfil
            // 
            this.pbImgPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImgPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbImgPerfil.Image")));
            this.pbImgPerfil.Location = new System.Drawing.Point(3, 28);
            this.pbImgPerfil.Name = "pbImgPerfil";
            this.pbImgPerfil.Size = new System.Drawing.Size(144, 144);
            this.pbImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgPerfil.TabIndex = 2;
            this.pbImgPerfil.TabStop = false;
            // 
            // lbCorreo
            // 
            this.lbCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(3, 51);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(131, 31);
            this.lbCorreo.TabIndex = 15;
            this.lbCorreo.Text = "Correo:";
            // 
            // lbTel
            // 
            this.lbTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(3, 82);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(131, 31);
            this.lbTel.TabIndex = 16;
            this.lbTel.Text = "Teléfono:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(3, 20);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(131, 31);
            this.lbUsuario.TabIndex = 12;
            this.lbUsuario.Text = "Usuario:";
            // 
            // gbPersonal
            // 
            this.gbPersonal.Controls.Add(this.tlPersonal);
            this.gbPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonal.Location = new System.Drawing.Point(14, 257);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(350, 205);
            this.gbPersonal.TabIndex = 9;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Personal";
            // 
            // tlPersonal
            // 
            this.tlPersonal.ColumnCount = 2;
            this.tlPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlPersonal.Controls.Add(this.tbConfirmClave, 1, 5);
            this.tlPersonal.Controls.Add(this.lbConfirmClave, 0, 5);
            this.tlPersonal.Controls.Add(this.tbClave, 1, 4);
            this.tlPersonal.Controls.Add(this.tbUsuario, 1, 1);
            this.tlPersonal.Controls.Add(this.tbTel, 1, 3);
            this.tlPersonal.Controls.Add(this.lbClave, 0, 4);
            this.tlPersonal.Controls.Add(this.lbCorreo, 0, 2);
            this.tlPersonal.Controls.Add(this.lbTel, 0, 3);
            this.tlPersonal.Controls.Add(this.tbCorreo, 1, 2);
            this.tlPersonal.Controls.Add(this.lbUsuario, 0, 1);
            this.tlPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersonal.Location = new System.Drawing.Point(3, 26);
            this.tlPersonal.Name = "tlPersonal";
            this.tlPersonal.RowCount = 6;
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPersonal.Size = new System.Drawing.Size(344, 176);
            this.tlPersonal.TabIndex = 15;
            // 
            // lbClave
            // 
            this.lbClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClave.Location = new System.Drawing.Point(3, 113);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(131, 31);
            this.lbClave.TabIndex = 13;
            this.lbClave.Text = "Clave:";
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 4;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.534734F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.46527F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.46527F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.534734F));
            this.tlPanel.Controls.Add(this.gbPersonal, 1, 1);
            this.tlPanel.Controls.Add(this.gbUbicacion, 2, 1);
            this.tlPanel.Controls.Add(this.tlBotones, 2, 2);
            this.tlPanel.Controls.Add(this.tlPerfil, 1, 0);
            this.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanel.Location = new System.Drawing.Point(0, 0);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 3;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.62366F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.37634F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlPanel.Size = new System.Drawing.Size(736, 511);
            this.tlPanel.TabIndex = 1;
            // 
            // tlBotones
            // 
            this.tlBotones.ColumnCount = 2;
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.Controls.Add(this.btnActualizar, 0, 0);
            this.tlBotones.Controls.Add(this.btnCancelar, 1, 0);
            this.tlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBotones.Location = new System.Drawing.Point(370, 468);
            this.tlBotones.Name = "tlBotones";
            this.tlBotones.RowCount = 1;
            this.tlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.Size = new System.Drawing.Size(350, 40);
            this.tlBotones.TabIndex = 14;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.Location = new System.Drawing.Point(3, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(169, 34);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(178, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 34);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tlPerfil
            // 
            this.tlPerfil.ColumnCount = 2;
            this.tlPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPerfil.Controls.Add(this.btnCambiarImagen, 0, 3);
            this.tlPerfil.Controls.Add(this.tlDatos, 1, 1);
            this.tlPerfil.Controls.Add(this.pbImgPerfil, 0, 1);
            this.tlPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPerfil.Location = new System.Drawing.Point(14, 3);
            this.tlPerfil.Name = "tlPerfil";
            this.tlPerfil.RowCount = 5;
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.82645F));
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.30303F));
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.65289F));
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21763F));
            this.tlPerfil.Size = new System.Drawing.Size(350, 248);
            this.tlPerfil.TabIndex = 15;
            this.tlPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.tlPerfil_Paint);
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambiarImagen.Location = new System.Drawing.Point(3, 183);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(144, 35);
            this.btnCambiarImagen.TabIndex = 0;
            this.btnCambiarImagen.Text = "Cambiar imagen";
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            // 
            // tlDatos
            // 
            this.tlDatos.ColumnCount = 1;
            this.tlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDatos.Controls.Add(this.lbDirActual, 0, 5);
            this.tlDatos.Controls.Add(this.lbTelActual, 0, 4);
            this.tlDatos.Controls.Add(this.lbCorreoActual, 0, 3);
            this.tlDatos.Controls.Add(this.lbRol, 0, 2);
            this.tlDatos.Controls.Add(this.lbNombre, 0, 1);
            this.tlDatos.Controls.Add(this.label1, 0, 0);
            this.tlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDatos.Location = new System.Drawing.Point(153, 28);
            this.tlDatos.Name = "tlDatos";
            this.tlDatos.RowCount = 6;
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlDatos.Size = new System.Drawing.Size(194, 144);
            this.tlDatos.TabIndex = 1;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(3, 23);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(174, 23);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:  Zuleima Gonzales";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.tlPanel);
            this.Name = "FormPerfil";
            this.Text = "FormPerfil";
            this.gbUbicacion.ResumeLayout(false);
            this.tlUbicacion.ResumeLayout(false);
            this.tlUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfil)).EndInit();
            this.gbPersonal.ResumeLayout(false);
            this.tlPersonal.ResumeLayout(false);
            this.tlPersonal.PerformLayout();
            this.tlPanel.ResumeLayout(false);
            this.tlBotones.ResumeLayout(false);
            this.tlPerfil.ResumeLayout(false);
            this.tlDatos.ResumeLayout(false);
            this.tlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Label lbDirActual;
        private System.Windows.Forms.Label lbTelActual;
        private System.Windows.Forms.Label lbCorreoActual;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.Label lbDir;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.Label lbMunicipio;
        private System.Windows.Forms.GroupBox gbUbicacion;
        private System.Windows.Forms.TableLayoutPanel tlUbicacion;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.TextBox tbConfirmClave;
        private System.Windows.Forms.Label lbConfirmClave;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.PictureBox pbImgPerfil;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.TableLayoutPanel tlPersonal;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.TableLayoutPanel tlBotones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tlPerfil;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.TableLayoutPanel tlDatos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label1;
    }
}