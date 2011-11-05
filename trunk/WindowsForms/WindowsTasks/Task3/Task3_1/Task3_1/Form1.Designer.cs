namespace Task3_1
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
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.calcDayButton = new System.Windows.Forms.Button();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(15, 25);
            this.yearUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(70, 20);
            this.yearUpDown.TabIndex = 0;
            this.yearUpDown.ValueChanged += new System.EventHandler(this.yearUpDown_ValueChanged);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 9);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 1;
            this.yearLabel.Text = "Year";
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(91, 25);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(79, 21);
            this.monthComboBox.TabIndex = 2;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(88, 9);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(37, 13);
            this.monthLabel.TabIndex = 3;
            this.monthLabel.Text = "Month";
            // 
            // numberComboBox
            // 
            this.numberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.numberComboBox.Location = new System.Drawing.Point(176, 25);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(79, 21);
            this.numberComboBox.TabIndex = 4;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(173, 9);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Number";
            // 
            // calcDayButton
            // 
            this.calcDayButton.Location = new System.Drawing.Point(15, 65);
            this.calcDayButton.Name = "calcDayButton";
            this.calcDayButton.Size = new System.Drawing.Size(119, 21);
            this.calcDayButton.TabIndex = 6;
            this.calcDayButton.Text = "Get Day Of Week";
            this.calcDayButton.UseVisualStyleBackColor = true;
            this.calcDayButton.Click += new System.EventHandler(this.calcDayButton_Click);
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekLabel.Location = new System.Drawing.Point(12, 102);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(142, 17);
            this.dayOfWeekLabel.TabIndex = 7;
            this.dayOfWeekLabel.Text = "See here your day!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 136);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Controls.Add(this.calcDayButton);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.numberComboBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Day of week by date";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button calcDayButton;
        private System.Windows.Forms.Label dayOfWeekLabel;
    }
}

