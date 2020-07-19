using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using cPaciente.View.Secretaria;

namespace cPaciente.Controller
{
    class ConexionDatos
    {
        string cadena = "Data source=DESKTOP-RFJSDKI; Initial catalog=CPacienteBD; Integrated security=true;";
        public SqlConnection conectarbd = new SqlConnection();
        public SqlDataAdapter adaptador;
        public SqlDataReader lector;
        public SqlCommand comando;
        public DataTable datos;
        public bool error = false;

        public ConexionDatos()
        {
            conectarbd.ConnectionString = cadena;
        }


        //metodo para cargar un datagrid atravez de una consulta
        public void CargarDatagrid(string consulta , DataGridView dgv)
        {
            try
            {
                adaptador = new SqlDataAdapter(consulta, conectarbd);
                datos = new DataTable();
                adaptador.Fill(datos);
                dgv.DataSource = datos;
            }
            catch (Exception)
            {
                MessageBox.Show("La consulta no se ejectuto debidamente", "ERROR 01", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarLabels(string consulta, Label lb)
        {
            conectarbd.Open();
            comando = new SqlCommand(consulta, conectarbd);
            lector = comando.ExecuteReader();

            if (lector.Read())
                lb.Text = lector[0].ToString();

            conectarbd.Close();
        }
        //Cargar TextBox
        public void CargarTextvox(string consulta, TextBox tx)
        {
            conectarbd.Open();
            comando = new SqlCommand(consulta, conectarbd);
            lector = comando.ExecuteReader();

            if (lector.Read())
                tx.Text = lector[0].ToString();

            conectarbd.Close();
        }
        //Cargar combobox
        public void CargarComboBox(string consulta, ComboBox desplegar, string mostrarColumna, string devolverValor)
        {
            try
            {
                adaptador = new SqlDataAdapter(consulta, conectarbd);
                datos = new DataTable();
                adaptador.Fill(datos);
                desplegar.DataSource = datos;
                desplegar.DisplayMember = mostrarColumna;
                desplegar.ValueMember = devolverValor;
            }
            catch (Exception) { }
        }

        //Llenar listbox
        public void CargarLista(string consulta, ListBox desplegar, string mostrarColumna, string devolverValor, string valor)
        {
            adaptador = new SqlDataAdapter(consulta, conectarbd);
            datos = new DataTable();
            adaptador.Fill(datos);
            desplegar.DataSource = datos;
            desplegar.DisplayMember = mostrarColumna;
            desplegar.ValueMember = devolverValor;
            desplegar.Text = "Elegir " + valor;
        }
        //Metodo para insertar registros, devuelve verdadero o falso dependiendo de la forma en que se ejecute
        public bool InsertarRegistros(string consulta)
        {
            conectarbd.Open();
            try
            {
                comando = new SqlCommand(consulta, conectarbd);
                int filasafectadas = comando.ExecuteNonQuery();
                conectarbd.Close();
                if (filasafectadas > 0) { return true; }
                else
                {
                    MessageBox.Show("No se guardo ningun registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (InvalidCastException e)
            {
                conectarbd.Close();
                MessageBox.Show("Error al guardar" + e.Message);
                return false;
            }
            catch (SqlException e)
            {
                conectarbd.Close();
                MessageBox.Show("No se pudo guardar " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Nuevo metodo
        public int ResultadoConsulta(string cadena)
        {
            int datoRecuperado = 0;
            conectarbd.Open();
            try
            {
                comando = new SqlCommand(cadena, conectarbd);
                lector = comando.ExecuteReader();
                if (lector.Read())
                    datoRecuperado = Convert.ToInt32(lector[0]);

            }
            catch (Exception)
            {
                // MessageBox.Show("Ups, ocurrio un error al momento de recuperar la información\nVerifique que la información que desea recuperar sea correcta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datoRecuperado = -1;
            }
            conectarbd.Close();
            return datoRecuperado;
        }

       
    }
}
