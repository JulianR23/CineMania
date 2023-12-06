using CineMania.Actualizacion;
using CineMania.API;
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
    
    public partial class Main : Form
    {
        int rol;
        string usu;
        public Main(int rol, string usu)
        {
            InitializeComponent();
            this.rol = rol;
            this.usu = usu;

            if (rol == 2)
            {
                actualizacion.Visible = false;
                asistenteToolStripMenuItem.Visible = false;
            }
            else
            {
                if(rol==3)
                {
                    actualizacion.Visible = false;
                    maestroDetalleToolStripMenuItem.Visible = false;
                    asistenteToolStripMenuItem.Visible = false;
                    entregaToolStripMenuItem.Visible = false;
                    webToolStripMenuItem.Visible = false;
                    
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPeliculaCodigo objCPC = new ConsultarPeliculaCodigo();
            objCPC.Show();
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPeliculaNombre objCPN = new ConsultarPeliculaNombre();
            objCPN.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamo objPrestamo = new Prestamo(usu);
            objPrestamo.Show();
        }


        private void asistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistente objA = new Asistente();
            objA.Show();
        }

        private void maestroDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaestroDetalle objMd = new MaestroDetalle();
            objMd.Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrega objEntrega = new Entrega(usu);
            objEntrega.Show();

        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagWeb objWeb = new PagWeb();
            objWeb.Show();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            IngresarNuevaP objIP = new IngresarNuevaP();
            objIP.Show();
        }

        private void eliminarPelicula_Click(object sender, EventArgs e)
        {
            EliminarPelicula objEP = new EliminarPelicula();
            objEP.Show();
        }

        private void cambiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar objAP = new Actualizar();
            objAP.Show();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista objV = new Vista();
            objV.Show();
        }


        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioCorreo objInicio = new InicioCorreo();
            objInicio.Show();
            this.Close();
        }
    }
}
