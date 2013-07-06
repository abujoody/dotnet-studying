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

            btn_SaveNewDebitor.Enabled = false;
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

        private void txbx_DebitorName_TextChanged(object sender, EventArgs e)
        {
            checkForAbilityToSaveNewDebitor();
        }

        private void txbx_DebitorPostNumber_TextChanged(object sender, EventArgs e)
        {
            checkForAbilityToSaveNewDebitor();
        }

        private void checkForAbilityToSaveNewDebitor()
        {
            btn_SaveNewDebitor.Enabled = (txbx_DebitorName.Text != String.Empty) &&
                                         (txbx_DebitorPostNumber.Text != String.Empty);
        }
    }
}
