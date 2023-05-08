using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class Form4 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public Form4()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.UpdateDataInProjectTable(int.Parse(identifyProjectIdBoxInput.Text), newProjectNameBoxInput.Text);
            this.Close();
        }
    }
}
