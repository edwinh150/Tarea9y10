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
    public partial class Cap9e5Form : Form
    {
        enum Estrellas { EnanaBlanca = 1, EnanaRoja = 2, SuperGigante = 3, ProtoEstrella = 4, EstrellaTtauri = 5, EstrellaSecuenciaPrincipal = 6, GiganteRoja = 7 };

        public Cap9e5Form()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estrellas tipos = Estrellas.EnanaBlanca;

            ResultadotextBox.Text = tipos.ToString();
            
        }
    }
}
