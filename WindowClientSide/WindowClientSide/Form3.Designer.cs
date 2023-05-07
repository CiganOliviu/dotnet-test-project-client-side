namespace WindowClientSide
{
    partial class Form3
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
            this.projectNameBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.projectIdBoxInput = new System.Windows.Forms.TextBox();
            this.projectIdInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Projects
            // 
            this.Projects.AutoSize = true;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.Location = new System.Drawing.Point(179, 42);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(138, 29);
            this.Projects.TabIndex = 1;
            this.Projects.Text = "Add Project";
            // 
            // projectNameBoxInput
            // 
            this.projectNameBoxInput.Location = new System.Drawing.Point(153, 224);
            this.projectNameBoxInput.Name = "projectNameBoxInput";
            this.projectNameBoxInput.Size = new System.Drawing.Size(199, 22);
            this.projectNameBoxInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "project name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectIdBoxInput
            // 
            this.projectIdBoxInput.Location = new System.Drawing.Point(153, 155);
            this.projectIdBoxInput.Name = "projectIdBoxInput";
            this.projectIdBoxInput.Size = new System.Drawing.Size(199, 22);
            this.projectIdBoxInput.TabIndex = 5;
            // 
            // projectIdInput
            // 
            this.projectIdInput.AutoSize = true;
            this.projectIdInput.Location = new System.Drawing.Point(150, 124);
            this.projectIdInput.Name = "projectIdInput";
            this.projectIdInput.Size = new System.Drawing.Size(78, 20);
            this.projectIdInput.TabIndex = 6;
            this.projectIdInput.Text = "project id";
            this.projectIdInput.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 363);
            this.Controls.Add(this.projectIdInput);
            this.Controls.Add(this.projectIdBoxInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameBoxInput);
            this.Controls.Add(this.Projects);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Projects;
        private System.Windows.Forms.TextBox projectNameBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox projectIdBoxInput;
        private System.Windows.Forms.Label projectIdInput;
    }
}