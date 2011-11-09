namespace BANKretail
{
    partial class NewCreditForm
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
            this.grbx_CreditDetails = new System.Windows.Forms.GroupBox();
            this.lbl_OpenDate = new System.Windows.Forms.Label();
            this.dtp_CreditOpenDate = new System.Windows.Forms.DateTimePicker();
            this.lsbx_DebitorsName = new System.Windows.Forms.ListBox();
            this.lsbx_DebitorsID = new System.Windows.Forms.ListBox();
            this.btn_OpenNewCredit = new System.Windows.Forms.Button();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_CreditAmount = new System.Windows.Forms.Label();
            this.lbl_Debitor = new System.Windows.Forms.Label();
            this.lbl_CreditID = new System.Windows.Forms.Label();
            this.txbx_CreditBalance = new System.Windows.Forms.TextBox();
            this.txbx_CreditAmount = new System.Windows.Forms.TextBox();
            this.txbx_CreditID = new System.Windows.Forms.TextBox();
            this.lbl_AmountStatus = new System.Windows.Forms.Label();
            this.lbl_StatusLabel = new System.Windows.Forms.Label();
            this.grbx_CreditDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_CreditDetails
            // 
            this.grbx_CreditDetails.Controls.Add(this.lbl_StatusLabel);
            this.grbx_CreditDetails.Controls.Add(this.lbl_AmountStatus);
            this.grbx_CreditDetails.Controls.Add(this.lbl_OpenDate);
            this.grbx_CreditDetails.Controls.Add(this.dtp_CreditOpenDate);
            this.grbx_CreditDetails.Controls.Add(this.lsbx_DebitorsName);
            this.grbx_CreditDetails.Controls.Add(this.lsbx_DebitorsID);
            this.grbx_CreditDetails.Controls.Add(this.btn_OpenNewCredit);
            this.grbx_CreditDetails.Controls.Add(this.lbl_Balance);
            this.grbx_CreditDetails.Controls.Add(this.lbl_CreditAmount);
            this.grbx_CreditDetails.Controls.Add(this.lbl_Debitor);
            this.grbx_CreditDetails.Controls.Add(this.lbl_CreditID);
            this.grbx_CreditDetails.Controls.Add(this.txbx_CreditBalance);
            this.grbx_CreditDetails.Controls.Add(this.txbx_CreditAmount);
            this.grbx_CreditDetails.Controls.Add(this.txbx_CreditID);
            this.grbx_CreditDetails.Location = new System.Drawing.Point(12, 12);
            this.grbx_CreditDetails.Name = "grbx_CreditDetails";
            this.grbx_CreditDetails.Size = new System.Drawing.Size(524, 276);
            this.grbx_CreditDetails.TabIndex = 3;
            this.grbx_CreditDetails.TabStop = false;
            this.grbx_CreditDetails.Text = "Credit Details";
            // 
            // lbl_OpenDate
            // 
            this.lbl_OpenDate.AutoSize = true;
            this.lbl_OpenDate.Location = new System.Drawing.Point(6, 191);
            this.lbl_OpenDate.Name = "lbl_OpenDate";
            this.lbl_OpenDate.Size = new System.Drawing.Size(59, 13);
            this.lbl_OpenDate.TabIndex = 14;
            this.lbl_OpenDate.Text = "Open Date";
            // 
            // dtp_CreditOpenDate
            // 
            this.dtp_CreditOpenDate.Location = new System.Drawing.Point(76, 185);
            this.dtp_CreditOpenDate.Name = "dtp_CreditOpenDate";
            this.dtp_CreditOpenDate.Size = new System.Drawing.Size(216, 20);
            this.dtp_CreditOpenDate.TabIndex = 13;
            // 
            // lsbx_DebitorsName
            // 
            this.lsbx_DebitorsName.DisplayMember = "Name";
            this.lsbx_DebitorsName.FormattingEnabled = true;
            this.lsbx_DebitorsName.Location = new System.Drawing.Point(298, 45);
            this.lsbx_DebitorsName.Name = "lsbx_DebitorsName";
            this.lsbx_DebitorsName.Size = new System.Drawing.Size(216, 108);
            this.lsbx_DebitorsName.TabIndex = 10;
            this.lsbx_DebitorsName.ValueMember = "ID";
            // 
            // lsbx_DebitorsID
            // 
            this.lsbx_DebitorsID.DisplayMember = "ID";
            this.lsbx_DebitorsID.FormattingEnabled = true;
            this.lsbx_DebitorsID.Location = new System.Drawing.Point(76, 45);
            this.lsbx_DebitorsID.Name = "lsbx_DebitorsID";
            this.lsbx_DebitorsID.Size = new System.Drawing.Size(216, 108);
            this.lsbx_DebitorsID.TabIndex = 9;
            this.lsbx_DebitorsID.ValueMember = "ID";
            // 
            // btn_OpenNewCredit
            // 
            this.btn_OpenNewCredit.Location = new System.Drawing.Point(9, 244);
            this.btn_OpenNewCredit.Name = "btn_OpenNewCredit";
            this.btn_OpenNewCredit.Size = new System.Drawing.Size(505, 23);
            this.btn_OpenNewCredit.TabIndex = 8;
            this.btn_OpenNewCredit.Text = "Open New Credit";
            this.btn_OpenNewCredit.UseVisualStyleBackColor = true;
            this.btn_OpenNewCredit.Click += new System.EventHandler(this.btn_OpenNewCredit_Click);
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Location = new System.Drawing.Point(6, 216);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(46, 13);
            this.lbl_Balance.TabIndex = 7;
            this.lbl_Balance.Text = "Balance";
            // 
            // lbl_CreditAmount
            // 
            this.lbl_CreditAmount.AutoSize = true;
            this.lbl_CreditAmount.Location = new System.Drawing.Point(6, 162);
            this.lbl_CreditAmount.Name = "lbl_CreditAmount";
            this.lbl_CreditAmount.Size = new System.Drawing.Size(43, 13);
            this.lbl_CreditAmount.TabIndex = 6;
            this.lbl_CreditAmount.Text = "Amount";
            // 
            // lbl_Debitor
            // 
            this.lbl_Debitor.AutoSize = true;
            this.lbl_Debitor.Location = new System.Drawing.Point(6, 45);
            this.lbl_Debitor.Name = "lbl_Debitor";
            this.lbl_Debitor.Size = new System.Drawing.Size(41, 13);
            this.lbl_Debitor.TabIndex = 5;
            this.lbl_Debitor.Text = "Debitor";
            // 
            // lbl_CreditID
            // 
            this.lbl_CreditID.AutoSize = true;
            this.lbl_CreditID.Location = new System.Drawing.Point(6, 22);
            this.lbl_CreditID.Name = "lbl_CreditID";
            this.lbl_CreditID.Size = new System.Drawing.Size(45, 13);
            this.lbl_CreditID.TabIndex = 4;
            this.lbl_CreditID.Text = "CreditID";
            // 
            // txbx_CreditBalance
            // 
            this.txbx_CreditBalance.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_CreditBalance.Location = new System.Drawing.Point(76, 213);
            this.txbx_CreditBalance.Name = "txbx_CreditBalance";
            this.txbx_CreditBalance.ReadOnly = true;
            this.txbx_CreditBalance.Size = new System.Drawing.Size(438, 20);
            this.txbx_CreditBalance.TabIndex = 3;
            // 
            // txbx_CreditAmount
            // 
            this.txbx_CreditAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbx_CreditAmount.Location = new System.Drawing.Point(76, 159);
            this.txbx_CreditAmount.MaxLength = 8;
            this.txbx_CreditAmount.Name = "txbx_CreditAmount";
            this.txbx_CreditAmount.Size = new System.Drawing.Size(216, 20);
            this.txbx_CreditAmount.TabIndex = 2;
            this.txbx_CreditAmount.TextChanged += new System.EventHandler(this.txbx_CreditAmount_TextChanged);
            this.txbx_CreditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_CreditAmount_KeyPress);
            this.txbx_CreditAmount.Leave += new System.EventHandler(this.txbx_CreditAmount_Leave);
            // 
            // txbx_CreditID
            // 
            this.txbx_CreditID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_CreditID.Location = new System.Drawing.Point(76, 19);
            this.txbx_CreditID.Name = "txbx_CreditID";
            this.txbx_CreditID.ReadOnly = true;
            this.txbx_CreditID.Size = new System.Drawing.Size(438, 20);
            this.txbx_CreditID.TabIndex = 0;
            // 
            // lbl_AmountStatus
            // 
            this.lbl_AmountStatus.AutoSize = true;
            this.lbl_AmountStatus.Location = new System.Drawing.Point(335, 162);
            this.lbl_AmountStatus.Name = "lbl_AmountStatus";
            this.lbl_AmountStatus.Size = new System.Drawing.Size(100, 13);
            this.lbl_AmountStatus.TabIndex = 15;
            this.lbl_AmountStatus.Text = "Type Credit Amount";
            // 
            // lbl_StatusLabel
            // 
            this.lbl_StatusLabel.AutoSize = true;
            this.lbl_StatusLabel.Location = new System.Drawing.Point(298, 162);
            this.lbl_StatusLabel.Name = "lbl_StatusLabel";
            this.lbl_StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.lbl_StatusLabel.TabIndex = 16;
            this.lbl_StatusLabel.Text = "Status:";
            // 
            // NewCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 297);
            this.Controls.Add(this.grbx_CreditDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCreditForm";
            this.Text = "New Credit";
            this.grbx_CreditDetails.ResumeLayout(false);
            this.grbx_CreditDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_CreditDetails;
        private System.Windows.Forms.Label lbl_OpenDate;
        private System.Windows.Forms.DateTimePicker dtp_CreditOpenDate;
        private System.Windows.Forms.ListBox lsbx_DebitorsName;
        private System.Windows.Forms.ListBox lsbx_DebitorsID;
        private System.Windows.Forms.Button btn_OpenNewCredit;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_CreditAmount;
        private System.Windows.Forms.Label lbl_Debitor;
        private System.Windows.Forms.Label lbl_CreditID;
        private System.Windows.Forms.TextBox txbx_CreditBalance;
        private System.Windows.Forms.TextBox txbx_CreditAmount;
        private System.Windows.Forms.TextBox txbx_CreditID;
        private System.Windows.Forms.Label lbl_StatusLabel;
        private System.Windows.Forms.Label lbl_AmountStatus;
    }
}