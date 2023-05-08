namespace WindowClientSide
{
    partial class UserForm3
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
            this.label4 = new System.Windows.Forms.Label();
            this.userRoleUpdateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userEmailUpdateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userLastNameUpdateBox = new System.Windows.Forms.TextBox();
            this.sprintIdInput = new System.Windows.Forms.Label();
            this.userUpdateIdBox = new System.Windows.Forms.TextBox();
            this.userAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userFirstNameUpdateBox = new System.Windows.Forms.TextBox();
            this.Sprints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "role";
            // 
            // userRoleUpdateBox
            // 
            this.userRoleUpdateBox.Location = new System.Drawing.Point(281, 502);
            this.userRoleUpdateBox.Name = "userRoleUpdateBox";
            this.userRoleUpdateBox.Size = new System.Drawing.Size(199, 22);
            this.userRoleUpdateBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "email";
            // 
            // userEmailUpdateBox
            // 
            this.userEmailUpdateBox.Location = new System.Drawing.Point(281, 421);
            this.userEmailUpdateBox.Name = "userEmailUpdateBox";
            this.userEmailUpdateBox.Size = new System.Drawing.Size(199, 22);
            this.userEmailUpdateBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "last name";
            // 
            // userLastNameUpdateBox
            // 
            this.userLastNameUpdateBox.Location = new System.Drawing.Point(281, 340);
            this.userLastNameUpdateBox.Name = "userLastNameUpdateBox";
            this.userLastNameUpdateBox.Size = new System.Drawing.Size(199, 22);
            this.userLastNameUpdateBox.TabIndex = 35;
            // 
            // sprintIdInput
            // 
            this.sprintIdInput.AutoSize = true;
            this.sprintIdInput.Location = new System.Drawing.Point(278, 160);
            this.sprintIdInput.Name = "sprintIdInput";
            this.sprintIdInput.Size = new System.Drawing.Size(115, 20);
            this.sprintIdInput.TabIndex = 34;
            this.sprintIdInput.Text = "identify user id";
            // 
            // userUpdateIdBox
            // 
            this.userUpdateIdBox.Location = new System.Drawing.Point(281, 191);
            this.userUpdateIdBox.Name = "userUpdateIdBox";
            this.userUpdateIdBox.Size = new System.Drawing.Size(199, 22);
            this.userUpdateIdBox.TabIndex = 33;
            // 
            // userAdd
            // 
            this.userAdd.Location = new System.Drawing.Point(312, 580);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(114, 32);
            this.userAdd.TabIndex = 32;
            this.userAdd.Text = "Update";
            this.userAdd.UseVisualStyleBackColor = true;
            this.userAdd.Click += new System.EventHandler(this.userAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "first name";
            // 
            // userFirstNameUpdateBox
            // 
            this.userFirstNameUpdateBox.Location = new System.Drawing.Point(281, 260);
            this.userFirstNameUpdateBox.Name = "userFirstNameUpdateBox";
            this.userFirstNameUpdateBox.Size = new System.Drawing.Size(199, 22);
            this.userFirstNameUpdateBox.TabIndex = 30;
            // 
            // Sprints
            // 
            this.Sprints.AutoSize = true;
            this.Sprints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprints.Location = new System.Drawing.Point(307, 78);
            this.Sprints.Name = "Sprints";
            this.Sprints.Size = new System.Drawing.Size(185, 36);
            this.Sprints.TabIndex = 29;
            this.Sprints.Text = "Update User";
            // 
            // UserForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 743);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userRoleUpdateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userEmailUpdateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userLastNameUpdateBox);
            this.Controls.Add(this.sprintIdInput);
            this.Controls.Add(this.userUpdateIdBox);
            this.Controls.Add(this.userAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userFirstNameUpdateBox);
            this.Controls.Add(this.Sprints);
            this.Name = "UserForm3";
            this.Text = "UserForm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userRoleUpdateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userEmailUpdateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userLastNameUpdateBox;
        private System.Windows.Forms.Label sprintIdInput;
        private System.Windows.Forms.TextBox userUpdateIdBox;
        private System.Windows.Forms.Button userAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userFirstNameUpdateBox;
        private System.Windows.Forms.Label Sprints;
    }
}