using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class SprintsForm1 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public SprintsForm1()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.AddDataInSprinTableAsync(int.Parse(sprintIdBoxInput.Text), sprintNameBoxInput.Text, sprintPeriodInputBox.Text, sprintPiInputBox.Text);
            this.Close();
        }
    }
}
