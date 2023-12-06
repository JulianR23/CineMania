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
    public partial class IngresarNuevaP : Form
    {
        public IngresarNuevaP()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                int cod = Int32.Parse(txCodigo.Text);
                string nom = txNombre.Text;
                double valor = Double.Parse(txValor.Text);
                int codsed = Int32.Parse(txCodSeccion.Text);

                SqlConnection objConector = DB.conectar("CINEMANIA");
                string sqlread = "SELECT * FROM PELICULA WHERE codigo =" + cod + " OR nombre = '" + nom + "'";
                string sql = "INSERT INTO PELICULA (CODIGO, NOMBRE, VALOR, CODSECCION) " +
                     "VALUES (" + cod + ", '" + nom + "', " + valor + "," + codsed + ")";



                SqlCommand objComando = new SqlCommand(sqlread, objConector);
                SqlDataReader objTabla = objComando.ExecuteReader();
                if (objTabla.Read())
                {
                    MessageBox.Show("No se puede agregar una pelicula que ya existe");
                }
                else
                {
                    objTabla.Close();
                    int n = DB.operar(sql, objConector);
                    if (n == 0)
                    {
                        MessageBox.Show("La pelicula no fue añadida");
                    }
                    else
                    {
                        MessageBox.Show("La pelicula fue añadida correctamente");
                    }
                }
                DB.cerrar(objConector);
                txCodigo.Clear();
                txNombre.Clear();
                txValor.Clear();
                txCodSeccion.Clear();
                txCodigo.Focus();
            }
            catch
            {
                MessageBox.Show("ERROR ");
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txCodigo.Clear();
            txNombre.Clear();
            txValor.Clear();
            txCodSeccion.Clear();
            txCodigo.Focus();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
