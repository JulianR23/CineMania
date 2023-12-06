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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void txNombre_Click(object sender, EventArgs e)
        {
            txNombre.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = DB.conectar("CINEMANIA");
            try
            {  
                if (txContra.Text == txContraRep.Text && txCorreo.Text.Contains("@") && txCorreo.Text.Contains("."))
                {
                    string sqlRegistro = "INSERT INTO PERSONA VALUES ('" + txNombre.Text + "', " + int.Parse(txTel.Text) + ", '" + txCorreo.Text
                    + "', '" + txContra.Text + "', 3)";
                    int n = DB.operar(sqlRegistro, conectar);
                    if (n == 0)
                    {
                        lbMensaje.Text = "No se pudo agregar. Intente nuevamente";
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    lbMensaje.Text = "No se pudo agregar, intente nuevamente";
                }             
            }
            catch
            {
                MessageBox.Show("Error en la base de datos. Reintente más tarde");
            }
        }
    }
}
