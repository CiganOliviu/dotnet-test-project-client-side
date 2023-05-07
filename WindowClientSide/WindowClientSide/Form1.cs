using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 projectsForm = new Form2();
            projectsForm.Show();
        }
    }
}
