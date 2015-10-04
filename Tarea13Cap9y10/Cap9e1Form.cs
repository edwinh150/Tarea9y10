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
    public partial class Cap9e1Form : Form
    {
        public struct Tienda
        {
            public string Productos;

            public Tienda(string Prod)
            {
                Productos = Prod;
            }
        }

        public Cap9e1Form()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Tienda t = new Tienda(GuardartextBox.Text);

            MessageBox.Show("Se guardo correctamente");
            GuardartextBox.Clear();

            ResultadotextBox.Text = t.Productos;
        }
    }
}
