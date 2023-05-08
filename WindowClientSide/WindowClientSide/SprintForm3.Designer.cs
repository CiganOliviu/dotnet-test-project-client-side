namespace WindowClientSide
{
    partial class SprintForm3
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
            this.sprintPiUpdateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sprintPeriodUpdateBox = new System.Windows.Forms.TextBox();
            this.sprintUpdateIdLabel = new System.Windows.Forms.Label();
            this.sprintIdUpdateBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sprintNameUpdateBox = new System.Windows.Forms.TextBox();
            this.Sprints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "sprint PI version";
            // 
            // sprintPiUpdateBox
            // 
            this.sprintPiUpdateBox.Location = new System.Drawing.Point(289, 435);
            this.sprintPiUpdateBox.Name = "sprintPiUpdateBox";
            this.sprintPiUpdateBox.Size = new System.Drawing.Size(199, 22);
            this.sprintPiUpdateBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "sprint period";
            // 
            // sprintPeriodUpdateBox
            // 
            this.sprintPeriodUpdateBox.Location = new System.Drawing.Point(289, 354);
            this.sprintPeriodUpdateBox.Name = "sprintPeriodUpdateBox";
            this.sprintPeriodUpdateBox.Size = new System.Drawing.Size(199, 22);
            this.sprintPeriodUpdateBox.TabIndex = 23;
            // 
            // sprintUpdateIdLabel
            // 
            this.sprintUpdateIdLabel.AutoSize = true;
            this.sprintUpdateIdLabel.Location = new System.Drawing.Point(286, 174);
            this.sprintUpdateIdLabel.Name = "sprintUpdateIdLabel";
            this.sprintUpdateIdLabel.Size = new System.Drawing.Size(123, 20);
            this.sprintUpdateIdLabel.TabIndex = 22;
            this.sprintUpdateIdLabel.Text = "identify sprint id";
            // 
            // sprintIdUpdateBox
            // 
            this.sprintIdUpdateBox.Location = new System.Drawing.Point(289, 205);
            this.sprintIdUpdateBox.Name = "sprintIdUpdateBox";
            this.sprintIdUpdateBox.Size = new System.Drawing.Size(199, 22);
            this.sprintIdUpdateBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "sprint name";
            // 
            // sprintNameUpdateBox
            // 
            this.sprintNameUpdateBox.Location = new System.Drawing.Point(289, 274);
            this.sprintNameUpdateBox.Name = "sprintNameUpdateBox";
            this.sprintNameUpdateBox.Size = new System.Drawing.Size(199, 22);
            this.sprintNameUpdateBox.TabIndex = 18;
            // 
            // Sprints
            // 
            this.Sprints.AutoSize = true;
            this.Sprints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprints.Location = new System.Drawing.Point(315, 92);
            this.Sprints.Name = "Sprints";
            this.Sprints.Size = new System.Drawing.Size(200, 36);
            this.Sprints.TabIndex = 17;
            this.Sprints.Text = "Update Sprint";
            // 
            // SprintForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 721);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sprintPiUpdateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sprintPeriodUpdateBox);
            this.Controls.Add(this.sprintUpdateIdLabel);
            this.Controls.Add(this.sprintIdUpdateBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sprintNameUpdateBox);
            this.Controls.Add(this.Sprints);
            this.Name = "SprintForm3";
            this.Text = "SprintForm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sprintPiUpdateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sprintPeriodUpdateBox;
        private System.Windows.Forms.Label sprintUpdateIdLabel;
        private System.Windows.Forms.TextBox sprintIdUpdateBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sprintNameUpdateBox;
        private System.Windows.Forms.Label Sprints;
    }
}