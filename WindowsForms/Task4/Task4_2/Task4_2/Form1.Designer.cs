namespace Task4_2
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
            this.controlsToCreateCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // controlsToCreateCheckedListBox
            // 
            this.controlsToCreateCheckedListBox.FormattingEnabled = true;
            this.controlsToCreateCheckedListBox.Items.AddRange(new object[] {
            "Label",
            "Button",
            "TextBox",
            "ComboBox",
            "ListBox"});
            this.controlsToCreateCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.controlsToCreateCheckedListBox.Name = "controlsToCreateCheckedListBox";
            this.controlsToCreateCheckedListBox.Size = new System.Drawing.Size(515, 79);
            this.controlsToCreateCheckedListBox.TabIndex = 0;
            this.controlsToCreateCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.controlsToCreateCheckedListBox_ItemCheck);
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Location = new System.Drawing.Point(12, 97);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(515, 308);
            this.previewGroupBox.TabIndex = 1;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 417);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.controlsToCreateCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Dynamic Creation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox controlsToCreateCheckedListBox;
        private System.Windows.Forms.GroupBox previewGroupBox;
    }
}

