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

namespace CineMania.Actualizacion
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
                    decimal valor = Convert.ToDecimal(objTabla[2]);
                    txValor.Text = valor.ToString("0.##");

                    txCodSeccion.Text = objTabla[3].ToString();
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
            catch
            {
                MessageBox.Show("Error de conexión ");
            }
        }


        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
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
                    txCodigo.Clear();
                    txNombre.Clear();
                    txValor.Clear();
                    txCodSeccion.Clear();
                }
                DB.cerrar(objConector);
            }
            catch
            {
                MessageBox.Show("Error en la conexión, intenta nuevamente");
            }
            
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
