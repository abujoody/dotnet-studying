using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BANKretail
{
    public partial class NewDebitorForm : Form
    {
        DAL dal = new DAL();

        public NewDebitorForm()
        {
            InitializeComponent();

            txbx_DebitorID.Text = Guid.NewGuid().ToString();
        }

        private void btn_SaveNewDebitor_Click(object sender, EventArgs e)
        {
            bool success = dal.SaveNewDebitor(txbx_DebitorID.Text.Trim(),
                            txbx_DebitorName.Text.Trim(),
                            txbx_DebitorPostNumber.Text.Trim(),
                            txbx_DebitorPhoneNumber.Text.Trim());

            if (success)
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
