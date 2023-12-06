using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CineMania
{
    public partial class Asistente : Form
    {
        public Asistente()
        {
            InitializeComponent();
        }

        private void pELICULABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pELICULABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cINEMANIADataSet);

        }

        private void Asistente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cINEMANIADataSet.PELICULA' Puede moverla o quitarla según sea necesario.
            this.pELICULATableAdapter.Fill(this.cINEMANIADataSet.PELICULA);

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
