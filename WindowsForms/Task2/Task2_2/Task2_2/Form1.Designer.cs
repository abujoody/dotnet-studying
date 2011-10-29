namespace Task2_2
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
            this.escapingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // escapingLabel
            // 
            this.escapingLabel.AutoSize = true;
            this.escapingLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.escapingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escapingLabel.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escapingLabel.Location = new System.Drawing.Point(104, 161);
            this.escapingLabel.Name = "escapingLabel";
            this.escapingLabel.Size = new System.Drawing.Size(230, 32);
            this.escapingLabel.TabIndex = 0;
            this.escapingLabel.Text = "Try to click me";
            this.escapingLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.escapingLabel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 353);
            this.Controls.Add(this.escapingLabel);
            this.Name = "MainForm";
            this.Text = "Escaping label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label escapingLabel;
    }
}

