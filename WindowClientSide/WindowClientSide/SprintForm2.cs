using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class SprintForm2 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public SprintForm2()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();

            foreach (string item in service.GetAllProjectsByName())
            {
                sprintsListBox.Items.Add(item);
            }
        }

        private void deleteProjectByName_Click(object sender, EventArgs e)
        {
            var selectedItem = sprintsListBox.SelectedItem.ToString();
            service.DeleteDataInSprintTableByName(selectedItem);

            sprintsListBox.Items.Remove(selectedItem);
        }
    }
}
