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
    public partial class Cap9e2Form : Form
    {
        public struct CuentadeBanco
        {
            public string Nombre;
            public double NumeroCuenta;
            public double Dinero;

            public CuentadeBanco(string nombre, double numero, double dinero)
            {
                Nombre = nombre;
                NumeroCuenta = numero;
                Dinero = dinero;
            }
        }

        public Cap9e2Form()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(NumeroCuentatextBox.Text);
            double di = Convert.ToDouble(DinerotextBox.Text);

            CuentadeBanco cuenta = new CuentadeBanco(NombretextBox.Text, num, di);
            MessageBox.Show("Se guardo correctamente");

            RlistBox.Items.Add("Nombre: " + cuenta.Nombre);
            RlistBox.Items.Add("Cuenta de Banco: " + cuenta.NumeroCuenta);
            RlistBox.Items.Add("Dinero en ella: " + cuenta.Dinero);

            NombretextBox.Clear();
            DinerotextBox.Clear();
            NumeroCuentatextBox.Clear();
        }
    }
}
