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
    public partial class NewPaymentForm : Form
    {
        DAL dal = new DAL();
        ArrayList allDebitors;
        ArrayList allCredits;

        public NewPaymentForm()
        {
            InitializeComponent();

            txbx_PaymentID.Text = Guid.NewGuid().ToString();

            allDebitors = dal.GetAllDebitors();
            if (allDebitors == null || allDebitors.Count == 0)
            {
                btn_PassNewPayment.Enabled = false;
                txbx_PaymentAmount.Enabled = false;
            }
            else
            {
                btn_PassNewPayment.Enabled = true;
                txbx_PaymentAmount.Enabled = true;
            }

            lsbx_DebitorsID.DataSource = allDebitors;
            lsbx_DebitorsName.DataSource = allDebitors;

            btn_PassNewPayment.Enabled = false;
        }

        private void lsbx_Debitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            allCredits = dal.GetAllCreditsForDebitor(lsbx_DebitorsID.SelectedValue.ToString());
            lsbx_CreditID.DataSource = allCredits;
            lsbx_CreditAmount.DataSource = allCredits;
            lsbx_CreditBalance.DataSource = allCredits;

            lsbx_CreditID.ValueMember = "ID";
            lsbx_CreditID.DisplayMember = "ID";

            lsbx_CreditAmount.ValueMember = "ID";
            lsbx_CreditAmount.DisplayMember = "Amount";

            lsbx_CreditBalance.ValueMember = "Balance";
            lsbx_CreditBalance.DisplayMember = "Balance";

            if (allCredits == null || allCredits.Count == 0)
            {
                btn_PassNewPayment.Enabled = false;
                txbx_PaymentAmount.Enabled = false;
            }
            else
            {
                btn_PassNewPayment.Enabled = true;
                txbx_PaymentAmount.Enabled = true;
            }
        }

        private void txbx_PaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
                return;
            }

            if (e.KeyChar == ',')
            {
                if (txbx_PaymentAmount.Text.Trim().Contains(',') ||
                    txbx_PaymentAmount.Text == String.Empty)
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }
            }

            decimal res;
            if (decimal.TryParse(e.KeyChar.ToString(), out res))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbx_PaymentAmount_Leave(object sender, EventArgs e)
        {
            if (txbx_PaymentAmount.Text == string.Empty)
            {
                lbl_AmountStatus.Text = "Type Payment Amount";
                lbl_AmountStatus.ForeColor = Color.Black;
                btn_PassNewPayment.Enabled = false;
                return;
            }

            decimal payValue = decimal.Parse(txbx_PaymentAmount.Text.Trim());

            if (payValue < 100)
            {
                lbl_AmountStatus.Text = "Minimum Payment Is 100";
                lbl_AmountStatus.ForeColor = Color.Red;
                btn_PassNewPayment.Enabled = false;
                return;
            }

            if (payValue > decimal.Parse(lsbx_CreditBalance.SelectedValue.ToString()))
            {
                lbl_AmountStatus.Text = "Payment Must Be Either Less or Equal Balance";
                lbl_AmountStatus.ForeColor = Color.Red;
                btn_PassNewPayment.Enabled = false;
                return;
            }

            lbl_AmountStatus.Text = "OK";
            lbl_AmountStatus.ForeColor = Color.Green;
            btn_PassNewPayment.Enabled = true;
        }

        private void txbx_PaymentAmount_TextChanged(object sender, EventArgs e)
        {
            btn_PassNewPayment.Enabled = (txbx_PaymentAmount.Text != string.Empty);
            if (txbx_PaymentAmount.Text == string.Empty)
            {
                lbl_AmountStatus.Text = "Type Payment Amount";
                lbl_AmountStatus.ForeColor = Color.Black;
            }
        }

        private void btn_PassNewPayment_Click(object sender, EventArgs e)
        {
            decimal paymentAmount;
            if (!decimal.TryParse(txbx_PaymentAmount.Text.Trim(), out paymentAmount))
            {
                MessageBox.Show("Wrong Payment Amount", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (dal.SaveNewPayment
                            (
                                new Guid(txbx_PaymentID.Text.Trim()),
                                new Guid(lsbx_CreditID.Text.Trim()),
                                paymentAmount,
                                dtp_PaymentDate.Value
                            )
                    )
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
        }
    }
}
