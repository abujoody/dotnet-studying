namespace BANKretail
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
            this.grbx_Debitors = new System.Windows.Forms.GroupBox();
            this.dgv_Debitors = new System.Windows.Forms.DataGridView();
            this.grbx_DebitorDetails = new System.Windows.Forms.GroupBox();
            this.lbl_DebitorPhoneNumber = new System.Windows.Forms.Label();
            this.lbl_DebitorPostNumber = new System.Windows.Forms.Label();
            this.lbl_DebitorName = new System.Windows.Forms.Label();
            this.lbl_DebitorID = new System.Windows.Forms.Label();
            this.txbx_DebitorPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbx_DebitorPostNumber = new System.Windows.Forms.TextBox();
            this.txbx_DebitorName = new System.Windows.Forms.TextBox();
            this.txbx_DebitorID = new System.Windows.Forms.TextBox();
            this.grbx_Credits = new System.Windows.Forms.GroupBox();
            this.dgv_Credits = new System.Windows.Forms.DataGridView();
            this.grbx_Payments = new System.Windows.Forms.GroupBox();
            this.dgv_Payments = new System.Windows.Forms.DataGridView();
            this.grbx_Search = new System.Windows.Forms.GroupBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCredtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbx_Debitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Debitors)).BeginInit();
            this.grbx_DebitorDetails.SuspendLayout();
            this.grbx_Credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).BeginInit();
            this.grbx_Payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_Debitors
            // 
            this.grbx_Debitors.Controls.Add(this.dgv_Debitors);
            this.grbx_Debitors.Location = new System.Drawing.Point(12, 107);
            this.grbx_Debitors.Name = "grbx_Debitors";
            this.grbx_Debitors.Size = new System.Drawing.Size(351, 129);
            this.grbx_Debitors.TabIndex = 0;
            this.grbx_Debitors.TabStop = false;
            this.grbx_Debitors.Text = "Debitors";
            // 
            // dgv_Debitors
            // 
            this.dgv_Debitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Debitors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Debitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Debitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Debitors.Location = new System.Drawing.Point(3, 16);
            this.dgv_Debitors.Name = "dgv_Debitors";
            this.dgv_Debitors.Size = new System.Drawing.Size(345, 110);
            this.dgv_Debitors.TabIndex = 0;
            // 
            // grbx_DebitorDetails
            // 
            this.grbx_DebitorDetails.Controls.Add(this.lbl_DebitorPhoneNumber);
            this.grbx_DebitorDetails.Controls.Add(this.lbl_DebitorPostNumber);
            this.grbx_DebitorDetails.Controls.Add(this.lbl_DebitorName);
            this.grbx_DebitorDetails.Controls.Add(this.lbl_DebitorID);
            this.grbx_DebitorDetails.Controls.Add(this.txbx_DebitorPhoneNumber);
            this.grbx_DebitorDetails.Controls.Add(this.txbx_DebitorPostNumber);
            this.grbx_DebitorDetails.Controls.Add(this.txbx_DebitorName);
            this.grbx_DebitorDetails.Controls.Add(this.txbx_DebitorID);
            this.grbx_DebitorDetails.Location = new System.Drawing.Point(369, 107);
            this.grbx_DebitorDetails.Name = "grbx_DebitorDetails";
            this.grbx_DebitorDetails.Size = new System.Drawing.Size(359, 126);
            this.grbx_DebitorDetails.TabIndex = 1;
            this.grbx_DebitorDetails.TabStop = false;
            this.grbx_DebitorDetails.Text = "Debitor Details";
            // 
            // lbl_DebitorPhoneNumber
            // 
            this.lbl_DebitorPhoneNumber.AutoSize = true;
            this.lbl_DebitorPhoneNumber.Location = new System.Drawing.Point(6, 100);
            this.lbl_DebitorPhoneNumber.Name = "lbl_DebitorPhoneNumber";
            this.lbl_DebitorPhoneNumber.Size = new System.Drawing.Size(115, 13);
            this.lbl_DebitorPhoneNumber.TabIndex = 7;
            this.lbl_DebitorPhoneNumber.Text = "Debitor Phone Number";
            // 
            // lbl_DebitorPostNumber
            // 
            this.lbl_DebitorPostNumber.AutoSize = true;
            this.lbl_DebitorPostNumber.Location = new System.Drawing.Point(6, 74);
            this.lbl_DebitorPostNumber.Name = "lbl_DebitorPostNumber";
            this.lbl_DebitorPostNumber.Size = new System.Drawing.Size(105, 13);
            this.lbl_DebitorPostNumber.TabIndex = 6;
            this.lbl_DebitorPostNumber.Text = "Debitor Post Number";
            // 
            // lbl_DebitorName
            // 
            this.lbl_DebitorName.AutoSize = true;
            this.lbl_DebitorName.Location = new System.Drawing.Point(6, 48);
            this.lbl_DebitorName.Name = "lbl_DebitorName";
            this.lbl_DebitorName.Size = new System.Drawing.Size(72, 13);
            this.lbl_DebitorName.TabIndex = 5;
            this.lbl_DebitorName.Text = "Debitor Name";
            // 
            // lbl_DebitorID
            // 
            this.lbl_DebitorID.AutoSize = true;
            this.lbl_DebitorID.Location = new System.Drawing.Point(6, 22);
            this.lbl_DebitorID.Name = "lbl_DebitorID";
            this.lbl_DebitorID.Size = new System.Drawing.Size(55, 13);
            this.lbl_DebitorID.TabIndex = 4;
            this.lbl_DebitorID.Text = "Debitor ID";
            // 
            // txbx_DebitorPhoneNumber
            // 
            this.txbx_DebitorPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_DebitorPhoneNumber.Location = new System.Drawing.Point(127, 97);
            this.txbx_DebitorPhoneNumber.Name = "txbx_DebitorPhoneNumber";
            this.txbx_DebitorPhoneNumber.ReadOnly = true;
            this.txbx_DebitorPhoneNumber.Size = new System.Drawing.Size(222, 20);
            this.txbx_DebitorPhoneNumber.TabIndex = 3;
            // 
            // txbx_DebitorPostNumber
            // 
            this.txbx_DebitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_DebitorPostNumber.Location = new System.Drawing.Point(127, 71);
            this.txbx_DebitorPostNumber.Name = "txbx_DebitorPostNumber";
            this.txbx_DebitorPostNumber.ReadOnly = true;
            this.txbx_DebitorPostNumber.Size = new System.Drawing.Size(222, 20);
            this.txbx_DebitorPostNumber.TabIndex = 2;
            // 
            // txbx_DebitorName
            // 
            this.txbx_DebitorName.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_DebitorName.Location = new System.Drawing.Point(127, 45);
            this.txbx_DebitorName.Name = "txbx_DebitorName";
            this.txbx_DebitorName.ReadOnly = true;
            this.txbx_DebitorName.Size = new System.Drawing.Size(222, 20);
            this.txbx_DebitorName.TabIndex = 1;
            // 
            // txbx_DebitorID
            // 
            this.txbx_DebitorID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_DebitorID.Location = new System.Drawing.Point(127, 19);
            this.txbx_DebitorID.Name = "txbx_DebitorID";
            this.txbx_DebitorID.ReadOnly = true;
            this.txbx_DebitorID.Size = new System.Drawing.Size(222, 20);
            this.txbx_DebitorID.TabIndex = 0;
            // 
            // grbx_Credits
            // 
            this.grbx_Credits.Controls.Add(this.dgv_Credits);
            this.grbx_Credits.Location = new System.Drawing.Point(12, 242);
            this.grbx_Credits.Name = "grbx_Credits";
            this.grbx_Credits.Size = new System.Drawing.Size(716, 164);
            this.grbx_Credits.TabIndex = 2;
            this.grbx_Credits.TabStop = false;
            this.grbx_Credits.Text = "Credits";
            // 
            // dgv_Credits
            // 
            this.dgv_Credits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Credits.Location = new System.Drawing.Point(3, 16);
            this.dgv_Credits.Name = "dgv_Credits";
            this.dgv_Credits.Size = new System.Drawing.Size(710, 145);
            this.dgv_Credits.TabIndex = 0;
            // 
            // grbx_Payments
            // 
            this.grbx_Payments.Controls.Add(this.dgv_Payments);
            this.grbx_Payments.Location = new System.Drawing.Point(12, 412);
            this.grbx_Payments.Name = "grbx_Payments";
            this.grbx_Payments.Size = new System.Drawing.Size(716, 164);
            this.grbx_Payments.TabIndex = 1;
            this.grbx_Payments.TabStop = false;
            this.grbx_Payments.Text = "Payments";
            // 
            // dgv_Payments
            // 
            this.dgv_Payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Payments.Location = new System.Drawing.Point(3, 16);
            this.dgv_Payments.Name = "dgv_Payments";
            this.dgv_Payments.Size = new System.Drawing.Size(710, 145);
            this.dgv_Payments.TabIndex = 0;
            // 
            // grbx_Search
            // 
            this.grbx_Search.Location = new System.Drawing.Point(15, 34);
            this.grbx_Search.Name = "grbx_Search";
            this.grbx_Search.Size = new System.Drawing.Size(713, 67);
            this.grbx_Search.TabIndex = 3;
            this.grbx_Search.TabStop = false;
            this.grbx_Search.Text = "Search";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(738, 24);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveDataToCSVToolStripMenuItem.Text = "Save Data to CSV ...";
            this.saveDataToCSVToolStripMenuItem.Click += new System.EventHandler(this.saveDataToCSVToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debitorToolStripMenuItem
            // 
            this.debitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebitorToolStripMenuItem});
            this.debitorToolStripMenuItem.Name = "debitorToolStripMenuItem";
            this.debitorToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.debitorToolStripMenuItem.Text = "Debitor";
            // 
            // addNewDebitorToolStripMenuItem
            // 
            this.addNewDebitorToolStripMenuItem.Name = "addNewDebitorToolStripMenuItem";
            this.addNewDebitorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addNewDebitorToolStripMenuItem.Text = "Add New Debitor ...";
            this.addNewDebitorToolStripMenuItem.Click += new System.EventHandler(this.addNewDebitorToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCredtToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // openNewCredtToolStripMenuItem
            // 
            this.openNewCredtToolStripMenuItem.Name = "openNewCredtToolStripMenuItem";
            this.openNewCredtToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openNewCredtToolStripMenuItem.Text = "Open New Credit ...";
            this.openNewCredtToolStripMenuItem.Click += new System.EventHandler(this.openNewCredtToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.passNewPaymentToolStripMenuItem.Text = "Pass New Payment ...";
            this.passNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.passNewPaymentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 585);
            this.Controls.Add(this.grbx_Search);
            this.Controls.Add(this.grbx_Payments);
            this.Controls.Add(this.grbx_Credits);
            this.Controls.Add(this.grbx_DebitorDetails);
            this.Controls.Add(this.grbx_Debitors);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbx_Debitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Debitors)).EndInit();
            this.grbx_DebitorDetails.ResumeLayout(false);
            this.grbx_DebitorDetails.PerformLayout();
            this.grbx_Credits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).EndInit();
            this.grbx_Payments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Debitors;
        private System.Windows.Forms.DataGridView dgv_Debitors;
        private System.Windows.Forms.GroupBox grbx_DebitorDetails;
        private System.Windows.Forms.Label lbl_DebitorPhoneNumber;
        private System.Windows.Forms.Label lbl_DebitorPostNumber;
        private System.Windows.Forms.Label lbl_DebitorName;
        private System.Windows.Forms.Label lbl_DebitorID;
        private System.Windows.Forms.TextBox txbx_DebitorPhoneNumber;
        private System.Windows.Forms.TextBox txbx_DebitorPostNumber;
        private System.Windows.Forms.TextBox txbx_DebitorName;
        private System.Windows.Forms.TextBox txbx_DebitorID;
        private System.Windows.Forms.GroupBox grbx_Credits;
        private System.Windows.Forms.DataGridView dgv_Credits;
        private System.Windows.Forms.GroupBox grbx_Payments;
        private System.Windows.Forms.DataGridView dgv_Payments;
        private System.Windows.Forms.GroupBox grbx_Search;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCredtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
    }
}

