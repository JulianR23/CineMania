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
    public partial class ConsultarPeliculaCodigo : Form
    {
        public ConsultarPeliculaCodigo()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = new SqlConnection("" + "Data Source=localhost;Initial Catalog=CINEMANIA\r\n;Integrated Security=true");
            try
            {
                objConectar.Open();
                int cod = Int32.Parse(txCodigo.Text);
                string sql = "select * from PELICULA where CODIGO = " + cod;
                SqlCommand objComando = new SqlCommand(sql, objConectar);
                SqlDataReader objTabla = objComando.ExecuteReader();
                if (objTabla.Read() == true)
                {
                    txNombre.Text = objTabla[1].ToString();
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

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txCodigo.Clear();
            txNombre.Clear();
            txValor.Clear();
            txSeccion.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
