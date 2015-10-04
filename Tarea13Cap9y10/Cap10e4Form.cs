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
    public partial class Cap10e4Form : Form
    {
        public Cap10e4Form()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            double control = Convert.ToDouble(LadostextBox.Text);

            if(control >= 2)
            {
                Poligono po = new Poligono(control);
                ResultadotextBox.Text = po.CalcularP().ToString();
            }
            else
            {
                MessageBox.Show("Ingrese desde 2 en adelante");
                LadostextBox.Clear();
            }
            

            
        }
    }
}
