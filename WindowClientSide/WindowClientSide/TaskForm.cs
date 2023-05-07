using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class TaskForm : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public TaskForm()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void addTaskButtonInput_Click(object sender, EventArgs e)
        {
            service.AddDataInTaskTable(
                int.Parse(taskIdInputbox.Text),
                taskTitleBox.Text, 
                taskShortDescriptionBox.Text, 
                int.Parse(taskReporterBox.Text), 
                int.Parse(taskResponsibleBox.Text), 
                int.Parse(taskSprintBox.Text), 
                taskEstimationBox.Text, 
                taskPriorityBox.Text, 
                taskStatusBox.Text, 
                taskLabelsBox.Text, 
                int.Parse(taskProjectBox.Text)
            );
            this.Close();
        }
    }
}
