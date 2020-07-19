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
    public partial class FormCitas : Form
    {
        Controller.ConexionDatos dato = new Controller.ConexionDatos();
        public FormCitas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistroCitas rc = new Secretaria.RegistroCitas();
            rc.ShowDialog();
        }

        private void tlPersonal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
