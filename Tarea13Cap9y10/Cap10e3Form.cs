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
    public partial class Cap10e3Form : Form
    {
        public int Lados { get; set; }

        public Cap10e3Form()
        {
            InitializeComponent();
            Lados = 10;
        }

        public Cap10e3Form(int numero)
        {
            Lados = numero;
        }

        private void Mbutton_Click(object sender, EventArgs e)
        {
            Cap10e3Form s = new Cap10e3Form(12);
            RtextBox.Text = Lados.ToString();
        }
    }
}
