using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task4_1
{
    public partial class MainForm : Form
    {
        List<int> numbers;

        Random r;

        const int minCount = 5;
        const int maxCount = 10;

        const int minNumber = -10;
        const int maxNumber = 10;

        public MainForm()
        {
            InitializeComponent();

            numbers = new List<int>();
            r = new Random((int)DateTime.Now.Ticks);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            numbersListBox.Items.Clear();

            int totalNumbers = r.Next(minCount, maxCount + 1);

            for (int i = 0; i < totalNumbers; ++i)
            {
                int nextNumber = r.Next(minNumber, maxNumber + 1);
                if (nextNumber == 0)
                {
                    --i;
                    continue;
                }
                numbers.Add(nextNumber);
                numbersListBox.Items.Add(nextNumber);
            }

            updateResult();
        }

        private int calcSum()
        {
            int result = 0;
            foreach (int num in numbers)
            {
                result += num;
            }
            return result;
        }

        private long calcProduct()
        {
            long result = 1;
            foreach (int num in numbers)
            {
                result *= num;
            }
            return result;
        }

        private double calcAverage()
        {
            double result = 0.0;
            foreach (int num in numbers)
            {
                result += num;
            }
            return Math.Round(result / numbers.Count, 2);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true)
            {
                updateResult();
            }
        }

        private void updateResult()
        {
            if (sumRadioButton.Checked == true)
            {
                int result = calcSum();
                resultValueLabel.Text = Convert.ToString(result);
            }
            else if (productRadioButton.Checked == true)
            {
                long result = calcProduct();
                resultValueLabel.Text = Convert.ToString(result);
            }
            else if (averageRadioButton.Checked == true)
            {
                double result = calcAverage();
                resultValueLabel.Text = Convert.ToString(result);
            }
        }
    }
}
