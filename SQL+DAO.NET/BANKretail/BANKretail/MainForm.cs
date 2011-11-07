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
    }
}
