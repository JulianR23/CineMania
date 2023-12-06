using CineMania.Consultas;
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
    public partial class Entrega : Form
    {
        private string usu;
        public Entrega(string usu)
        {
            InitializeComponent();
            this.usu = usu;
            VerificarPeliculaPrestada(20, lbPrestadaTenet);
            VerificarPeliculaPrestada(60, lbPrestadaOp);
            VerificarPeliculaPrestada(30, lbPrestadaNinos);
            VerificarPeliculaPrestada(70, lbPrestadaDiablo);
            VerificarPeliculaPrestada(10, lbPrestadaVieja);
            VerificarPeliculaPrestada(90, lbPrestadaEscuadron);
            VerificarPeliculaPrestada(50, lbPrestadaCrep);
            VerificarPeliculaPrestada(100, lbPrestadaBird);
            VerificarPeliculaPrestada(40, lbPrestadailu);
            VerificarPeliculaPrestada(80, lbPrestadaNoche);
        }

            private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntregaDePeliculas(int cod)
        {
            SqlConnection conectar = DB.conectar("CINEMANIA");
            try
            {
                string sqlValidacion = "SELECT * FROM PRESTAMO where CODPELICULA = " + cod;
                int p = DB.operar(sqlValidacion, conectar);
                if (p == 0)
                {
                    MessageBox.Show("Ya fue entregada la pelicula");
                }
                else
                {
                    string sql = "DELETE FROM PRESTAMO WHERE CODPELICULA = " + cod;
                    int n = DB.operar(sql, conectar);
                    if (n == 0)
                    {
                        MessageBox.Show("Ya fue entregada esta pelicula");
                    }
                    else
                    {
                        MessageBox.Show("Pelicula entregada con éxito");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error conectando la base de datos");

            }
        }

        private void PbTenet_Click(object sender, EventArgs e)
        {
            int codigo = 20;
            EntregaDePeliculas(codigo);
            lbPrestadaTenet.Visible = false;
        }

        private void PbOpp_Click(object sender, EventArgs e)
        {
            int codigo = 60;
            EntregaDePeliculas(codigo);
            lbPrestadaOp.Visible = false;
        }

        private void PbNiños_Click(object sender, EventArgs e)
        {
            int codigo = 30;
            EntregaDePeliculas(codigo);
            lbPrestadaNinos.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int codigo = 70;
            EntregaDePeliculas(codigo);
            lbPrestadaDiablo.Visible = false;
        }

        private void PbVieja_Click(object sender, EventArgs e)
        {
            int codigo = 10;
            EntregaDePeliculas(codigo);
            lbPrestadaVieja.Visible = false;
        }

        private void PbEscuadron_Click(object sender, EventArgs e)
        {
            int codigo = 90;
            EntregaDePeliculas(codigo);
            lbPrestadaEscuadron.Visible = false;
        }

        private void PbAmanecer_Click(object sender, EventArgs e)
        {
            int codigo = 50;
            EntregaDePeliculas(codigo);
            lbPrestadaCrep.Visible = false;
        }

        private void PbBirdBox_Click(object sender, EventArgs e)
        {
            int codigo = 100;
            EntregaDePeliculas(codigo);
            lbPrestadaBird.Visible = false;
        }

        private void PbIlu_Click(object sender, EventArgs e)
        {
            int codigo = 40;
            EntregaDePeliculas(codigo);
            lbPrestadailu.Visible = false;
        }

        private void PbDemonio_Click(object sender, EventArgs e)
        {
            int codigo = 80;
            EntregaDePeliculas(codigo);
            lbPrestadaNoche.Visible = false;
        }
        private void VerificarPeliculaPrestada(int codigo, Label label)
        {
            SqlConnection conectar = DB.conectar("CINEMANIA");
            string sqlValidacion = "SELECT * FROM PRESTAMO where CODPELICULA = " + codigo;
            SqlDataReader tabla = DB.consulta(sqlValidacion, conectar);
            if (tabla.HasRows)
            {
                label.Visible = true;
            }
            DB.cerrar(conectar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = DB.conectar("CINEMANIA");
            try
            {
                int cod = Int32.Parse(txCodigo.Text);
                string sql = "select * from PELICULA where CODIGO = " + cod;
                SqlCommand objComando = new SqlCommand(sql, conectar);
                SqlDataReader objTabla = objComando.ExecuteReader();
                if (objTabla.Read() == true)
                {
                    lbMensaje.Text = "¿La pelicula " + objTabla[1].ToString() + " es la que desea entregar?";
                }
                else
                {
                    lbMensaje.Text = "No existe la película, intente nuevamente.";
                }
                DB.cerrar(conectar);
            }
            catch
            {
                MessageBox.Show("Error de conexion");
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            int cod = Int32.Parse(txCodigo.Text);
            EntregaDePeliculas(cod);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarPeliculaNombre objConsulPeliNom = new ConsultarPeliculaNombre();
            objConsulPeliNom.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
