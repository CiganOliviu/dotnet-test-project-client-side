using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class SprintForm3 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public SprintForm3()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.UpdateDataInSprintTable(int.Parse(sprintIdUpdateBox.Text), sprintNameUpdateBox.Text, sprintPeriodUpdateBox.Text, sprintPiUpdateBox.Text);
            this.Close();
        }
    }
}
