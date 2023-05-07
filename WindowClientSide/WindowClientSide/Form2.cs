using System;
using System.Collections;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class Form2 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public Form2()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();

            foreach (string item in service.GetAllProjectsByName())
            {
                projectsListBox.Items.Add(item);
            }
        }

        private void projectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
