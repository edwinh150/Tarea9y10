﻿using System;
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
    public partial class Cap10e5Form : Form
    {
        public Cap10e5Form()
        {
            InitializeComponent();
        }

        private void Mbutton_Click(object sender, EventArgs e)
        {
            Poligono poligono = new Poligono(Convert.ToDouble(NtextBox.Text));

            RtextBox.Text = poligono.CalcularP().ToString();
        }
    }
}
