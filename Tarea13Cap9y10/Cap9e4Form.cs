using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea13Cap9y10
{
    public partial class Cap9e4Form : Form
    {
        enum neumaticos { Calle = 1, Nieves = 2, TodoTerreno = 3, Carreras = 4 };

        public Cap9e4Form()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            neumaticos tipos = neumaticos.Calle;
    
            int numero = Convert.ToInt32(EnumtextBox.Text);

            if (numero == (int)tipos)
            {
                ResultadotextBox.Text = tipos.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ResultadotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnumtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
