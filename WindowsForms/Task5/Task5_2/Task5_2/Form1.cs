using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task5_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileNamePreviewTextBox.Text = openFileDialog.FileName;
            }
        }

        private void addFileToListButton_Click(object sender, EventArgs e)
        {
            if (fileNamePreviewTextBox.Text != "" && !filesToSearchListBox.Items.Contains(fileNamePreviewTextBox.Text))
            {
                filesToSearchListBox.Items.Add(fileNamePreviewTextBox.Text);
            }
        }

        private void filesToSearchListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            filesToSearchListBox.Items.Remove(filesToSearchListBox.SelectedItem);
        }
    }
}
