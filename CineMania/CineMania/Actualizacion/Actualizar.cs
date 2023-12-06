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
    public partial class Actualizar : Form
    {
        public Actualizar()
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
                    btBuscar.Enabled = false;


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

        private void btCambiar_Click(object sender, EventArgs e)
        {
            gbCambiar.Visible = true;
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btActu_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = new SqlConnection("Data Source=localhost;Initial" +
                              " Catalog =  CINEMANIA; Integrated Security = SSPI; ");
            try
            {
                objConectar.Open();
                int cod = Int32.Parse(txCodigo.Text);
                string nom = txNombre.Text;
                double valor = Double.Parse(txValor.Text);
                int codSec = Int32.Parse(txCodSeccion.Text);
                string varAle = txCambio.Text;
                switch (cbCambio.Text)
                {
                    case "NOMBRE":
                        if (int.TryParse(varAle, out _))
                        {
                            MessageBox.Show("Solo se permiten letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txCambio.Clear();
                        }
                        else
                        {
                            string sqlpeliculas = "UPDATE PELICULA SET NOMBRE = @nombre WHERE NOMBRE = @nom";
                            SqlCommand comandopeliculas = new SqlCommand(sqlpeliculas, objConectar);
                            comandopeliculas.Parameters.AddWithValue("@nombre", varAle);
                            comandopeliculas.Parameters.AddWithValue("@nom", nom);


                            SqlTransaction transaccion = objConectar.BeginTransaction();

                            try
                            {
                                comandopeliculas.Transaction = transaccion;
                                comandopeliculas.ExecuteNonQuery();
                                transaccion.Commit();
                                MessageBox.Show("Nombre actualizado");
                            }
                            catch
                            {
                                transaccion.Rollback();
                                MessageBox.Show("Error en la base de datos: ");
                            }
                            finally
                            {
                                objConectar.Close();
                            }
                        }
                        break;
                    case "VALOR":
                        if (!int.TryParse(varAle, out _))
                        {
                            MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txCambio.Clear();
                        }
                        else
                        {
                            string sqlPeliculas = "UPDATE PELICULA SET VALOR = @valor WHERE VALOR = @val";
                            SqlCommand comandopelicula = new SqlCommand(sqlPeliculas, objConectar);
                            comandopelicula.Parameters.AddWithValue("@valor", varAle);
                            comandopelicula.Parameters.AddWithValue("@val", valor);

                            SqlTransaction transaccion = objConectar.BeginTransaction();

                            try
                            {
                                comandopelicula.Transaction = transaccion;
                                comandopelicula.ExecuteNonQuery();
                                transaccion.Commit();

                                MessageBox.Show("Valor actualizado");
                            }
                            catch
                            {
                                transaccion.Rollback();
                                MessageBox.Show("Error en la base de datos: ");
                            }
                            finally
                            {
                                objConectar.Close();
                            }
                        }
                        break;
                    case "CODSECCION":
                        if (!int.TryParse(varAle, out _))
                        {
                            MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txCambio.Clear();
                        }
                        else
                        {
                            string sqlPeliculas = "UPDATE PELICULA SET CODSECCION = @codSec WHERE CODSECCION = @codS";
                            SqlCommand comandopelicula = new SqlCommand(sqlPeliculas, objConectar);
                            comandopelicula.Parameters.AddWithValue("codSec", varAle);
                            comandopelicula.Parameters.AddWithValue("@codS", codSec);

                            SqlTransaction transaccion = objConectar.BeginTransaction();

                            try
                            {
                                comandopelicula.Transaction = transaccion;
                                comandopelicula.ExecuteNonQuery();
                                transaccion.Commit();

                                MessageBox.Show("Codigo de la seccion actualizado");
                            }
                            catch
                            {
                                transaccion.Rollback();
                                MessageBox.Show("Error en la base de datos: ");
                            }
                            finally
                            {
                                objConectar.Close();
                            }
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
