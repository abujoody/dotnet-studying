namespace Task4_1
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
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.sumRadioButton = new System.Windows.Forms.RadioButton();
            this.productRadioButton = new System.Windows.Forms.RadioButton();
            this.averageRadioButton = new System.Windows.Forms.RadioButton();
            this.whatToCalcLabel = new System.Windows.Forms.Label();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.resultValueLabel = new System.Windows.Forms.Label();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.Location = new System.Drawing.Point(12, 12);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(127, 212);
            this.numbersListBox.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(148, 97);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(134, 50);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate Sequence";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // sumRadioButton
            // 
            this.sumRadioButton.AutoSize = true;
            this.sumRadioButton.Checked = true;
            this.sumRadioButton.Location = new System.Drawing.Point(148, 28);
            this.sumRadioButton.Name = "sumRadioButton";
            this.sumRadioButton.Size = new System.Drawing.Size(46, 17);
            this.sumRadioButton.TabIndex = 2;
            this.sumRadioButton.TabStop = true;
            this.sumRadioButton.Text = "Sum";
            this.sumRadioButton.UseVisualStyleBackColor = true;
            this.sumRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // productRadioButton
            // 
            this.productRadioButton.AutoSize = true;
            this.productRadioButton.Location = new System.Drawing.Point(148, 51);
            this.productRadioButton.Name = "productRadioButton";
            this.productRadioButton.Size = new System.Drawing.Size(62, 17);
            this.productRadioButton.TabIndex = 3;
            this.productRadioButton.Text = "Product";
            this.productRadioButton.UseVisualStyleBackColor = true;
            this.productRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // averageRadioButton
            // 
            this.averageRadioButton.AutoSize = true;
            this.averageRadioButton.Location = new System.Drawing.Point(148, 74);
            this.averageRadioButton.Name = "averageRadioButton";
            this.averageRadioButton.Size = new System.Drawing.Size(65, 17);
            this.averageRadioButton.TabIndex = 4;
            this.averageRadioButton.Text = "Average";
            this.averageRadioButton.UseVisualStyleBackColor = true;
            this.averageRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // whatToCalcLabel
            // 
            this.whatToCalcLabel.AutoSize = true;
            this.whatToCalcLabel.Location = new System.Drawing.Point(145, 12);
            this.whatToCalcLabel.Name = "whatToCalcLabel";
            this.whatToCalcLabel.Size = new System.Drawing.Size(71, 13);
            this.whatToCalcLabel.TabIndex = 5;
            this.whatToCalcLabel.Text = "What to calc:";
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextLabel.Location = new System.Drawing.Point(6, 16);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(66, 19);
            this.resultTextLabel.TabIndex = 6;
            this.resultTextLabel.Text = "Result:";
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultValueLabel.Location = new System.Drawing.Point(6, 40);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(21, 22);
            this.resultValueLabel.TabIndex = 7;
            this.resultValueLabel.Text = "0";
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.resultTextLabel);
            this.resultGroupBox.Controls.Add(this.resultValueLabel);
            this.resultGroupBox.Location = new System.Drawing.Point(148, 153);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(134, 71);
            this.resultGroupBox.TabIndex = 8;
            this.resultGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 235);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.whatToCalcLabel);
            this.Controls.Add(this.averageRadioButton);
            this.Controls.Add(this.productRadioButton);
            this.Controls.Add(this.sumRadioButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numbersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Calculations";
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.RadioButton sumRadioButton;
        private System.Windows.Forms.RadioButton productRadioButton;
        private System.Windows.Forms.RadioButton averageRadioButton;
        private System.Windows.Forms.Label whatToCalcLabel;
        private System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.Label resultValueLabel;
        private System.Windows.Forms.GroupBox resultGroupBox;
    }
}

