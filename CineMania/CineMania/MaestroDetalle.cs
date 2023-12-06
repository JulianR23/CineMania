using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineMania
{
    public partial class MaestroDetalle : Form
    {
        public MaestroDetalle()
        {
            InitializeComponent();
        }

        private void MaestroDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cINEMANIADataSet.PELICULA' Puede moverla o quitarla según sea necesario.
            this.pELICULATableAdapter.Fill(this.cINEMANIADataSet.PELICULA);
            // TODO: esta línea de código carga datos en la tabla 'cINEMANIADataSet.SECCION' Puede moverla o quitarla según sea necesario.
            this.sECCIONTableAdapter.Fill(this.cINEMANIADataSet.SECCION);

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
