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
            var reporterBoxFallback = -1;
            var responsibleBoxFallback = -1;
            var sprintBoxFallback = -1;
            var projectBoxFallback = -1;

            if (updateTaskReporterBox.Text != "")
            {
                reporterBoxFallback = int.Parse(updateTaskReporterBox.Text);
            }

            if (updateTaskResponsibleBox.Text != "")
            {
                responsibleBoxFallback = int.Parse(updateTaskResponsibleBox.Text);
            }

            if (updateTaskResponsibleBox.Text != "")
            {
                sprintBoxFallback = int.Parse(updateTaskResponsibleBox.Text);
            }
            
            if (updateTaskProjectBox.Text != "")
            {
                projectBoxFallback = int.Parse(updateTaskProjectBox.Text);
            }

            service.UpdateDataInTaskTable(int.Parse(updateTaskIdInputbox.Text), updateTaskTitleBox.Text, updateTaskShortDescriptionBox.Text, reporterBoxFallback,
                responsibleBoxFallback, sprintBoxFallback, updateTaskEstimationBox.Text, updateTaskPriorityBox.Text, updateTaskStatusBox.Text,
                updateTaskLabelsBox.Text, projectBoxFallback);

            this.Close();
        }
    }
}
