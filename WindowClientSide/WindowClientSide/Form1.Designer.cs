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
            // 
            // blockedColumn
            // 
            this.blockedColumn.FormattingEnabled = true;
            this.blockedColumn.ItemHeight = 16;
            this.blockedColumn.Location = new System.Drawing.Point(546, 149);
            this.blockedColumn.Name = "blockedColumn";
            this.blockedColumn.Size = new System.Drawing.Size(197, 260);
            this.blockedColumn.TabIndex = 3;
            // 
            // codeReviewColumn
            // 
            this.codeReviewColumn.FormattingEnabled = true;
            this.codeReviewColumn.ItemHeight = 16;
            this.codeReviewColumn.Location = new System.Drawing.Point(810, 149);
            this.codeReviewColumn.Name = "codeReviewColumn";
            this.codeReviewColumn.Size = new System.Drawing.Size(197, 260);
            this.codeReviewColumn.TabIndex = 4;
            // 
            // qaColumn
            // 
            this.qaColumn.FormattingEnabled = true;
            this.qaColumn.ItemHeight = 16;
            this.qaColumn.Location = new System.Drawing.Point(1062, 149);
            this.qaColumn.Name = "qaColumn";
            this.qaColumn.Size = new System.Drawing.Size(197, 260);
            this.qaColumn.TabIndex = 5;
            // 
            // closedColumn
            // 
            this.closedColumn.FormattingEnabled = true;
            this.closedColumn.ItemHeight = 16;
            this.closedColumn.Location = new System.Drawing.Point(1320, 149);
            this.closedColumn.Name = "closedColumn";
            this.closedColumn.Size = new System.Drawing.Size(197, 260);
            this.closedColumn.TabIndex = 6;
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
            this.labelTaskDetails.Size = new System.Drawing.Size(183, 36);
            this.labelTaskDetails.TabIndex = 12;
            this.labelTaskDetails.Text = "Task Details";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(153, 590);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(149, 22);
            this.titleBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 1026);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

