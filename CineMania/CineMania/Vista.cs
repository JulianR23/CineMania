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
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cINEMANIADataSet1.PELICULASDISPONIBLES' Puede moverla o quitarla según sea necesario.
            this.pELICULASDISPONIBLESTableAdapter.Fill(this.cINEMANIADataSet1.PELICULASDISPONIBLES);

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
