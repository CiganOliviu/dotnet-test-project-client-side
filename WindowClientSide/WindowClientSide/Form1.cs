using System;
using System.Windows.Forms;

namespace WindowClientSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
