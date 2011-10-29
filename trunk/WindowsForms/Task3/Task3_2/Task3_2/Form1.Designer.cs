namespace Task3_2
{
    partial class MainForm
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
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.enterDateLabel = new System.Windows.Forms.Label();
            this.calcTimeButton = new System.Windows.Forms.Button();
            this.daysRadioButton = new System.Windows.Forms.RadioButton();
            this.minutesRadioButton = new System.Windows.Forms.RadioButton();
            this.secondsRadioButton = new System.Windows.Forms.RadioButton();
            this.seeResultLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(15, 38);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(107, 20);
            this.dateTextBox.TabIndex = 0;
            // 
            // enterDateLabel
            // 
            this.enterDateLabel.Location = new System.Drawing.Point(12, 9);
            this.enterDateLabel.Name = "enterDateLabel";
            this.enterDateLabel.Size = new System.Drawing.Size(110, 26);
            this.enterDateLabel.TabIndex = 1;
            this.enterDateLabel.Text = "Enter date in format: day.month.year";
            // 
            // calcTimeButton
            // 
            this.calcTimeButton.Location = new System.Drawing.Point(15, 70);
            this.calcTimeButton.Name = "calcTimeButton";
            this.calcTimeButton.Size = new System.Drawing.Size(107, 31);
            this.calcTimeButton.TabIndex = 2;
            this.calcTimeButton.Text = "Calc time to date";
            this.calcTimeButton.UseVisualStyleBackColor = true;
            this.calcTimeButton.Click += new System.EventHandler(this.calcTimeButton_Click);
            // 
            // daysRadioButton
            // 
            this.daysRadioButton.AutoSize = true;
            this.daysRadioButton.Checked = true;
            this.daysRadioButton.Location = new System.Drawing.Point(131, 38);
            this.daysRadioButton.Name = "daysRadioButton";
            this.daysRadioButton.Size = new System.Drawing.Size(49, 17);
            this.daysRadioButton.TabIndex = 3;
            this.daysRadioButton.TabStop = true;
            this.daysRadioButton.Text = "Days";
            this.daysRadioButton.UseVisualStyleBackColor = true;
            // 
            // minutesRadioButton
            // 
            this.minutesRadioButton.AutoSize = true;
            this.minutesRadioButton.Location = new System.Drawing.Point(131, 61);
            this.minutesRadioButton.Name = "minutesRadioButton";
            this.minutesRadioButton.Size = new System.Drawing.Size(62, 17);
            this.minutesRadioButton.TabIndex = 4;
            this.minutesRadioButton.TabStop = true;
            this.minutesRadioButton.Text = "Minutes";
            this.minutesRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondsRadioButton
            // 
            this.secondsRadioButton.AutoSize = true;
            this.secondsRadioButton.Location = new System.Drawing.Point(131, 84);
            this.secondsRadioButton.Name = "secondsRadioButton";
            this.secondsRadioButton.Size = new System.Drawing.Size(67, 17);
            this.secondsRadioButton.TabIndex = 5;
            this.secondsRadioButton.TabStop = true;
            this.secondsRadioButton.Text = "Seconds";
            this.secondsRadioButton.UseVisualStyleBackColor = true;
            // 
            // seeResultLabel
            // 
            this.seeResultLabel.AutoSize = true;
            this.seeResultLabel.Location = new System.Drawing.Point(128, 9);
            this.seeResultLabel.Name = "seeResultLabel";
            this.seeResultLabel.Size = new System.Drawing.Size(68, 13);
            this.seeResultLabel.TabIndex = 6;
            this.seeResultLabel.Text = "See result in:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 119);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result:";
            // 
            // resultTimeTextBox
            // 
            this.resultTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTimeTextBox.Location = new System.Drawing.Point(15, 135);
            this.resultTimeTextBox.Name = "resultTimeTextBox";
            this.resultTimeTextBox.ReadOnly = true;
            this.resultTimeTextBox.Size = new System.Drawing.Size(107, 20);
            this.resultTimeTextBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 169);
            this.Controls.Add(this.resultTimeTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.seeResultLabel);
            this.Controls.Add(this.secondsRadioButton);
            this.Controls.Add(this.minutesRadioButton);
            this.Controls.Add(this.daysRadioButton);
            this.Controls.Add(this.calcTimeButton);
            this.Controls.Add(this.enterDateLabel);
            this.Controls.Add(this.dateTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Time to Date";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label enterDateLabel;
        private System.Windows.Forms.Button calcTimeButton;
        private System.Windows.Forms.RadioButton daysRadioButton;
        private System.Windows.Forms.RadioButton minutesRadioButton;
        private System.Windows.Forms.RadioButton secondsRadioButton;
        private System.Windows.Forms.Label seeResultLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTimeTextBox;
    }
}

