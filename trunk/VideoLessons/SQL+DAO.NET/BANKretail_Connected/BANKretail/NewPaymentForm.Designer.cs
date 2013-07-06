namespace BANKretail
{
    partial class NewPaymentForm
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
            this.lbl_Credit = new System.Windows.Forms.Label();
            this.lsbx_CreditBalance = new System.Windows.Forms.ListBox();
            this.lsbx_CreditAmount = new System.Windows.Forms.ListBox();
            this.lsbx_CreditID = new System.Windows.Forms.ListBox();
            this.lbl_StatusLabel = new System.Windows.Forms.Label();
            this.lbl_AmountStatus = new System.Windows.Forms.Label();
            this.lbl_PaymentDate = new System.Windows.Forms.Label();
            this.dtp_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lsbx_DebitorsName = new System.Windows.Forms.ListBox();
            this.lsbx_DebitorsID = new System.Windows.Forms.ListBox();
            this.btn_PassNewPayment = new System.Windows.Forms.Button();
            this.lbl_PaymentAmount = new System.Windows.Forms.Label();
            this.lbl_Debitor = new System.Windows.Forms.Label();
            this.lbl_PaymentID = new System.Windows.Forms.Label();
            this.txbx_PaymentAmount = new System.Windows.Forms.TextBox();
            this.txbx_PaymentID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.grbx_CreditDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_CreditDetails
            // 
            this.grbx_CreditDetails.Controls.Add(this.lbl_Balance);
            this.grbx_CreditDetails.Controls.Add(this.lbl_Amount);
            this.grbx_CreditDetails.Controls.Add(this.lbl_ID);
            this.grbx_CreditDetails.Controls.Add(this.lbl_Credit);
            this.grbx_CreditDetails.Controls.Add(this.lsbx_CreditBalance);
            this.grbx_CreditDetails.Controls.Add(this.lsbx_CreditAmount);
            this.grbx_CreditDetails.Controls.Add(this.lsbx_CreditID);
            this.grbx_CreditDetails.Controls.Add(this.lbl_StatusLabel);
            this.grbx_CreditDetails.Controls.Add(this.lbl_AmountStatus);
            this.grbx_CreditDetails.Controls.Add(this.lbl_PaymentDate);
            this.grbx_CreditDetails.Controls.Add(this.dtp_PaymentDate);
            this.grbx_CreditDetails.Controls.Add(this.lsbx_DebitorsName);
            this.grbx_CreditDetails.Controls.Add(this.lsbx_DebitorsID);
            this.grbx_CreditDetails.Controls.Add(this.btn_PassNewPayment);
            this.grbx_CreditDetails.Controls.Add(this.lbl_PaymentAmount);
            this.grbx_CreditDetails.Controls.Add(this.lbl_Debitor);
            this.grbx_CreditDetails.Controls.Add(this.lbl_PaymentID);
            this.grbx_CreditDetails.Controls.Add(this.txbx_PaymentAmount);
            this.grbx_CreditDetails.Controls.Add(this.txbx_PaymentID);
            this.grbx_CreditDetails.Location = new System.Drawing.Point(12, 12);
            this.grbx_CreditDetails.Name = "grbx_CreditDetails";
            this.grbx_CreditDetails.Size = new System.Drawing.Size(576, 382);
            this.grbx_CreditDetails.TabIndex = 4;
            this.grbx_CreditDetails.TabStop = false;
            this.grbx_CreditDetails.Text = "Credit Details";
            // 
            // lbl_Credit
            // 
            this.lbl_Credit.AutoSize = true;
            this.lbl_Credit.Location = new System.Drawing.Point(6, 179);
            this.lbl_Credit.Name = "lbl_Credit";
            this.lbl_Credit.Size = new System.Drawing.Size(34, 13);
            this.lbl_Credit.TabIndex = 20;
            this.lbl_Credit.Text = "Credit";
            // 
            // lsbx_CreditBalance
            // 
            this.lsbx_CreditBalance.DisplayMember = "Balance";
            this.lsbx_CreditBalance.FormattingEnabled = true;
            this.lsbx_CreditBalance.Location = new System.Drawing.Point(410, 179);
            this.lsbx_CreditBalance.Name = "lsbx_CreditBalance";
            this.lsbx_CreditBalance.Size = new System.Drawing.Size(158, 108);
            this.lsbx_CreditBalance.TabIndex = 19;
            this.lsbx_CreditBalance.ValueMember = "ID";
            // 
            // lsbx_CreditAmount
            // 
            this.lsbx_CreditAmount.DisplayMember = "Amount";
            this.lsbx_CreditAmount.FormattingEnabled = true;
            this.lsbx_CreditAmount.Location = new System.Drawing.Point(246, 179);
            this.lsbx_CreditAmount.Name = "lsbx_CreditAmount";
            this.lsbx_CreditAmount.Size = new System.Drawing.Size(158, 108);
            this.lsbx_CreditAmount.TabIndex = 18;
            this.lsbx_CreditAmount.ValueMember = "ID";
            // 
            // lsbx_CreditID
            // 
            this.lsbx_CreditID.DisplayMember = "ID";
            this.lsbx_CreditID.FormattingEnabled = true;
            this.lsbx_CreditID.Location = new System.Drawing.Point(76, 179);
            this.lsbx_CreditID.Name = "lsbx_CreditID";
            this.lsbx_CreditID.Size = new System.Drawing.Size(164, 108);
            this.lsbx_CreditID.TabIndex = 17;
            this.lsbx_CreditID.ValueMember = "ID";
            // 
            // lbl_StatusLabel
            // 
            this.lbl_StatusLabel.AutoSize = true;
            this.lbl_StatusLabel.Location = new System.Drawing.Point(298, 296);
            this.lbl_StatusLabel.Name = "lbl_StatusLabel";
            this.lbl_StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.lbl_StatusLabel.TabIndex = 16;
            this.lbl_StatusLabel.Text = "Status:";
            // 
            // lbl_AmountStatus
            // 
            this.lbl_AmountStatus.AutoSize = true;
            this.lbl_AmountStatus.Location = new System.Drawing.Point(337, 296);
            this.lbl_AmountStatus.Name = "lbl_AmountStatus";
            this.lbl_AmountStatus.Size = new System.Drawing.Size(114, 13);
            this.lbl_AmountStatus.TabIndex = 15;
            this.lbl_AmountStatus.Text = "Type Payment Amount";
            // 
            // lbl_PaymentDate
            // 
            this.lbl_PaymentDate.AutoSize = true;
            this.lbl_PaymentDate.Location = new System.Drawing.Point(6, 325);
            this.lbl_PaymentDate.Name = "lbl_PaymentDate";
            this.lbl_PaymentDate.Size = new System.Drawing.Size(30, 13);
            this.lbl_PaymentDate.TabIndex = 14;
            this.lbl_PaymentDate.Text = "Date";
            // 
            // dtp_PaymentDate
            // 
            this.dtp_PaymentDate.Location = new System.Drawing.Point(76, 319);
            this.dtp_PaymentDate.Name = "dtp_PaymentDate";
            this.dtp_PaymentDate.Size = new System.Drawing.Size(216, 20);
            this.dtp_PaymentDate.TabIndex = 13;
            // 
            // lsbx_DebitorsName
            // 
            this.lsbx_DebitorsName.DisplayMember = "Name";
            this.lsbx_DebitorsName.FormattingEnabled = true;
            this.lsbx_DebitorsName.Location = new System.Drawing.Point(325, 45);
            this.lsbx_DebitorsName.Name = "lsbx_DebitorsName";
            this.lsbx_DebitorsName.Size = new System.Drawing.Size(243, 108);
            this.lsbx_DebitorsName.TabIndex = 10;
            this.lsbx_DebitorsName.ValueMember = "ID";
            this.lsbx_DebitorsName.SelectedIndexChanged += new System.EventHandler(this.lsbx_Debitors_SelectedIndexChanged);
            // 
            // lsbx_DebitorsID
            // 
            this.lsbx_DebitorsID.DisplayMember = "ID";
            this.lsbx_DebitorsID.FormattingEnabled = true;
            this.lsbx_DebitorsID.Location = new System.Drawing.Point(76, 45);
            this.lsbx_DebitorsID.Name = "lsbx_DebitorsID";
            this.lsbx_DebitorsID.Size = new System.Drawing.Size(243, 108);
            this.lsbx_DebitorsID.TabIndex = 9;
            this.lsbx_DebitorsID.ValueMember = "ID";
            this.lsbx_DebitorsID.SelectedIndexChanged += new System.EventHandler(this.lsbx_Debitors_SelectedIndexChanged);
            // 
            // btn_PassNewPayment
            // 
            this.btn_PassNewPayment.Location = new System.Drawing.Point(6, 348);
            this.btn_PassNewPayment.Name = "btn_PassNewPayment";
            this.btn_PassNewPayment.Size = new System.Drawing.Size(562, 23);
            this.btn_PassNewPayment.TabIndex = 8;
            this.btn_PassNewPayment.Text = "Pass New Payment";
            this.btn_PassNewPayment.UseVisualStyleBackColor = true;
            this.btn_PassNewPayment.Click += new System.EventHandler(this.btn_PassNewPayment_Click);
            // 
            // lbl_PaymentAmount
            // 
            this.lbl_PaymentAmount.AutoSize = true;
            this.lbl_PaymentAmount.Location = new System.Drawing.Point(6, 296);
            this.lbl_PaymentAmount.Name = "lbl_PaymentAmount";
            this.lbl_PaymentAmount.Size = new System.Drawing.Size(43, 13);
            this.lbl_PaymentAmount.TabIndex = 6;
            this.lbl_PaymentAmount.Text = "Amount";
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
            // lbl_PaymentID
            // 
            this.lbl_PaymentID.AutoSize = true;
            this.lbl_PaymentID.Location = new System.Drawing.Point(6, 22);
            this.lbl_PaymentID.Name = "lbl_PaymentID";
            this.lbl_PaymentID.Size = new System.Drawing.Size(62, 13);
            this.lbl_PaymentID.TabIndex = 4;
            this.lbl_PaymentID.Text = "Payment ID";
            // 
            // txbx_PaymentAmount
            // 
            this.txbx_PaymentAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbx_PaymentAmount.Location = new System.Drawing.Point(76, 293);
            this.txbx_PaymentAmount.MaxLength = 12;
            this.txbx_PaymentAmount.Name = "txbx_PaymentAmount";
            this.txbx_PaymentAmount.Size = new System.Drawing.Size(216, 20);
            this.txbx_PaymentAmount.TabIndex = 2;
            this.txbx_PaymentAmount.TextChanged += new System.EventHandler(this.txbx_PaymentAmount_TextChanged);
            this.txbx_PaymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_PaymentAmount_KeyPress);
            this.txbx_PaymentAmount.Leave += new System.EventHandler(this.txbx_PaymentAmount_Leave);
            // 
            // txbx_PaymentID
            // 
            this.txbx_PaymentID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_PaymentID.Location = new System.Drawing.Point(76, 19);
            this.txbx_PaymentID.Name = "txbx_PaymentID";
            this.txbx_PaymentID.ReadOnly = true;
            this.txbx_PaymentID.Size = new System.Drawing.Size(492, 20);
            this.txbx_PaymentID.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(73, 159);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 21;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(243, 159);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 22;
            this.lbl_Amount.Text = "Amount";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Location = new System.Drawing.Point(407, 159);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(46, 13);
            this.lbl_Balance.TabIndex = 23;
            this.lbl_Balance.Text = "Balance";
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 404);
            this.Controls.Add(this.grbx_CreditDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPaymentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Payment";
            this.grbx_CreditDetails.ResumeLayout(false);
            this.grbx_CreditDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_CreditDetails;
        private System.Windows.Forms.Label lbl_StatusLabel;
        private System.Windows.Forms.Label lbl_AmountStatus;
        private System.Windows.Forms.Label lbl_PaymentDate;
        private System.Windows.Forms.DateTimePicker dtp_PaymentDate;
        private System.Windows.Forms.ListBox lsbx_DebitorsName;
        private System.Windows.Forms.ListBox lsbx_DebitorsID;
        private System.Windows.Forms.Button btn_PassNewPayment;
        private System.Windows.Forms.Label lbl_PaymentAmount;
        private System.Windows.Forms.Label lbl_Debitor;
        private System.Windows.Forms.Label lbl_PaymentID;
        private System.Windows.Forms.TextBox txbx_PaymentAmount;
        private System.Windows.Forms.TextBox txbx_PaymentID;
        private System.Windows.Forms.ListBox lsbx_CreditBalance;
        private System.Windows.Forms.ListBox lsbx_CreditAmount;
        private System.Windows.Forms.ListBox lsbx_CreditID;
        private System.Windows.Forms.Label lbl_Credit;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_ID;
    }
}