namespace WindowClientSide
{
    partial class SprintForm2
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
            this.deleteProjectByName = new System.Windows.Forms.Button();
            this.sprintsListBox = new System.Windows.Forms.ListBox();
            this.Projects = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteProjectByName
            // 
            this.deleteProjectByName.Location = new System.Drawing.Point(341, 400);
            this.deleteProjectByName.Name = "deleteProjectByName";
            this.deleteProjectByName.Size = new System.Drawing.Size(130, 35);
            this.deleteProjectByName.TabIndex = 5;
            this.deleteProjectByName.Text = "Delete Project";
            this.deleteProjectByName.UseVisualStyleBackColor = true;
            this.deleteProjectByName.Click += new System.EventHandler(this.deleteProjectByName_Click);
            // 
            // sprintsListBox
            // 
            this.sprintsListBox.FormattingEnabled = true;
            this.sprintsListBox.ItemHeight = 16;
            this.sprintsListBox.Location = new System.Drawing.Point(263, 75);
            this.sprintsListBox.Name = "sprintsListBox";
            this.sprintsListBox.Size = new System.Drawing.Size(275, 292);
            this.sprintsListBox.TabIndex = 4;
            // 
            // Projects
            // 
            this.Projects.AutoSize = true;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.Location = new System.Drawing.Point(352, 23);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(110, 36);
            this.Projects.TabIndex = 3;
            this.Projects.Text = "Sprints";
            // 
            // SprintForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteProjectByName);
            this.Controls.Add(this.sprintsListBox);
            this.Controls.Add(this.Projects);
            this.Name = "SprintForm2";
            this.Text = "SprintForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteProjectByName;
        private System.Windows.Forms.ListBox sprintsListBox;
        private System.Windows.Forms.Label Projects;
    }
}