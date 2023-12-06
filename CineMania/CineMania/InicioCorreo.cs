using CineMania.API;
using Newtonsoft.Json;
using RestSharp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineMania
{
    public partial class InicioCorreo : Form   
    {
        private string usu;
        public InicioCorreo()
        {
            InitializeComponent();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string usu = txCorreo.Text;
            string contraseña = txContraseña.Text;

            try
            {
                dynamic respuesta = dbAPI.Get("http://localhost:50341/API/PERSONA");

                if (string.IsNullOrEmpty(usu) || string.IsNullOrEmpty(contraseña))
                {
                    lbMensaje.Text = "Debe de ingresar los datos";
                }
                else
                {
                    bool usuarioEncontrado = false;
                    foreach (var PERSONA in respuesta)
                    {
                        string correoapi = PERSONA.CORREO.ToString();
                        string conapi = PERSONA.CONTRASEÑA.ToString();
                        int rol = Int32.Parse(PERSONA.ACCESO.ToString());

                        if (usu == correoapi && contraseña == conapi)
                        {
                            MessageBox.Show("Bienvenido a CineMania");
                            Main objM = new Main(rol, usu);
                            this.Hide();
                            objM.Show();
                            usuarioEncontrado = true;


                            var client = new RestClient("http://localhost:");
                            var request = new RestRequest("http://localhost:", Method.Post);
                            request.AddParameter("username", correoapi);
                            request.AddParameter("password", conapi);
                            RestResponse response = client.Execute(request);


                            break;
                        }
                        else if (usu == correoapi)
                        {
                            lbMensaje.Text = "Correo o contraseña incorrecta";
                            usuarioEncontrado = true;
                            break;
                        }
                    }
                    if (!usuarioEncontrado)
                    {
                        lbMensaje.Text = "Correo o contraseña incorrecta";
                    }

                }
            }
            catch
            {
                lbMensaje.Text = "Correo o contraseña incorrecta";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro objRegistro = new Registro();
            objRegistro.Show();
            //this.Hide();
        }
    }
}
