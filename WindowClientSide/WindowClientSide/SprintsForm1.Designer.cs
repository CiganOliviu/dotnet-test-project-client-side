namespace WindowClientSide
{
    partial class SprintsForm1
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
            this.sprintIdInput = new System.Windows.Forms.Label();
            this.sprintIdBoxInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sprintNameBoxInput = new System.Windows.Forms.TextBox();
            this.Sprints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sprintPeriodInputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sprintPiInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sprintIdInput
            // 
            this.sprintIdInput.AutoSize = true;
            this.sprintIdInput.Location = new System.Drawing.Point(299, 173);
            this.sprintIdInput.Name = "sprintIdInput";
            this.sprintIdInput.Size = new System.Drawing.Size(66, 20);
            this.sprintIdInput.TabIndex = 12;
            this.sprintIdInput.Text = "sprint id";
            // 
            // sprintIdBoxInput
            // 
            this.sprintIdBoxInput.Location = new System.Drawing.Point(302, 204);
            this.sprintIdBoxInput.Name = "sprintIdBoxInput";
            this.sprintIdBoxInput.Size = new System.Drawing.Size(199, 22);
            this.sprintIdBoxInput.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "sprint name";
            // 
            // sprintNameBoxInput
            // 
            this.sprintNameBoxInput.Location = new System.Drawing.Point(302, 273);
            this.sprintNameBoxInput.Name = "sprintNameBoxInput";
            this.sprintNameBoxInput.Size = new System.Drawing.Size(199, 22);
            this.sprintNameBoxInput.TabIndex = 8;
            // 
            // Sprints
            // 
            this.Sprints.AutoSize = true;
            this.Sprints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprints.Location = new System.Drawing.Point(328, 91);
            this.Sprints.Name = "Sprints";
            this.Sprints.Size = new System.Drawing.Size(156, 36);
            this.Sprints.TabIndex = 7;
            this.Sprints.Text = "Add Sprint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "sprint period";
            // 
            // sprintPeriodInputBox
            // 
            this.sprintPeriodInputBox.Location = new System.Drawing.Point(302, 353);
            this.sprintPeriodInputBox.Name = "sprintPeriodInputBox";
            this.sprintPeriodInputBox.Size = new System.Drawing.Size(199, 22);
            this.sprintPeriodInputBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "sprint PI version";
            // 
            // sprintPiInputBox
            // 
            this.sprintPiInputBox.Location = new System.Drawing.Point(302, 434);
            this.sprintPiInputBox.Name = "sprintPiInputBox";
            this.sprintPiInputBox.Size = new System.Drawing.Size(199, 22);
            this.sprintPiInputBox.TabIndex = 15;
            // 
            // SprintsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sprintPiInputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sprintPeriodInputBox);
            this.Controls.Add(this.sprintIdInput);
            this.Controls.Add(this.sprintIdBoxInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sprintNameBoxInput);
            this.Controls.Add(this.Sprints);
            this.Name = "SprintsForm1";
            this.Text = "SprintsForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sprintIdInput;
        private System.Windows.Forms.TextBox sprintIdBoxInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sprintNameBoxInput;
        private System.Windows.Forms.Label Sprints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sprintPeriodInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sprintPiInputBox;
    }
}