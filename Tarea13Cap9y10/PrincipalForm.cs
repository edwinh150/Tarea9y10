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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void capitulo9ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capitulos9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cap9e1Form Cap91 = new Cap9e1Form();

            Cap91.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Cap9e2Form Cap92 = new Cap9e2Form();

            Cap92.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cap9e3Form Cap93 = new Cap9e3Form();

            Cap93.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Cap9e4Form Cap94 = new Cap9e4Form();

            Cap94.Show();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cap10e1Form Cap101 = new Cap10e1Form();

            Cap101.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Cap10e2Form Cap102 = new Cap10e2Form();

            Cap102.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cap9e5Form Cap95 = new Cap9e5Form();

            Cap95.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Cap10e3Form Cap103 = new Cap10e3Form();

            Cap103.Show();
        }
    }
}
