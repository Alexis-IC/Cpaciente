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
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            RegistrarPaciente frp = new RegistrarPaciente();
            frp.ShowDialog();
        }
    }
}
