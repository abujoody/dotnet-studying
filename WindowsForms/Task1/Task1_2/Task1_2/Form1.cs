using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task1_2
{
    public partial class MainForm : Form
    {
        const int minNumber = 1;
        const int maxNumber = 2000 + 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnClickStartGame(object sender, MouseEventArgs e)
        {
            int leftBorder = minNumber;
            int rightBorder = maxNumber;

            int iterationsCount = 0;
            while (true)
            {
                if (leftBorder == rightBorder)
                {
                    MessageBox.Show("I know that your number is " + leftBorder);
                    break;
                }

                int guessNumber = (leftBorder + rightBorder) / 2;
                ++iterationsCount;
                string guessString = string.Format("****** Is {0} your number? ******", guessNumber);
                DialogResult answer = MessageBox.Show(guessString, "Guess: " + iterationsCount + " Number: " + guessNumber, MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    MessageBox.Show("Your number: " + guessNumber + ". Iterations: " + iterationsCount);
                    break;
                }
                else if (answer == DialogResult.No)
                {
                    //Change range
                    string guessRangeString = string.Format("****** Is your number more than {0}? ******", guessNumber);
                    DialogResult moreThanAnswer = MessageBox.Show(guessRangeString, guessNumber.ToString(), MessageBoxButtons.YesNo);
                    if (moreThanAnswer == DialogResult.Yes)
                    {
                        leftBorder = guessNumber;
                    }
                    else if (moreThanAnswer == DialogResult.No)
                    {
                        rightBorder = guessNumber;
                    }
                }
                else if (answer == DialogResult.Cancel)
                {
                    break;
                }
            }
        }
    }
}
