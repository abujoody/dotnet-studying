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

            dgv_Credits.DataSource = dal.GetAllCreditsForDebitor(dgv_Debitors.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_Debitors.CellEnter +=new DataGridViewCellEventHandler(dgv_Debitors_CellEnter);
        }
    }
}
