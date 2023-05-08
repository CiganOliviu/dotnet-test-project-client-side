namespace WindowClientSide
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openColumn = new System.Windows.Forms.ListBox();
            this.openLabel = new System.Windows.Forms.Label();
            this.progressColumn = new System.Windows.Forms.ListBox();
            this.blockedColumn = new System.Windows.Forms.ListBox();
            this.codeReviewColumn = new System.Windows.Forms.ListBox();
            this.qaColumn = new System.Windows.Forms.ListBox();
            this.closedColumn = new System.Windows.Forms.ListBox();
            this.inProgressLabel = new System.Windows.Forms.Label();
            this.blockedLabel = new System.Windows.Forms.Label();
            this.codeReviewLabel = new System.Windows.Forms.Label();
            this.qaLabel = new System.Windows.Forms.Label();
            this.closedLabel = new System.Windows.Forms.Label();
            this.labelTaskDetails = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estimationBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelsBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.createdAtBox = new System.Windows.Forms.TextBox();
            this.reporterLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.roleResponsibleBox = new System.Windows.Forms.TextBox();
            this.emailResponsibleBox = new System.Windows.Forms.TextBox();
            this.lastNameResponsibleBox = new System.Windows.Forms.TextBox();
            this.firstNameResponsibleBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sprintNameBox = new System.Windows.Forms.TextBox();
            this.sprintPeriodBox = new System.Windows.Forms.TextBox();
            this.sprintProductIncrementVersion = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySprintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.updateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openColumn
            // 
            this.openColumn.FormattingEnabled = true;
            this.openColumn.ItemHeight = 16;
            this.openColumn.Location = new System.Drawing.Point(22, 149);
            this.openColumn.Name = "openColumn";
            this.openColumn.Size = new System.Drawing.Size(197, 260);
            this.openColumn.TabIndex = 0;
            this.openColumn.SelectedIndexChanged += new System.EventHandler(this.openColumn_SelectedIndexChanged);
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLabel.Location = new System.Drawing.Point(62, 99);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(73, 29);
            this.openLabel.TabIndex = 1;
            this.openLabel.Text = "Open";
            // 
            // progressColumn
            // 
            this.progressColumn.FormattingEnabled = true;
            this.progressColumn.ItemHeight = 16;
            this.progressColumn.Location = new System.Drawing.Point(287, 149);
            this.progressColumn.Name = "progressColumn";
            this.progressColumn.Size = new System.Drawing.Size(197, 260);
            this.progressColumn.TabIndex = 2;
            this.progressColumn.SelectedIndexChanged += new System.EventHandler(this.progressColumn_SelectedIndexChanged);
            // 
            // blockedColumn
            // 
            this.blockedColumn.FormattingEnabled = true;
            this.blockedColumn.ItemHeight = 16;
            this.blockedColumn.Location = new System.Drawing.Point(546, 149);
            this.blockedColumn.Name = "blockedColumn";
            this.blockedColumn.Size = new System.Drawing.Size(197, 260);
            this.blockedColumn.TabIndex = 3;
            this.blockedColumn.SelectedIndexChanged += new System.EventHandler(this.blockedColumn_SelectedIndexChanged);
            // 
            // codeReviewColumn
            // 
            this.codeReviewColumn.FormattingEnabled = true;
            this.codeReviewColumn.ItemHeight = 16;
            this.codeReviewColumn.Location = new System.Drawing.Point(810, 149);
            this.codeReviewColumn.Name = "codeReviewColumn";
            this.codeReviewColumn.Size = new System.Drawing.Size(197, 260);
            this.codeReviewColumn.TabIndex = 4;
            this.codeReviewColumn.SelectedIndexChanged += new System.EventHandler(this.codeReviewColumn_SelectedIndexChanged);
            // 
            // qaColumn
            // 
            this.qaColumn.FormattingEnabled = true;
            this.qaColumn.ItemHeight = 16;
            this.qaColumn.Location = new System.Drawing.Point(1062, 149);
            this.qaColumn.Name = "qaColumn";
            this.qaColumn.Size = new System.Drawing.Size(197, 260);
            this.qaColumn.TabIndex = 5;
            this.qaColumn.SelectedIndexChanged += new System.EventHandler(this.qaColumn_SelectedIndexChanged);
            // 
            // closedColumn
            // 
            this.closedColumn.FormattingEnabled = true;
            this.closedColumn.ItemHeight = 16;
            this.closedColumn.Location = new System.Drawing.Point(1320, 149);
            this.closedColumn.Name = "closedColumn";
            this.closedColumn.Size = new System.Drawing.Size(197, 260);
            this.closedColumn.TabIndex = 6;
            this.closedColumn.SelectedIndexChanged += new System.EventHandler(this.closedColumn_SelectedIndexChanged);
            // 
            // inProgressLabel
            // 
            this.inProgressLabel.AutoSize = true;
            this.inProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressLabel.Location = new System.Drawing.Point(300, 99);
            this.inProgressLabel.Name = "inProgressLabel";
            this.inProgressLabel.Size = new System.Drawing.Size(136, 29);
            this.inProgressLabel.TabIndex = 7;
            this.inProgressLabel.Text = "In Progress";
            // 
            // blockedLabel
            // 
            this.blockedLabel.AutoSize = true;
            this.blockedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockedLabel.Location = new System.Drawing.Point(585, 99);
            this.blockedLabel.Name = "blockedLabel";
            this.blockedLabel.Size = new System.Drawing.Size(101, 29);
            this.blockedLabel.TabIndex = 8;
            this.blockedLabel.Text = "Blocked";
            // 
            // codeReviewLabel
            // 
            this.codeReviewLabel.AutoSize = true;
            this.codeReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeReviewLabel.Location = new System.Drawing.Point(830, 99);
            this.codeReviewLabel.Name = "codeReviewLabel";
            this.codeReviewLabel.Size = new System.Drawing.Size(158, 29);
            this.codeReviewLabel.TabIndex = 9;
            this.codeReviewLabel.Text = "Code Review";
            // 
            // qaLabel
            // 
            this.qaLabel.AutoSize = true;
            this.qaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qaLabel.Location = new System.Drawing.Point(1132, 99);
            this.qaLabel.Name = "qaLabel";
            this.qaLabel.Size = new System.Drawing.Size(47, 29);
            this.qaLabel.TabIndex = 10;
            this.qaLabel.Text = "QA";
            // 
            // closedLabel
            // 
            this.closedLabel.AutoSize = true;
            this.closedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedLabel.Location = new System.Drawing.Point(1385, 99);
            this.closedLabel.Name = "closedLabel";
            this.closedLabel.Size = new System.Drawing.Size(90, 29);
            this.closedLabel.TabIndex = 11;
            this.closedLabel.Text = "Closed";
            // 
            // labelTaskDetails
            // 
            this.labelTaskDetails.AutoSize = true;
            this.labelTaskDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskDetails.Location = new System.Drawing.Point(62, 524);
            this.labelTaskDetails.Name = "labelTaskDetails";
            this.labelTaskDetails.Size = new System.Drawing.Size(146, 29);
            this.labelTaskDetails.TabIndex = 12;
            this.labelTaskDetails.Text = "Task Details";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(153, 590);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(149, 22);
            this.titleBox.TabIndex = 13;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(153, 638);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(149, 22);
            this.descriptionBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 684);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estimation";
            // 
            // estimationBox
            // 
            this.estimationBox.Location = new System.Drawing.Point(153, 684);
            this.estimationBox.Name = "estimationBox";
            this.estimationBox.Size = new System.Drawing.Size(149, 22);
            this.estimationBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 734);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Priority";
            // 
            // priorityBox
            // 
            this.priorityBox.Location = new System.Drawing.Point(153, 732);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(149, 22);
            this.priorityBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 785);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Status";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(153, 788);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(149, 22);
            this.statusBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 838);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Labels";
            // 
            // labelsBox
            // 
            this.labelsBox.Location = new System.Drawing.Point(153, 838);
            this.labelsBox.Name = "labelsBox";
            this.labelsBox.Size = new System.Drawing.Size(149, 22);
            this.labelsBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 894);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Created At";
            // 
            // createdAtBox
            // 
            this.createdAtBox.Location = new System.Drawing.Point(153, 892);
            this.createdAtBox.Name = "createdAtBox";
            this.createdAtBox.Size = new System.Drawing.Size(149, 22);
            this.createdAtBox.TabIndex = 25;
            // 
            // reporterLabel
            // 
            this.reporterLabel.AutoSize = true;
            this.reporterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporterLabel.Location = new System.Drawing.Point(516, 578);
            this.reporterLabel.Name = "reporterLabel";
            this.reporterLabel.Size = new System.Drawing.Size(74, 20);
            this.reporterLabel.TabIndex = 27;
            this.reporterLabel.Text = "Reporter";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(537, 634);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(149, 22);
            this.firstNameBox.TabIndex = 28;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(537, 682);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(149, 22);
            this.lastNameBox.TabIndex = 29;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(537, 729);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(149, 22);
            this.emailBox.TabIndex = 30;
            // 
            // roleBox
            // 
            this.roleBox.Location = new System.Drawing.Point(537, 782);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(149, 22);
            this.roleBox.TabIndex = 31;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(416, 634);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(92, 20);
            this.firstNameLabel.TabIndex = 32;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(416, 682);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(91, 20);
            this.lastNameLabel.TabIndex = 33;
            this.lastNameLabel.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 729);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(441, 784);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(765, 784);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(757, 729);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(740, 682);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(740, 634);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "First Name";
            // 
            // roleResponsibleBox
            // 
            this.roleResponsibleBox.Location = new System.Drawing.Point(861, 782);
            this.roleResponsibleBox.Name = "roleResponsibleBox";
            this.roleResponsibleBox.Size = new System.Drawing.Size(149, 22);
            this.roleResponsibleBox.TabIndex = 40;
            // 
            // emailResponsibleBox
            // 
            this.emailResponsibleBox.Location = new System.Drawing.Point(861, 729);
            this.emailResponsibleBox.Name = "emailResponsibleBox";
            this.emailResponsibleBox.Size = new System.Drawing.Size(149, 22);
            this.emailResponsibleBox.TabIndex = 39;
            // 
            // lastNameResponsibleBox
            // 
            this.lastNameResponsibleBox.Location = new System.Drawing.Point(861, 682);
            this.lastNameResponsibleBox.Name = "lastNameResponsibleBox";
            this.lastNameResponsibleBox.Size = new System.Drawing.Size(149, 22);
            this.lastNameResponsibleBox.TabIndex = 38;
            // 
            // firstNameResponsibleBox
            // 
            this.firstNameResponsibleBox.Location = new System.Drawing.Point(861, 634);
            this.firstNameResponsibleBox.Name = "firstNameResponsibleBox";
            this.firstNameResponsibleBox.Size = new System.Drawing.Size(149, 22);
            this.firstNameResponsibleBox.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(840, 578);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Responsible";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1099, 578);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "Project";
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(1062, 632);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(149, 22);
            this.ProjectName.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1344, 578);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 47;
            this.label16.Text = "Sprint";
            // 
            // sprintNameBox
            // 
            this.sprintNameBox.Location = new System.Drawing.Point(1299, 632);
            this.sprintNameBox.Name = "sprintNameBox";
            this.sprintNameBox.Size = new System.Drawing.Size(149, 22);
            this.sprintNameBox.TabIndex = 48;
            // 
            // sprintPeriodBox
            // 
            this.sprintPeriodBox.Location = new System.Drawing.Point(1299, 682);
            this.sprintPeriodBox.Name = "sprintPeriodBox";
            this.sprintPeriodBox.Size = new System.Drawing.Size(149, 22);
            this.sprintPeriodBox.TabIndex = 49;
            // 
            // sprintProductIncrementVersion
            // 
            this.sprintProductIncrementVersion.Location = new System.Drawing.Point(1299, 734);
            this.sprintProductIncrementVersion.Name = "sprintProductIncrementVersion";
            this.sprintProductIncrementVersion.Size = new System.Drawing.Size(149, 22);
            this.sprintProductIncrementVersion.TabIndex = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.sprintsToolStripMenuItem,
            this.allTasksToolStripMenuItem,
            this.allUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1531, 28);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.displayProjectsToolStripMenuItem,
            this.updateProjectToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // displayProjectsToolStripMenuItem
            // 
            this.displayProjectsToolStripMenuItem.Name = "displayProjectsToolStripMenuItem";
            this.displayProjectsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.displayProjectsToolStripMenuItem.Text = "Display Projects";
            this.displayProjectsToolStripMenuItem.Click += new System.EventHandler(this.displayProjectsToolStripMenuItem_Click);
            // 
            // sprintsToolStripMenuItem
            // 
            this.sprintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSprintToolStripMenuItem,
            this.displaySprintsToolStripMenuItem});
            this.sprintsToolStripMenuItem.Name = "sprintsToolStripMenuItem";
            this.sprintsToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sprintsToolStripMenuItem.Text = "Sprints";
            this.sprintsToolStripMenuItem.Click += new System.EventHandler(this.sprintsToolStripMenuItem_Click);
            // 
            // addSprintToolStripMenuItem
            // 
            this.addSprintToolStripMenuItem.Name = "addSprintToolStripMenuItem";
            this.addSprintToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.addSprintToolStripMenuItem.Text = "Add Sprint";
            this.addSprintToolStripMenuItem.Click += new System.EventHandler(this.addSprintToolStripMenuItem_Click);
            // 
            // displaySprintsToolStripMenuItem
            // 
            this.displaySprintsToolStripMenuItem.Name = "displaySprintsToolStripMenuItem";
            this.displaySprintsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.displaySprintsToolStripMenuItem.Text = "Display Sprints";
            this.displaySprintsToolStripMenuItem.Click += new System.EventHandler(this.displaySprintsToolStripMenuItem_Click);
            // 
            // allTasksToolStripMenuItem
            // 
            this.allTasksToolStripMenuItem.Name = "allTasksToolStripMenuItem";
            this.allTasksToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.allTasksToolStripMenuItem.Text = "Add Task";
            this.allTasksToolStripMenuItem.Click += new System.EventHandler(this.allTasksToolStripMenuItem_Click);
            // 
            // allUsersToolStripMenuItem
            // 
            this.allUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.displayUsersToolStripMenuItem});
            this.allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            this.allUsersToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.allUsersToolStripMenuItem.Text = "All Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // displayUsersToolStripMenuItem
            // 
            this.displayUsersToolStripMenuItem.Name = "displayUsersToolStripMenuItem";
            this.displayUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.displayUsersToolStripMenuItem.Text = "Display Users";
            this.displayUsersToolStripMenuItem.Click += new System.EventHandler(this.displayUsersToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Clear Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateProjectToolStripMenuItem
            // 
            this.updateProjectToolStripMenuItem.Name = "updateProjectToolStripMenuItem";
            this.updateProjectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateProjectToolStripMenuItem.Text = "Update Project";
            this.updateProjectToolStripMenuItem.Click += new System.EventHandler(this.updateProjectToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 1026);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sprintProductIncrementVersion);
            this.Controls.Add(this.sprintPeriodBox);
            this.Controls.Add(this.sprintNameBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.roleResponsibleBox);
            this.Controls.Add(this.emailResponsibleBox);
            this.Controls.Add(this.lastNameResponsibleBox);
            this.Controls.Add(this.firstNameResponsibleBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.reporterLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.createdAtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estimationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.labelTaskDetails);
            this.Controls.Add(this.closedLabel);
            this.Controls.Add(this.qaLabel);
            this.Controls.Add(this.codeReviewLabel);
            this.Controls.Add(this.blockedLabel);
            this.Controls.Add(this.inProgressLabel);
            this.Controls.Add(this.closedColumn);
            this.Controls.Add(this.qaColumn);
            this.Controls.Add(this.codeReviewColumn);
            this.Controls.Add(this.blockedColumn);
            this.Controls.Add(this.progressColumn);
            this.Controls.Add(this.openLabel);
            this.Controls.Add(this.openColumn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox openColumn;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.ListBox progressColumn;
        private System.Windows.Forms.ListBox blockedColumn;
        private System.Windows.Forms.ListBox codeReviewColumn;
        private System.Windows.Forms.ListBox qaColumn;
        private System.Windows.Forms.ListBox closedColumn;
        private System.Windows.Forms.Label inProgressLabel;
        private System.Windows.Forms.Label blockedLabel;
        private System.Windows.Forms.Label codeReviewLabel;
        private System.Windows.Forms.Label qaLabel;
        private System.Windows.Forms.Label closedLabel;
        private System.Windows.Forms.Label labelTaskDetails;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox estimationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priorityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox labelsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox createdAtBox;
        private System.Windows.Forms.Label reporterLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox roleBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox roleResponsibleBox;
        private System.Windows.Forms.TextBox emailResponsibleBox;
        private System.Windows.Forms.TextBox lastNameResponsibleBox;
        private System.Windows.Forms.TextBox firstNameResponsibleBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox sprintNameBox;
        private System.Windows.Forms.TextBox sprintPeriodBox;
        private System.Windows.Forms.TextBox sprintProductIncrementVersion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySprintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayUsersToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem updateProjectToolStripMenuItem;
    }
}

