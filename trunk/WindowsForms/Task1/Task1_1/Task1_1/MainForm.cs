using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task1_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            string[] captions = new string[] {"Name", "Education", "Work experience", "Hobbies", "Wishes"};
            string[] messages = new string[] { "Artem Diatlov", "National University KPI", "SMK", "Skating, Swimming, football, basketball", "To be happy and love again ..................." };

            int totalSymbols = 0;
            for (int i = 0; i < messages.Length; ++i)
            {
                totalSymbols += messages[i].Length;
                if (i != messages.Length - 1)
                    MessageBox.Show(messages[i], captions[i]);
                else
                    MessageBox.Show(messages[i], captions[i] + " (Average symbols count:" + (totalSymbols / messages.Length) + ")");
            }
        }
    }
}
