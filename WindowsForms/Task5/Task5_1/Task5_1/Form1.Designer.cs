namespace Task5_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.authorsLabel = new System.Windows.Forms.Label();
            this.booksLabel = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.arrowRightPictureBox = new System.Windows.Forms.PictureBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.Location = new System.Drawing.Point(12, 25);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(166, 277);
            this.authorsListBox.TabIndex = 0;
            this.authorsListBox.SelectedIndexChanged += new System.EventHandler(this.authorsListBox_SelectedIndexChanged);
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Location = new System.Drawing.Point(12, 9);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(46, 13);
            this.authorsLabel.TabIndex = 1;
            this.authorsLabel.Text = "Authors:";
            // 
            // booksLabel
            // 
            this.booksLabel.AutoSize = true;
            this.booksLabel.Location = new System.Drawing.Point(303, 9);
            this.booksLabel.Name = "booksLabel";
            this.booksLabel.Size = new System.Drawing.Size(40, 13);
            this.booksLabel.TabIndex = 2;
            this.booksLabel.Text = "Books:";
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.Location = new System.Drawing.Point(306, 25);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(166, 277);
            this.booksListBox.TabIndex = 3;
            // 
            // arrowRightPictureBox
            // 
            this.arrowRightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrowRightPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("arrowRightPictureBox.Image")));
            this.arrowRightPictureBox.Location = new System.Drawing.Point(184, 143);
            this.arrowRightPictureBox.Name = "arrowRightPictureBox";
            this.arrowRightPictureBox.Size = new System.Drawing.Size(116, 69);
            this.arrowRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowRightPictureBox.TabIndex = 4;
            this.arrowRightPictureBox.TabStop = false;
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "All Books",
            "By Author"});
            this.filterComboBox.Location = new System.Drawing.Point(184, 41);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(116, 21);
            this.filterComboBox.TabIndex = 5;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(184, 25);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(32, 13);
            this.filterLabel.TabIndex = 6;
            this.filterLabel.Text = "Filter:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 315);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.arrowRightPictureBox);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.booksLabel);
            this.Controls.Add(this.authorsLabel);
            this.Controls.Add(this.authorsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Very Simple Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrowRightPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.Label authorsLabel;
        private System.Windows.Forms.Label booksLabel;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.PictureBox arrowRightPictureBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label filterLabel;
    }
}

