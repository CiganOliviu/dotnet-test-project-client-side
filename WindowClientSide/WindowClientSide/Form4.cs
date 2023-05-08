using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            service.UpdateDataInProjectTable(int.Parse(identifyProjectIdBoxInput.Text), int.Parse(newProjectIdInputBox.Text), newProjectNameBoxInput.Text);
            this.Close();
        }
    }
}
