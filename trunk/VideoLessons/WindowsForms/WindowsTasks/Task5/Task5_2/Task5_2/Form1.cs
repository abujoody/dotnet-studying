using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Task5_2
{
    public partial class MainForm : Form
    {
        delegate void AddSearchResultsDelegate(object result);

        const char delimeter = '|';
        string previousString = "";
        const string noResults = "No results found.";
        const string searchIsFinished = "Search is finished.";
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
            
            if (filesToSearchListBox.Items.Count != 0 && stringToSearch != "" && (stringToSearch != previousString || currentComparisonType != newComparisonType))
            {
                findStringButton.Enabled = false;

                previousString = stringToSearch;
                currentComparisonType = newComparisonType;

                resultsListBox.Items.Clear();

                Thread conveyerCreator = new Thread(new ParameterizedThreadStart(createConveyer));
                conveyerCreator.IsBackground = true;
                conveyerCreator.Start(stringToSearch);
            }
        }
        #endregion

        #region multihreaded search
        private void createConveyer(object data)
        {
            List<Thread> activeThreads = new List<Thread>(); 
            foreach (object filePath in filesToSearchListBox.Items)
            {
                string fileData = dataFromFile((string)filePath);
                if (fileData == null)
                    continue;

                Thread searchThread = new Thread(new ParameterizedThreadStart(performSearch));
                activeThreads.Add(searchThread);

                searchThread.IsBackground = true;
                string stringToSearch = (string)data; // overhead for more clear understanding
                object[] searchParams = new object[] { filePath, fileData, stringToSearch, currentComparisonType };
                searchThread.Start(searchParams);
            }

            foreach(Thread th in activeThreads)
            {
                th.Join();
            }

            if (resultsListBox.Items.Count == 0)
            {
                Invoke(new AddSearchResultsDelegate(addSearchResult), noResults);
            }
            Invoke(new AddSearchResultsDelegate(addSearchResult), searchIsFinished);

            Invoke(new MethodInvoker(setFindButtonEnabled));
        }

        private void setFindButtonEnabled()
        {
            findStringButton.Enabled = true;
        }

        private void performSearch(object data)
        {
            object[] searchParams = (object[])data;
            String filePath = (string)searchParams[0];
            String fileData = (string)searchParams[1];
            String stringToSearch = (string)searchParams[2];
            StringComparison comparisonType = (StringComparison)searchParams[3];          

            StringSearchResult result = searchInFile(filePath, fileData, stringToSearch, currentComparisonType);
            if (result.indexes.Count == 0)
                return;

            StringBuilder resultAsString = new StringBuilder();
            resultAsString.Append(result.path + ": ");
            foreach (int index in result.indexes)
            {
                resultAsString.AppendFormat("{0}, ", index);
            }
            string output = resultAsString.ToString().TrimEnd(' ', ',');

            Invoke(new AddSearchResultsDelegate(addSearchResult), output);
        }

        private void addSearchResult(object result)
        {
            resultsListBox.Items.Add(result);
        }
        #endregion

        #region Help private methods
        private string dataFromFile(string path)
        {
            string result;
            try
            {
                StreamReader fsr = new StreamReader(path);
                result = fsr.ReadToEnd();
                fsr.Close();
            }
            catch
            {
                result = null;
            }
            return result;
        }

        private StringSearchResult searchInFile(string path, string data, string stringToSearch, StringComparison comparisonType)
        {
            StringSearchResult result = new StringSearchResult();
            result.path = path;
            result.indexes = new List<int>();

            int index = 0;
            while (true)
            {
                index = data.IndexOf(stringToSearch, index, comparisonType);
                if (index == -1)
                    break;

                result.indexes.Add(index + 1);

                index += stringToSearch.Length;
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
