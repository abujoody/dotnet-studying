namespace Task5_2
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
            this.findStringButton = new System.Windows.Forms.Button();
            this.fileNamePreviewTextBox = new System.Windows.Forms.TextBox();
            this.chooseFileLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.stringToSearchLabel = new System.Windows.Forms.Label();
            this.stringToSearchTextBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.addFileToListButton = new System.Windows.Forms.Button();
            this.filesToSearchListBox = new System.Windows.Forms.ListBox();
            this.deleteFileInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findStringButton
            // 
            this.findStringButton.Location = new System.Drawing.Point(273, 268);
            this.findStringButton.Name = "findStringButton";
            this.findStringButton.Size = new System.Drawing.Size(109, 20);
            this.findStringButton.TabIndex = 0;
            this.findStringButton.Text = "Find String";
            this.findStringButton.UseVisualStyleBackColor = true;
            this.findStringButton.Click += new System.EventHandler(this.findStringButton_Click);
            // 
            // fileNamePreviewTextBox
            // 
            this.fileNamePreviewTextBox.Location = new System.Drawing.Point(12, 25);
            this.fileNamePreviewTextBox.Name = "fileNamePreviewTextBox";
            this.fileNamePreviewTextBox.Size = new System.Drawing.Size(504, 20);
            this.fileNamePreviewTextBox.TabIndex = 1;
            // 
            // chooseFileLabel
            // 
            this.chooseFileLabel.AutoSize = true;
            this.chooseFileLabel.Location = new System.Drawing.Point(12, 9);
            this.chooseFileLabel.Name = "chooseFileLabel";
            this.chooseFileLabel.Size = new System.Drawing.Size(65, 13);
            this.chooseFileLabel.TabIndex = 2;
            this.chooseFileLabel.Text = "Choose File:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "FileName";
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(514, 25);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(30, 20);
            this.openFileDialogButton.TabIndex = 3;
            this.openFileDialogButton.Text = "...";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // stringToSearchLabel
            // 
            this.stringToSearchLabel.AutoSize = true;
            this.stringToSearchLabel.Location = new System.Drawing.Point(9, 253);
            this.stringToSearchLabel.Name = "stringToSearchLabel";
            this.stringToSearchLabel.Size = new System.Drawing.Size(87, 13);
            this.stringToSearchLabel.TabIndex = 4;
            this.stringToSearchLabel.Text = "Search for string:";
            // 
            // stringToSearchTextBox
            // 
            this.stringToSearchTextBox.Location = new System.Drawing.Point(12, 269);
            this.stringToSearchTextBox.Name = "stringToSearchTextBox";
            this.stringToSearchTextBox.Size = new System.Drawing.Size(255, 20);
            this.stringToSearchTextBox.TabIndex = 5;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(9, 300);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(45, 13);
            this.resultsLabel.TabIndex = 6;
            this.resultsLabel.Text = "Results:";
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.HorizontalScrollbar = true;
            this.resultsListBox.Location = new System.Drawing.Point(12, 316);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(532, 160);
            this.resultsListBox.TabIndex = 7;
            // 
            // addFileToListButton
            // 
            this.addFileToListButton.Location = new System.Drawing.Point(12, 51);
            this.addFileToListButton.Name = "addFileToListButton";
            this.addFileToListButton.Size = new System.Drawing.Size(116, 20);
            this.addFileToListButton.TabIndex = 8;
            this.addFileToListButton.Text = "Add To List";
            this.addFileToListButton.UseVisualStyleBackColor = true;
            this.addFileToListButton.Click += new System.EventHandler(this.addFileToListButton_Click);
            // 
            // filesToSearchListBox
            // 
            this.filesToSearchListBox.FormattingEnabled = true;
            this.filesToSearchListBox.HorizontalScrollbar = true;
            this.filesToSearchListBox.Location = new System.Drawing.Point(12, 77);
            this.filesToSearchListBox.Name = "filesToSearchListBox";
            this.filesToSearchListBox.Size = new System.Drawing.Size(532, 160);
            this.filesToSearchListBox.TabIndex = 9;
            this.filesToSearchListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesToSearchListBox_MouseDoubleClick);
            // 
            // deleteFileInfoLabel
            // 
            this.deleteFileInfoLabel.AutoSize = true;
            this.deleteFileInfoLabel.Location = new System.Drawing.Point(134, 55);
            this.deleteFileInfoLabel.Name = "deleteFileInfoLabel";
            this.deleteFileInfoLabel.Size = new System.Drawing.Size(365, 13);
            this.deleteFileInfoLabel.TabIndex = 10;
            this.deleteFileInfoLabel.Text = "To delete file from list perform mouse double click on item you want to delete";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 488);
            this.Controls.Add(this.deleteFileInfoLabel);
            this.Controls.Add(this.filesToSearchListBox);
            this.Controls.Add(this.addFileToListButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.stringToSearchTextBox);
            this.Controls.Add(this.stringToSearchLabel);
            this.Controls.Add(this.openFileDialogButton);
            this.Controls.Add(this.chooseFileLabel);
            this.Controls.Add(this.fileNamePreviewTextBox);
            this.Controls.Add(this.findStringButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Find Word Position";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findStringButton;
        private System.Windows.Forms.TextBox fileNamePreviewTextBox;
        private System.Windows.Forms.Label chooseFileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.Label stringToSearchLabel;
        private System.Windows.Forms.TextBox stringToSearchTextBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button addFileToListButton;
        private System.Windows.Forms.ListBox filesToSearchListBox;
        private System.Windows.Forms.Label deleteFileInfoLabel;
    }
}

