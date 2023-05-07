using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class Form3 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public Form3()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.AddDataInProjectTable(int.Parse(projectIdBoxInput.Text), projectNameBoxInput.Text);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
