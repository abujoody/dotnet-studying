using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task3_2
{
    public partial class MainForm : Form
    {
        struct SimpleDate
        {
            public int year;
            public int month;
            public int day;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToShortDateString();
        }

        private void calcTimeButton_Click(object sender, EventArgs e)
        {
            SimpleDate date = new SimpleDate();
            if (parseDate(dateTextBox.Text, ref date))
            {
                DateTime dt = new DateTime();
                try
                {
                    dt = new DateTime(date.year, date.month, date.day);
                }
                catch
                {
                    MessageBox.Show("Sorry, data is out of range");
                    return;
                }

                DateTime now = DateTime.Now;
                if (dt.CompareTo(now) >= 0)
                {
                    DateTimeOffset dto = new DateTimeOffset(dt);
                    DateTimeOffset newo = new DateTimeOffset(now);

                    TimeSpan timeOffset = dto.Subtract(newo);

                    if (daysRadioButton.Checked == true)
                    {
                        resultTimeTextBox.Text = Convert.ToString(Math.Round(timeOffset.TotalDays, 2));
                    }
                    else if (minutesRadioButton.Checked == true)
                    {
                        resultTimeTextBox.Text = Convert.ToString(Math.Round(timeOffset.TotalMinutes, 2));
                    }
                    else if (secondsRadioButton.Checked == true)
                    {
                        resultTimeTextBox.Text = Convert.ToString(Math.Round(timeOffset.TotalSeconds, 2));
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, this date has already come", "Error");
                }
            }
        }

        private bool parseDate(string date, ref SimpleDate result)
        {
            string[] tokens = date.Split('.');
            if (tokens.Length != 3)
            {
                MessageBox.Show("Incorrect Data Format", "Error");
                return false;
            }

            try
            {
                result.day = int.Parse(tokens[0]);
                result.month = int.Parse(tokens[1]);
                result.year = int.Parse(tokens[2]);
                return true;
            }
            catch
            {
                MessageBox.Show("Incorrect Data Format", "Error");
                return false;
            }
        }
    }
}
