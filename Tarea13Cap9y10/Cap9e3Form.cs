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
    public partial class Cap9e3Form : Form
    {
        public struct Persona
        {
            public string Nombre;
            public int Edad;
            public string Direccion;
            public Mascota masco;

            public Persona(string nombre, int edad, string direccion, string Mnombre, int Medad, string Mraza)
            {
                Nombre = nombre;
                Edad = edad;
                Direccion = direccion;
                masco = new Mascota(Mnombre, Medad, Mraza);
                
            }
        }

        public struct Mascota
        {
            public string Nombre;
            public int Edad;
            public string Raza;

            public Mascota(string nombre, int edad, string raza)
            {
                Nombre = nombre;
                Edad = edad;
                Raza = raza;
            }
        }

        public Cap9e3Form()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int PEdad = Convert.ToInt32(EPtextBox.Text);
            int Medad = Convert.ToInt32(EMtextBox.Text);

            Persona p = new Persona(NPtextBox.Text, PEdad, DPtextBox.Text, NMtextBox.Text, Medad, RazatextBox.Text);

            MessageBox.Show("se guardo correctamente");

        }
    }
}
