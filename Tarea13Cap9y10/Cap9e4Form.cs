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
            int comparacion = 0;
            comparacion = (int)tipos;
            if (numero == comparacion)
            {
                ResultadotextBox.Text = tipos.ToString();
            }


        }
        
    }
}
