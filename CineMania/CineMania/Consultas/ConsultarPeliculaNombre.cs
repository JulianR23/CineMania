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

namespace CineMania.Consultas
{
    public partial class ConsultarPeliculaNombre : Form
    {
        public ConsultarPeliculaNombre()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = new SqlConnection("" + "Data Source=localhost;Initial Catalog=CINEMANIA\r\n;Integrated Security=true");
            try
            {
                objConectar.Open();
                MessageBox.Show("Se realizó la conexión");
                string nom = txNombre.Text;
                string sql = "select * from PELICULA where NOMBRE = '" + nom + "'";
                SqlCommand objComando = new SqlCommand(sql, objConectar);
                SqlDataReader objTabla = objComando.ExecuteReader();
                if (objTabla.Read() == true)
                {
                    txCodigo.Text = objTabla[0].ToString();
                    txValor.Text = objTabla[2].ToString();
                    txSeccion.Text = objTabla[3].ToString();
                }
                else
                {
                    MessageBox.Show("No existe la película");
                    txCodigo.Clear();
                    txValor.Clear();
                    txSeccion.Clear();
                    txNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex.Message);
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txNombre.Clear();
            txCodigo.Clear();
            txValor.Clear();
            txSeccion.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            SqlConnection objConectar = new SqlConnection("" + "Data Source=localhost;Initial Catalog=CINEMANIA\r\n;Integrated Security=true");
            try
            {
                objConectar.Open();
                string nom = txNombre.Text;
                string sql = "select * from PELICULA where NOMBRE = '" + nom+ "'";
                SqlCommand objComando = new SqlCommand(sql, objConectar);
                SqlDataReader objTabla = objComando.ExecuteReader();
                if (objTabla.Read() == true)
                {
                    txCodigo.Text = objTabla[0].ToString();
                    decimal valor = Convert.ToDecimal(objTabla[2]);
                    txValor.Text = valor.ToString("0.##");
                    txSeccion.Text = objTabla[3].ToString();
                }
                else
                {
                    MessageBox.Show("No existe la película");
                    txNombre.Clear();
                    txValor.Clear();
                    txSeccion.Clear();
                    txCodigo.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error de conexion");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBorrar_Click_1(object sender, EventArgs e)
        {
            txNombre.Clear();
            txValor.Clear();
            txSeccion.Clear();
            txCodigo.Clear();
            txNombre.Focus();
        }
    }
}
