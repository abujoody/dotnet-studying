using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Task5_2
{
    public partial class MainForm : Form
    {
        #region StringSearchResult type
        struct StringSearchResult
        {
            string _path;
            List<int> _indexes;

            public string path
            {
                get { return _path; }
                set { _path = value; }
            }

            public List<int> indexes
            {
                get { return _indexes; }
                set { _indexes = value; }
            }
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Message Handlers
        private void MainForm_Load(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
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

        private void findStringButton_Click(object sender, EventArgs e)
        {
            string stringToSearch = stringToSearchTextBox.Text;
            if (stringToSearch != "")
            {
                resultsListBox.BeginUpdate();

                resultsListBox.Items.Clear();
                StringSearchResult result = new StringSearchResult();
                foreach (Object filePath in filesToSearchListBox.Items)
                {
                    result = searchInFile((string)filePath, stringToSearch);
                    if (result.indexes.Count == 0)
                        continue;

                    StringBuilder resultAsString = new StringBuilder();
                    resultAsString.Append(result.path + ": ");
                    foreach (int index in result.indexes)
                    {
                        resultAsString.AppendFormat("{0}, ", index);
                    }
                    string output = resultAsString.ToString().TrimEnd(' ', ',');

                    resultsListBox.Items.Add(output);
                }

                resultsListBox.EndUpdate();
            }
        }
        #endregion

        #region Help private methods
        private StringSearchResult searchInFile(string path, string str)
        {
            StringSearchResult result = new StringSearchResult();
            result.path = path;
            result.indexes = new List<int>();

            try
            {
                StreamReader fsr = new StreamReader(path);
                string fileContent = fsr.ReadToEnd();
                fsr.Close();

                int index = 0;
                while (true)
                {
                    index = fileContent.IndexOf(str, index);
                    if (index == -1)
                        break;

                    result.indexes.Add(index + 1);

                    index += str.Length;
                }
            }
            catch
            {
                return result;
            }

            return result;
        }
        #endregion
    }
}
