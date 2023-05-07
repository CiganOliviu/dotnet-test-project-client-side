namespace WindowClientSide
{
    partial class Form2
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
            this.Projects = new System.Windows.Forms.Label();
            this.projectsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Projects
            // 
            this.Projects.AutoSize = true;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.Location = new System.Drawing.Point(326, 54);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(101, 29);
            this.Projects.TabIndex = 0;
            this.Projects.Text = "Projects";
            // 
            // projectsListBox
            // 
            this.projectsListBox.FormattingEnabled = true;
            this.projectsListBox.ItemHeight = 16;
            this.projectsListBox.Location = new System.Drawing.Point(253, 113);
            this.projectsListBox.Name = "projectsListBox";
            this.projectsListBox.Size = new System.Drawing.Size(275, 292);
            this.projectsListBox.TabIndex = 1;
            this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectsListBox);
            this.Controls.Add(this.Projects);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Projects;
        private System.Windows.Forms.ListBox projectsListBox;
    }
}