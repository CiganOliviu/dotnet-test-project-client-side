using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class UserForm1 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public UserForm1()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void userAdd_Click(object sender, EventArgs e)
        {
            service.AddDataInUserTable(int.Parse(userIdBoxInput.Text), userFirstNameBoxInput.Text, userLastNameBoxInput.Text, userEmailBoxInput.Text, userRoleBoxInput.Text);
            this.Close();
        }
    }
}
