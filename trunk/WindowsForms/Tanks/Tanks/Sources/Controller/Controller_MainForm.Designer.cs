namespace Tanks
{
    partial class Controller_MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller_MainForm));
            this.StartStopButton = new System.Windows.Forms.PictureBox();
            this.Help_Ttip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StartStopButton)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStopButton
            // 
            this.StartStopButton.Image = global::Tanks.Properties.Resources.PlayButton;
            this.StartStopButton.Location = new System.Drawing.Point(281, 12);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(81, 81);
            this.StartStopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StartStopButton.TabIndex = 0;
            this.StartStopButton.TabStop = false;
            this.Help_Ttip.SetToolTip(this.StartStopButton, "Click Button To Start Game");
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // Help_Ttip
            // 
            this.Help_Ttip.IsBalloon = true;
            this.Help_Ttip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Help_Ttip.ToolTipTitle = "Tanks 1.0";
            // 
            // Controller_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(374, 372);
            this.Controls.Add(this.StartStopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Controller_MainForm";
            this.Text = "Танки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StartStopButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartStopButton;
        private System.Windows.Forms.ToolTip Help_Ttip;

    }
}

