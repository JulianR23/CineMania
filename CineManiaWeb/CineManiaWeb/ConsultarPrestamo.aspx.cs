using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineManiaWeb
{
    public partial class ConsultarPrestamo: System.Web.UI.Page
    {

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            SqlConnection conectar = DB.conectar("CINEMANIA");
            try
            {
                SqlDataReader objTabla;
                int cod = Int32.Parse(txCodigo.Text);

                string sqlConsultar = "select p.CODPELICULA, pp.NOMBRE  from PRESTAMO p inner join PERSONA pp" +
                    " on p.CORREO = pp.CORREO where CODPELICULA = " + cod;
                objTabla = DB.consulta(sqlConsultar, conectar);
                if (objTabla.Read() == true)
                {
                    txNombre.Text = objTabla[1].ToString();
                }
                else
                {
                    lbMensaje.Text = "No hay prestamos registrados";
                }

            }
            catch
            {
                lbMensaje.Text = "Error en la base de datos";
            }
            }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            txNombre.Text = "";
            txCodigo.Text = "";
        }
    }
    }
