using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class UpdateTaskForm : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public UpdateTaskForm()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void addTaskButtonInput_Click(object sender, EventArgs e)
        {
            service.UpdateDataInTaskTable(int.Parse(updateTaskIdInputbox.Text), updateTaskTitleBox.Text, updateTaskShortDescriptionBox.Text, int.Parse(updateTaskReporterBox.Text),
                int.Parse(updateTaskResponsibleBox.Text), int.Parse(updateTaskSprintBox.Text), updateTaskEstimationBox.Text, updateTaskPriorityBox.Text, updateTaskStatusBox.Text,
                updateTaskLabelsBox.Text, int.Parse(updateTaskProjectBox.Text));
            this.Close();
        }
    }
}
