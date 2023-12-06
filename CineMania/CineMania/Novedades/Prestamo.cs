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
    public partial class Prestamo : Form
    {
        private string usu;
        public Prestamo(string usu)
        {
            InitializeComponent();
            this.usu = usu;
            VerificarEstadoPeliculas();
        }

        private void PbTenet_Click(object sender, EventArgs e)
        {
            lbPrestadaTenet.Visible = true;
            int codigo = 20;
            PrestamoDePeliculas(codigo);
            
        }

        private void PbOpp_Click(object sender, EventArgs e)
        {
            int codigo = 60;
            PrestamoDePeliculas(codigo);
            lbPrestadaOp.Visible = true;
        }

        private void PbNiños_Click(object sender, EventArgs e)
        {
            int codigo = 30;
            PrestamoDePeliculas(codigo);
            lbPrestadaNinos.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int codigo = 70;
            PrestamoDePeliculas(codigo);
            lbPrestadaDiablo.Visible = true;
        }

        private void PbVieja_Click(object sender, EventArgs e)
        {
            int codigo = 10;
            PrestamoDePeliculas(codigo);
            lbPrestadaVieja.Visible = true;
        }

        private void PbEscuadron_Click(object sender, EventArgs e)
        {
            int codigo = 90;
            PrestamoDePeliculas(codigo);
            lbPrestadaEscuadron.Visible = true;
        }

        private void PbAmanecer_Click(object sender, EventArgs e)
        {
            int codigo = 50;
            PrestamoDePeliculas(codigo);
            lbPrestadaCrep.Visible = true;
        }

        private void PbBirdBox_Click(object sender, EventArgs e)
        {
            int codigo = 100;
            PrestamoDePeliculas(codigo);
            lbPrestadaBird.Visible = true;
        }

        private void PbIlu_Click(object sender, EventArgs e)
        {
            int codigo = 40;
            PrestamoDePeliculas(codigo);
            lbPrestadailu.Visible = true;
        }

        private void PbDemonio_Click(object sender, EventArgs e)
        {
            int codigo = 80;
            PrestamoDePeliculas(codigo);
            lbPrestadaNoche.Visible = true;
        }
        private void PrestamoDePeliculas(int cod)
        {
            SqlConnection conectar = DB.conectar("CINEMANIA");
            try
            {
                string sqlValidacion = "SELECT * FROM PRESTAMO where CODPELICULA = " + cod;
                int p = DB.operar(sqlValidacion, conectar);
                if (p == 0)
                {
                    MessageBox.Show("Ya fue prestada esta pelicula");
                }
                else
                {
                    string sql = "INSERT INTO PRESTAMO VALUES (GETDATE(), DATEADD(DAY, 8, GETDATE())," + cod + ", '" + usu + "')";
                    int n = DB.operar(sql, conectar);
                    if (n == 0)
                    {
                        MessageBox.Show("Ya fue prestada esta pelicula");
                    }
                    else
                    {
                        MessageBox.Show("Pelicula prestada con éxito");
                    }
                }
                DB.cerrar(conectar);
            }
            catch
            {
                MessageBox.Show("Error conectando la base de datos");

            }
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

        private void VerificarEstadoPeliculas()
        {
            Dictionary<int, Label> peliculas = new Dictionary<int, Label>()
            {
                { 20, lbPrestadaTenet },
                { 60, lbPrestadaOp },
                { 30, lbPrestadaNinos },
                { 70, lbPrestadaDiablo },
                { 10, lbPrestadaVieja },
                { 90, lbPrestadaEscuadron },
                { 50, lbPrestadaCrep },
                { 100, lbPrestadaBird },
                { 40, lbPrestadailu },
                { 80, lbPrestadaNoche }
            };

            foreach (KeyValuePair<int, Label> pelicula in peliculas)
            {
                VerificarPeliculaPrestada(pelicula.Key, pelicula.Value);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    lbMensaje.Text = "¿La pelicula " + objTabla[1].ToString() + " es la que desea prestar?";
                }
                else
                {
                    lbMensaje.Text = "No existe la película, intente nuevamente." ;
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
            PrestamoDePeliculas(cod);
            VerificarEstadoPeliculas();
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
