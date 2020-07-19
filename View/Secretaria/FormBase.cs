using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPaciente.View.Secretaria
{
    public partial class FormBase : Form
    {
        Button botonActual;
        bool pantallaCompleta;
        public string codigoUser;
        public FormBase()
        {
            InitializeComponent();
            toolTipBase.Active = false;
          //  AbrirFormulario<FormInicio>();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenido.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario != null)
            {
                formulario.Close();
            }

            formulario = new MiForm();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(formulario);
            panelContenido.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }
        private void CambioColor()
        {
            Button[] boton = { btnPerfil, btnPacientes, btnCitas, btnSalir };
            foreach (Button btn in boton)
            {
                btn.BackColor = Color.SkyBlue;
            }
            botonActual.BackColor = Color.PowderBlue;
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Mi Perfil";
                AbrirFormulario<FormPerfil>();
                botonActual = (Button)sender;
                CambioColor();
            }
        }

        private void btnColapsar_Click(object sender, EventArgs e)
        {
            if (tlMenuBase.Width == 160) 
                  tlMenuBase.Width = 45;
            
            else
                tlMenuBase.Width = 160;
         
        }

        private void FormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin lg = new FormLogin();
            lg.Show();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            Secretaria.FormInicio fi = new Secretaria.FormInicio();
         //   MessageBox.Show(codigoUser);
            fi.TopLevel = false;
            fi.FormBorderStyle = FormBorderStyle.None;
            fi.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(fi);
            panelContenido.Tag = fi;
            fi.codEmpleado = codigoUser;
            fi.Show();
            fi.BringToFront();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Gestion Citas";
                AbrirFormulario<FormCitas>();
                botonActual = (Button)sender;
                CambioColor();
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Gestion Pacientes";
                AbrirFormulario<FormPacientes>();
                botonActual = (Button)sender;
                CambioColor();
            }

        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (pantallaCompleta)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(900, 550);
                this.CenterToScreen();
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.TopMost = true;
            }

            pantallaCompleta = !pantallaCompleta;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            log.Show();
            Hide();
        }
    }
}
