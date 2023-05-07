﻿using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class Form1 : Form
    {
        public ServiceReference1.WebService1SoapClient service;

        public Form1()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();

            foreach (string item in service.GetAllTasksByStatus("Open"))
            {
                openColumn.Items.Add(item);
            }

            foreach (string item in service.GetAllTasksByStatus("InProgress"))
            {
                progressColumn.Items.Add(item);
            }

            foreach (string item in service.GetAllTasksByStatus("Blocked"))
            {
                blockedColumn.Items.Add(item);
            }

            foreach (string item in service.GetAllTasksByStatus("CodeReview"))
            {
                codeReviewColumn.Items.Add(item);
            }

            foreach (string item in service.GetAllTasksByStatus("QA"))
            {
                qaColumn.Items.Add(item);
            }

            foreach (string item in service.GetAllTasksByStatus("Closed"))
            {
                closedColumn.Items.Add(item);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            openColumn.ClearSelected();
            progressColumn.ClearSelected();
            blockedColumn.ClearSelected();
            codeReviewColumn.ClearSelected();
            qaColumn.ClearSelected();
            closedColumn.ClearSelected();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 projectsForm = new Form3();
            projectsForm.Show();
        }

        private void displayProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 projectsForm = new Form2();
            projectsForm.Show();
        }

        private void addSprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SprintsForm1 sprintsForm = new SprintsForm1();
            sprintsForm.Show();
        }

        private void displaySprintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SprintForm2 sprintsForm = new SprintForm2();
            sprintsForm.Show();
        }

        private void sprintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm1 usersForm = new UserForm1();
            usersForm.Show();
        }

        private void displayUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm2 usersForm = new UserForm2();
            usersForm.Show();
        }

        private void allTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.Show();
        }

        private void openColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTask = openColumn.SelectedItem.ToString();
            var taskInfo = service.GetAllTaskInfoByTitle(selectedTask);
            string[] splitInfo = taskInfo.Split('-');

            titleBox.Text = splitInfo[1];
            descriptionBox.Text = splitInfo[2];
            estimationBox.Text = splitInfo[6];
            priorityBox.Text = splitInfo[7];
            statusBox.Text = splitInfo[8];
            labelsBox.Text = splitInfo[9];
            createdAtBox.Text = splitInfo[10];

            var taskReporter = service.GetAllUserInfoById(int.Parse(splitInfo[3]));
            string[] splitTaskReporterInfo = taskReporter.Split('-');
            firstNameBox.Text = splitTaskReporterInfo[1];
            lastNameBox.Text = splitTaskReporterInfo[2];
            emailBox.Text = splitTaskReporterInfo[3];
            roleBox.Text = splitTaskReporterInfo[4];

            var taskResponsible = service.GetAllUserInfoById(int.Parse(splitInfo[4]));
            string[] splitTaskResponsibleInfo = taskResponsible.Split('-');
            firstNameResponsibleBox.Text = splitTaskResponsibleInfo[1];
            lastNameResponsibleBox.Text = splitTaskResponsibleInfo[2];
            emailResponsibleBox.Text = splitTaskResponsibleInfo[3];
            roleResponsibleBox.Text = splitTaskResponsibleInfo[4];

            var project = service.GetProjectInfoById(int.Parse(splitInfo[11]));
            string[] splitProjectInfo = project.Split('-');
            ProjectName.Text = splitProjectInfo[1];

            var sprint = service.GetSprintInfoById(int.Parse(splitInfo[5]));
            string[] splitSprintinfo = sprint.Split('-');
            sprintNameBox.Text = splitSprintinfo[1];    
            sprintPeriodBox .Text = splitSprintinfo[2];
            sprintProductIncrementVersion.Text = splitSprintinfo[3];
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
