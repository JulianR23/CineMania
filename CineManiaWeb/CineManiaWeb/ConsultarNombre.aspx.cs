
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineManiaWeb
{
    public partial class ConsultarNombre : System.Web.UI.Page
    {
        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            txCodigo.Text = "";
            txCodSec.Text = "";
            txNombre.Text = "";
            txValor.Text = "";
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = DB.conectar("CINEMANIA");
            SqlDataReader objTabla;
            string nom = txNombre.Text;


            if (string.IsNullOrEmpty(nom))
            {
                lbMensaje.Text ="Debe ingresar toda la informacion";
            }
            else
            {
                string sqlConsultar = "SELECT * FROM PELICULA WHERE NOMBRE='" + nom + "'";
                objTabla = DB.consulta(sqlConsultar, conectar);
                if (objTabla.Read() == true)
                {
                    txCodigo.Text = objTabla[0].ToString();
                    txValor.Text = objTabla[2].ToString();
                    txCodSec.Text = objTabla[3].ToString();

                }
                else
                {
                   lbMensaje.Text="La pelicula no está registrada en ninguna sección";
                }

            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}