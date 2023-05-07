using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class UserForm2 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public UserForm2()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();

            foreach (string item in service.GetAllUsersByEmail())
            {
                usersListBox.Items.Add(item);
            }
        }

        private void deleteSprintByName_Click(object sender, EventArgs e)
        {
            var selectedItem = usersListBox.SelectedItem.ToString();
            service.DeleteDataInUserTableByEmail(selectedItem);

            usersListBox.Items.Remove(selectedItem);
        }
    }
}
