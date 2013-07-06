using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Task3_1
{
    public partial class MainForm : Form
    {
        ArrayList numbersAdditions;
        int[] baseNumbers;
        const int baseNumbersCount = 28;

        public MainForm()
        {
            InitializeComponent();

            baseNumbers = new int[baseNumbersCount];
            for (int i = 0; i < baseNumbersCount; ++i)
            {
                baseNumbers[i] = i + 1;
            }

            numbersAdditions = new ArrayList();
            numbersAdditions.Add(new int[] { 29, 30, 31 });  //January
            numbersAdditions.Add(new int[] { 29 });          //February (29 - optional)
            numbersAdditions.Add(new int[] { 29, 30, 31 });  //March
            numbersAdditions.Add(new int[] { 29, 30 });      //April
            numbersAdditions.Add(new int[] { 29, 30, 31 });  //May
            numbersAdditions.Add(new int[] { 29, 30 });      //June
            numbersAdditions.Add(new int[] { 29, 30, 31 });  //July
            numbersAdditions.Add(new int[] { 29, 30, 31 });  //August
            numbersAdditions.Add(new int[] { 29, 30 });      //September
            numbersAdditions.Add(new int[] { 29, 30, 31 });  //October
            numbersAdditions.Add(new int[] { 29, 30 });      //November
            numbersAdditions.Add(new int[] { 29, 30, 31 });  //December
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setupNumberComboBox();
        }

        private void yearUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex == 1) //check for month February
            {
                setupNumberComboBox();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set current date values
            DateTime currentDate = DateTime.Now;
            yearUpDown.Value = currentDate.Year;
            monthComboBox.SelectedIndex = currentDate.Month - 1;
            numberComboBox.SelectedIndex = currentDate.Day - 1;
        }

        private void setupNumberComboBox()
        {
            //Collect all possible numbers for current month
            ArrayList newMonthNumbersStaff = new ArrayList(baseNumbers);
            newMonthNumbersStaff.AddRange((ICollection)numbersAdditions[monthComboBox.SelectedIndex]);

            //Check for Long year if month is February (index 1)
            if (monthComboBox.SelectedIndex == 1 && !isYearLong((int)yearUpDown.Value))
            {
                newMonthNumbersStaff.RemoveAt(newMonthNumbersStaff.Count - 1);
            }

            //Set new items to number comboBox
            int oldIndex = numberComboBox.SelectedIndex;
            numberComboBox.Items.Clear();
            numberComboBox.Items.AddRange(newMonthNumbersStaff.ToArray());
            numberComboBox.SelectedIndex = oldIndex < numberComboBox.Items.Count ? oldIndex : 0;
        }

        //returns does year consists of 366 days
        private bool isYearLong(int year)
        {
            return year % 4 == 0;
        }

        private void calcDayButton_Click(object sender, EventArgs e)
        {
            int year = (int)yearUpDown.Value;
            int month = monthComboBox.SelectedIndex + 1;
            int number = numberComboBox.SelectedIndex + 1;
            DateTime resultDate = new DateTime(year, month, number);

            dayOfWeekLabel.Text = resultDate.DayOfWeek.ToString();
        }
    }
}
