using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineMania
{
    public partial class EliminarPelicula : Form
    {
        public EliminarPelicula()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = new SqlConnection("Data Source=localhost;Initial" +
              " Catalog =  CINEMANIA; Integrated Security = SSPI; ");


            try
            {
                objConectar.Open();
                int cod = Int32.Parse(txCodigo.Text);
                string sql = "select * from PELICULA where codigo=" + cod;
                SqlCommand objComando = new SqlCommand(sql, objConectar);
                SqlDataReader objTabla = objComando.ExecuteReader();
                if (objTabla.Read())
                {
                    txNombre.Text = objTabla[1].ToString();
                    txValor.Text = objTabla[2].ToString();
                    txCodSeccion.Text = objTabla[3].ToString();
                    btBuscar.Enabled = false;
                    btEliminar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("La pelicula no existe");
                    txCodigo.Focus();
                    txNombre.Clear();
                    txValor.Clear();
                    txCodSeccion.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión " + ex.Message);
            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = DB.conectar("CINEMANIA");
            int cod = Int32.Parse(txCodigo.Text);
            string sql = "DELETE FROM PELICULA WHERE codigo =" + cod;
            int n = DB.operar(sql, objConector);
            if (n == 0)
            {
                MessageBox.Show("La pelicula no fue eliminada");
            }
            else
            {
                MessageBox.Show("La pelicula fue eliminada");
            }
            DB.cerrar(objConector);
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txCodigo.Clear();
            txNombre.Clear();
            txValor.Clear();
            txCodSeccion.Clear();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
