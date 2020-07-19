using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPaciente.View.Admin
{
    public partial class FormPersonal : Form
    {
        Controller.Personal p = new Controller.Personal();
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            p.ListarEmpleados(dgPersonal);
           // p.CargarComboBox("select * from Cargos", cbRol, "Nombre_Cargo", "IDCargo");
           
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.FiltrarEmpleado(dgPersonal, "c.Nombre_Cargo", cbRol.Text);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormRegistroEmpleado frp = new FormRegistroEmpleado();
            frp.ShowDialog();
        }

        private void dgPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
