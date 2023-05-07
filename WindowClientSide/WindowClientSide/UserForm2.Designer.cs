namespace WindowClientSide
{
    partial class UserForm2
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
            this.deleteSprintByName = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.Projects = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteSprintByName
            // 
            this.deleteSprintByName.Location = new System.Drawing.Point(341, 396);
            this.deleteSprintByName.Name = "deleteSprintByName";
            this.deleteSprintByName.Size = new System.Drawing.Size(130, 35);
            this.deleteSprintByName.TabIndex = 8;
            this.deleteSprintByName.Text = "Delete User";
            this.deleteSprintByName.UseVisualStyleBackColor = true;
            this.deleteSprintByName.Click += new System.EventHandler(this.deleteSprintByName_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 16;
            this.usersListBox.Location = new System.Drawing.Point(263, 71);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(275, 292);
            this.usersListBox.TabIndex = 7;
            // 
            // Projects
            // 
            this.Projects.AutoSize = true;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.Location = new System.Drawing.Point(352, 19);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(95, 36);
            this.Projects.TabIndex = 6;
            this.Projects.Text = "Users";
            // 
            // UserForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteSprintByName);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.Projects);
            this.Name = "UserForm2";
            this.Text = "UserForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteSprintByName;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label Projects;
    }
}