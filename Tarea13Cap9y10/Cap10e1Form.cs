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
        private string Nombre { get; set; }
        private int Cantidad { get; set; }
        private double ITBS { get; set; }
        private double Precio { get; set; }
        private double Devuelta { get; set; }

        public Cap10e1Form()
        {
            InitializeComponent();
        }

        public Cap10e1Form(string nombre, int cantidad, double itbs, double precio, double devuelta)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            ITBS = itbs;
            Precio = precio;
            Devuelta = devuelta;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cap10e1Form cap = new Cap10e1Form(NtextBox.Text,Convert.ToInt32(CtextBox.Text),Convert.ToDouble(ITBStextBox.Text),Convert.ToDouble(PtextBox.Text),Convert.ToDouble(DVtextBox.Text));

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
