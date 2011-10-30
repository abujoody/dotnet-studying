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
        const char delimeter = '|';
        string previousString = "";
        StringComparison currentComparisonType = StringComparison.CurrentCulture;

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
                changeInitialDirectory();

                StringBuilder fileNames = new StringBuilder();
                foreach (string fileName in openFileDialog.FileNames)
                {
                    fileNames.AppendFormat("{0}{1}", fileName, delimeter);
                }

                fileNamePreviewTextBox.Text = fileNames.ToString().TrimEnd(delimeter);
            }
        }

        private void addFileToListButton_Click(object sender, EventArgs e)
        {
            if (fileNamePreviewTextBox.Text == "")
                return;
            
            string[] fileNames = fileNamePreviewTextBox.Text.Split(delimeter);
            foreach (string fileName in fileNames)
            {
                if (!filesToSearchListBox.Items.Contains(fileName))
                {
                    filesToSearchListBox.Items.Add(fileName);
                }
            }
        }

        private void filesToSearchListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            filesToSearchListBox.Items.Remove(filesToSearchListBox.SelectedItem);
        }

        private void findStringButton_Click(object sender, EventArgs e)
        {
            string stringToSearch = stringToSearchTextBox.Text;
            StringComparison newComparisonType = caseInsensitiveCheckBox.Checked ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
            if (stringToSearch != "" && (stringToSearch != previousString || currentComparisonType != newComparisonType))
            {
                previousString = stringToSearch;
                currentComparisonType = newComparisonType;

                resultsListBox.BeginUpdate();

                resultsListBox.Items.Clear();
                StringSearchResult result = new StringSearchResult();
                foreach (Object filePath in filesToSearchListBox.Items)
                {
                    result = searchInFile((string)filePath, stringToSearch, currentComparisonType);
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
        private StringSearchResult searchInFile(string path, string str, StringComparison comparisonType)
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
                    index = fileContent.IndexOf(str, index, comparisonType);
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
        private void changeInitialDirectory()
        {
            openFileDialog.InitialDirectory = openFileDialog.FileName.Remove(openFileDialog.FileName.LastIndexOf('\\'));
        }
        #endregion
    }
}
