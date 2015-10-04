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
    public partial class Cap10e2Form : Form
    {

        public Cap10e2Form()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiante cap2 = new Estudiante(NtextBox.Text, Convert.ToDouble(CtextBox.Text), CursotextBox.Text, Convert.ToInt32(EtextBox.Text));

            ResultadolistBox.Items.Add("Nombre: " + cap2.Nombre);
            ResultadolistBox.Items.Add("Calificacion: " + cap2.Calificacion);
            ResultadolistBox.Items.Add("Curso: " + cap2.Curso);
            ResultadolistBox.Items.Add("Edad: " + cap2.Edad);

            NtextBox.Clear();
            CtextBox.Clear();
            CursotextBox.Clear();
            EtextBox.Clear();
        }
    }
}
