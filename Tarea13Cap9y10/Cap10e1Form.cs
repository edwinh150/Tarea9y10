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
    public partial class Cap10e1Form : Form
    {

        public Cap10e1Form()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Tienda cap = new Tienda(NtextBox.Text,Convert.ToInt32(CtextBox.Text),Convert.ToDouble(ITBStextBox.Text),Convert.ToDouble(PtextBox.Text),Convert.ToDouble(DVtextBox.Text));

            ResultadolistBox.Items.Add("Nombre: " + cap.Nombre);
            ResultadolistBox.Items.Add("Cantidad: " + cap.Cantidad);
            ResultadolistBox.Items.Add("ITBS: " + cap.ITBS);
            ResultadolistBox.Items.Add("Precio: " + cap.Precio);
            ResultadolistBox.Items.Add("Devuelta: " + cap.Devuelta);

            NtextBox.Clear();
            CtextBox.Clear();
            ITBStextBox.Clear();
            PtextBox.Clear();
            DVtextBox.Clear();
        }
    }
}
