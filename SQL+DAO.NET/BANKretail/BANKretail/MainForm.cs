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
    public partial class MainForm : Form
    {
        DAL dal = new DAL();

        public MainForm()
        {
            InitializeComponent();

            ArrayList allDebitors = dal.GetAllDebitors();
            dgv_Debitors.DataSource = allDebitors;
            SettingsDGV_Debitors();
        }

        void SettingsDGV_Debitors()
        {
            try
            {
                dgv_Debitors.Columns["ID"].Visible = false; //We don't want see ID
                dgv_Debitors.Columns["PostNumber"].Visible = false; //We don't want see Postal number
                dgv_Debitors.Columns["PhoneNumber"].Visible = false; //We don't want see Phone number

                dgv_Debitors.TopLeftHeaderCell.Value = "#";
            }
            catch
            {

            }
        }

        private void dgv_Debitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbx_DebitorID.Text = dgv_Debitors.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbx_DebitorName.Text = dgv_Debitors.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbx_DebitorPostNumber.Text = dgv_Debitors.Rows[e.RowIndex].Cells[2].Value.ToString();

            string phone = dgv_Debitors.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbx_DebitorPhoneNumber.Text = (phone == string.Empty) ? "No data" : phone;

            ArrayList allCredits = dal.GetAllCreditsForDebitor(dgv_Debitors.CurrentRow.Cells["ID"].Value.ToString());
            dgv_Credits.DataSource = allCredits;
            if (allCredits == null || allCredits.Count == 0)
                dgv_Payments.DataSource = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_Debitors.CellEnter +=new DataGridViewCellEventHandler(dgv_Debitors_CellEnter);
            dgv_Credits.CellEnter += new DataGridViewCellEventHandler(dgv_Credits_CellEnter);
        }

        void dgv_Credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string creditID = dgv_Credits.CurrentRow.Cells[0].Value.ToString();
            dgv_Payments.DataSource = dal.GetAllPaymentsForCredit(creditID);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want exit?", "Bank Manager", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDebitorForm newDebitor = new NewDebitorForm();

            DialogResult dr = newDebitor.ShowDialog();
            if (dr == DialogResult.OK)
            {                
                dgv_Debitors.DataSource = dal.GetAllDebitors();
                MessageBox.Show("New Debitor Has Been Created Successfully", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (dr == DialogResult.Abort)
            {
                MessageBox.Show("New Debitor Hasn't Been Created", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openNewCredtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCreditForm newCredit = new NewCreditForm();

            DialogResult dr = newCredit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dgv_Credits.DataSource = dal.GetAllCreditsForDebitor(dgv_Debitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("New Credit Has Been Opened Successfully", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (dr == DialogResult.Abort)
            {
                MessageBox.Show("New Credit Hasn't Been Opened", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void passNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPaymentForm newPayment = new NewPaymentForm();

            DialogResult dr = newPayment.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dgv_Credits.DataSource = dal.GetAllCreditsForDebitor(dgv_Debitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("New Payment Has Been Passed Successfully", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (dr == DialogResult.Abort)
            {
                MessageBox.Show("New Payments Hasn't Been Passed", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveDataToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.SaveDBToLocalFile())
            {
                MessageBox.Show("DataBase Has Been Saved Succesfully", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("DataBase Hasn't Been Saved", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object headerValue = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (headerValue == null)
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        List<DataGridViewRow> searchedRows;
        int currentRow;
        private void btn_Find_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            string debName = txbx_SearchDebitorName.Text.Trim();
            string debPostNumber = txbx_SearchDebitorPostNumber.Text.Trim();
            string debPhoneNumber = txbx_SearchDebitorPhone.Text.Trim();

            foreach (DataGridViewRow row in dgv_Debitors.Rows)
            {
                if (
                    row.Cells["Name"].FormattedValue.ToString().Contains(debName) &&
                    row.Cells["PostNumber"].FormattedValue.ToString().Contains(debPostNumber) &&
                    row.Cells["PhoneNumber"].FormattedValue.ToString().Contains(debPhoneNumber)
                   )
                {
                    searchedRows.Add(row);
                }
            }

            if (searchedRows.Count == 0)
            {
                MessageBox.Show("No Records Found", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_FindNext.Enabled = false;
                return;
            }

            MessageBox.Show(searchedRows.Count + " Record(s) Found", "Bank Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btn_FindNext.Enabled = true;
            currentRow = 0;
            dgv_Debitors.CurrentCell = searchedRows[currentRow].Cells[1];
        }

        private void btn_FindNext_Click(object sender, EventArgs e)
        {
            if (currentRow == searchedRows.Count - 1)
                currentRow = 0;
            else
                currentRow++;

            dgv_Debitors.CurrentCell = searchedRows[currentRow].Cells[1];
        }
    }
}
