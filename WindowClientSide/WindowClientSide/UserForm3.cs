using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class UserForm3 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public UserForm3()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void userAdd_Click(object sender, EventArgs e)
        {
            service.UpdateDataInUserTable(int.Parse(userUpdateIdBox.Text), userFirstNameUpdateBox.Text, userLastNameUpdateBox.Text, userEmailUpdateBox.Text, userRoleUpdateBox.Text);
            this.Close();
        }
    }
}
