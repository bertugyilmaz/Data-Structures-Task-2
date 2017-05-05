namespace TurgutluBank
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
            this.circularTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.circularButton = new System.Windows.Forms.Button();
            this.priorityButton = new System.Windows.Forms.Button();
            this.timeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circularTextBox
            // 
            this.circularTextBox.Location = new System.Drawing.Point(59, 18);
            this.circularTextBox.Multiline = true;
            this.circularTextBox.Name = "circularTextBox";
            this.circularTextBox.Size = new System.Drawing.Size(362, 664);
            this.circularTextBox.TabIndex = 0;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Location = new System.Drawing.Point(460, 18);
            this.priorityTextBox.Multiline = true;
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(362, 664);
            this.priorityTextBox.TabIndex = 0;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(855, 18);
            this.timeTextBox.Multiline = true;
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(362, 664);
            this.timeTextBox.TabIndex = 0;
            // 
            // circularButton
            // 
            this.circularButton.Location = new System.Drawing.Point(90, 720);
            this.circularButton.Name = "circularButton";
            this.circularButton.Size = new System.Drawing.Size(289, 50);
            this.circularButton.TabIndex = 1;
            this.circularButton.Text = "Circular Queue";
            this.circularButton.UseVisualStyleBackColor = true;
            this.circularButton.Click += new System.EventHandler(this.circularButton_Click);
            // 
            // priorityButton
            // 
            this.priorityButton.Location = new System.Drawing.Point(482, 720);
            this.priorityButton.Name = "priorityButton";
            this.priorityButton.Size = new System.Drawing.Size(289, 50);
            this.priorityButton.TabIndex = 1;
            this.priorityButton.Text = "Priority";
            this.priorityButton.UseVisualStyleBackColor = true;
            this.priorityButton.Click += new System.EventHandler(this.priorityButton_Click);
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(895, 720);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(289, 50);
            this.timeButton.TabIndex = 1;
            this.timeButton.Text = "Zaman Farkı";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 789);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.priorityButton);
            this.Controls.Add(this.circularButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(this.circularTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox circularTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button circularButton;
        private System.Windows.Forms.Button priorityButton;
        private System.Windows.Forms.Button timeButton;
    }
}

