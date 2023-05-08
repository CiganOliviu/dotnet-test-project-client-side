namespace WindowClientSide
{
    partial class Form4
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
            this.projectIdInput = new System.Windows.Forms.Label();
            this.identifyProjectIdBoxInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newProjectNameBoxInput = new System.Windows.Forms.TextBox();
            this.Projects = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newProjectIdInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // projectIdInput
            // 
            this.projectIdInput.AutoSize = true;
            this.projectIdInput.Location = new System.Drawing.Point(200, 170);
            this.projectIdInput.Name = "projectIdInput";
            this.projectIdInput.Size = new System.Drawing.Size(107, 16);
            this.projectIdInput.TabIndex = 12;
            this.projectIdInput.Text = "identify project id";
            // 
            // identifyProjectIdBoxInput
            // 
            this.identifyProjectIdBoxInput.Location = new System.Drawing.Point(203, 201);
            this.identifyProjectIdBoxInput.Name = "identifyProjectIdBoxInput";
            this.identifyProjectIdBoxInput.Size = new System.Drawing.Size(199, 22);
            this.identifyProjectIdBoxInput.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "new project name";
            // 
            // newProjectNameBoxInput
            // 
            this.newProjectNameBoxInput.Location = new System.Drawing.Point(203, 354);
            this.newProjectNameBoxInput.Name = "newProjectNameBoxInput";
            this.newProjectNameBoxInput.Size = new System.Drawing.Size(199, 22);
            this.newProjectNameBoxInput.TabIndex = 8;
            // 
            // Projects
            // 
            this.Projects.AutoSize = true;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.Location = new System.Drawing.Point(229, 88);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(173, 29);
            this.Projects.TabIndex = 7;
            this.Projects.Text = "Update Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "new project id";
            // 
            // newProjectIdInputBox
            // 
            this.newProjectIdInputBox.Location = new System.Drawing.Point(203, 284);
            this.newProjectIdInputBox.Name = "newProjectIdInputBox";
            this.newProjectIdInputBox.Size = new System.Drawing.Size(199, 22);
            this.newProjectIdInputBox.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newProjectIdInputBox);
            this.Controls.Add(this.projectIdInput);
            this.Controls.Add(this.identifyProjectIdBoxInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProjectNameBoxInput);
            this.Controls.Add(this.Projects);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectIdInput;
        private System.Windows.Forms.TextBox identifyProjectIdBoxInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newProjectNameBoxInput;
        private System.Windows.Forms.Label Projects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newProjectIdInputBox;
    }
}