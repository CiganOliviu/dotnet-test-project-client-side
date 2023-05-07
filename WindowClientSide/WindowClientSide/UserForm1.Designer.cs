namespace WindowClientSide
{
    partial class UserForm1
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
            this.label3 = new System.Windows.Forms.Label();
            this.userEmailBoxInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userLastNameBoxInput = new System.Windows.Forms.TextBox();
            this.sprintIdInput = new System.Windows.Forms.Label();
            this.userIdBoxInput = new System.Windows.Forms.TextBox();
            this.userAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userFirstNameBoxInput = new System.Windows.Forms.TextBox();
            this.Sprints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userRoleBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "email";
            // 
            // userEmailBoxInput
            // 
            this.userEmailBoxInput.Location = new System.Drawing.Point(294, 412);
            this.userEmailBoxInput.Name = "userEmailBoxInput";
            this.userEmailBoxInput.Size = new System.Drawing.Size(199, 22);
            this.userEmailBoxInput.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "last name";
            // 
            // userLastNameBoxInput
            // 
            this.userLastNameBoxInput.Location = new System.Drawing.Point(294, 331);
            this.userLastNameBoxInput.Name = "userLastNameBoxInput";
            this.userLastNameBoxInput.Size = new System.Drawing.Size(199, 22);
            this.userLastNameBoxInput.TabIndex = 23;
            // 
            // sprintIdInput
            // 
            this.sprintIdInput.AutoSize = true;
            this.sprintIdInput.Location = new System.Drawing.Point(291, 151);
            this.sprintIdInput.Name = "sprintIdInput";
            this.sprintIdInput.Size = new System.Drawing.Size(59, 20);
            this.sprintIdInput.TabIndex = 22;
            this.sprintIdInput.Text = "user id";
            // 
            // userIdBoxInput
            // 
            this.userIdBoxInput.Location = new System.Drawing.Point(294, 182);
            this.userIdBoxInput.Name = "userIdBoxInput";
            this.userIdBoxInput.Size = new System.Drawing.Size(199, 22);
            this.userIdBoxInput.TabIndex = 21;
            // 
            // userAdd
            // 
            this.userAdd.Location = new System.Drawing.Point(325, 571);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(114, 32);
            this.userAdd.TabIndex = 20;
            this.userAdd.Text = "Add";
            this.userAdd.UseVisualStyleBackColor = true;
            this.userAdd.Click += new System.EventHandler(this.userAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "first name";
            // 
            // userFirstNameBoxInput
            // 
            this.userFirstNameBoxInput.Location = new System.Drawing.Point(294, 251);
            this.userFirstNameBoxInput.Name = "userFirstNameBoxInput";
            this.userFirstNameBoxInput.Size = new System.Drawing.Size(199, 22);
            this.userFirstNameBoxInput.TabIndex = 18;
            // 
            // Sprints
            // 
            this.Sprints.AutoSize = true;
            this.Sprints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprints.Location = new System.Drawing.Point(320, 69);
            this.Sprints.Name = "Sprints";
            this.Sprints.Size = new System.Drawing.Size(141, 36);
            this.Sprints.TabIndex = 17;
            this.Sprints.Text = "Add User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "role";
            // 
            // userRoleBoxInput
            // 
            this.userRoleBoxInput.Location = new System.Drawing.Point(294, 493);
            this.userRoleBoxInput.Name = "userRoleBoxInput";
            this.userRoleBoxInput.Size = new System.Drawing.Size(199, 22);
            this.userRoleBoxInput.TabIndex = 27;
            // 
            // UserForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 667);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userRoleBoxInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userEmailBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userLastNameBoxInput);
            this.Controls.Add(this.sprintIdInput);
            this.Controls.Add(this.userIdBoxInput);
            this.Controls.Add(this.userAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userFirstNameBoxInput);
            this.Controls.Add(this.Sprints);
            this.Name = "UserForm1";
            this.Text = "UserForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userEmailBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userLastNameBoxInput;
        private System.Windows.Forms.Label sprintIdInput;
        private System.Windows.Forms.TextBox userIdBoxInput;
        private System.Windows.Forms.Button userAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userFirstNameBoxInput;
        private System.Windows.Forms.Label Sprints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userRoleBoxInput;
    }
}