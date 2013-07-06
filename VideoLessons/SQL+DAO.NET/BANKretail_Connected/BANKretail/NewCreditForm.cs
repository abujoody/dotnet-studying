using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BANKretail
{
    public partial class NewCreditForm : Form
    {
        ArrayList allDebitors;
        DAL dal = new DAL();

        public NewCreditForm()
        {
            InitializeComponent();
            txbx_CreditID.Text = Guid.NewGuid().ToString();

            allDebitors = dal.GetAllDebitors();
            if (allDebitors == null || allDebitors.Count != 0)
            {
                lsbx_DebitorsID.DataSource = allDebitors;
                lsbx_DebitorsName.DataSource = allDebitors;
            }
            else
            {
                lsbx_DebitorsID.Items.Add("No Debitors");
                lsbx_DebitorsName.Items.Add("No Debitors");
                txbx_CreditAmount.Enabled = false;
                txbx_CreditBalance.Enabled = false;
            }

            btn_OpenNewCredit.Enabled = false;
        }

        private void txbx_CreditAmount_TextChanged(object sender, EventArgs e)
        {
            txbx_CreditBalance.Text = txbx_CreditAmount.Text;
            btn_OpenNewCredit.Enabled = (txbx_CreditAmount.Text == String.Empty) ? false : true;
        }

        private void btn_OpenNewCredit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dal.SaveNewCredit(
                        new Guid(txbx_CreditID.Text),
                        new Guid(lsbx_DebitorsID.SelectedValue.ToString()),
                        Int32.Parse(txbx_CreditAmount.Text),
                        Int32.Parse(txbx_CreditBalance.Text),
                        dtp_CreditOpenDate.Value)
                    )
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
            catch
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        const char backspaceKey = (char)8;
        private void txbx_CreditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != backspaceKey)
                e.Handled = true;
        }

        private void txbx_CreditAmount_Leave(object sender, EventArgs e)
        {
            if (txbx_CreditAmount.Text == string.Empty)
            {
                lbl_AmountStatus.Text = "Type Credit Amount";
                lbl_AmountStatus.ForeColor = Color.Black;
            }
            else if (Int32.Parse(txbx_CreditAmount.Text.Trim()) < 100 ||
                  Int32.Parse(txbx_CreditAmount.Text.Trim()) > 10000000)
            {
                lbl_AmountStatus.Text = "Available Range Is [100; 10000000]";
                lbl_AmountStatus.ForeColor = Color.Red;
                btn_OpenNewCredit.Enabled = false;
            }
            else
            {
                lbl_AmountStatus.Text = "OK";
                lbl_AmountStatus.ForeColor = Color.Green;
            }
        }
    }
}
