using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Task5_1
{
    public partial class MainForm : Form
    {
        SortedDictionary<string, List<string>> library;
        string currentFilter;

        const string allBooksFilter = "All Books";
        const string byAuthorFilter = "By Author";

        public MainForm()
        {
            InitializeComponent();

            library = new SortedDictionary<string,List<string>>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadLibrary();
            showAuthors();
            showBooks(allBooksFilter);

            filterComboBox.SelectedItem = allBooksFilter;
        }

        private void loadLibrary()
        {
            StreamReader fsr = new StreamReader("Library.txt");

            string tmp = null;
            string[] entities = new string[2];

            while (!fsr.EndOfStream)
            {
                tmp = fsr.ReadLine();
                entities = tmp.Split(',');

                entities[0] = entities[0].Trim(); //Author
                entities[1] = entities[1].Trim(); //Book

                if (!library.ContainsKey(entities[0]))
                {
                    library[entities[0]] = new List<string>();
                }
                library[entities[0]].Add(entities[1]);
            }

            fsr.Close();
        }

        private void showAuthors()
        {
            authorsListBox.Items.Clear();
            authorsListBox.BeginUpdate();
            foreach (KeyValuePair<string, List<string>> entity in library)
            {
                authorsListBox.Items.Add(entity.Key); //Author
            }
            authorsListBox.EndUpdate();
        }

        private void showBooks(string filter)
        {
            booksListBox.BeginUpdate();

            /////////
            booksListBox.Items.Clear();
            if (filter == allBooksFilter)
            {
                foreach (KeyValuePair<string, List<string>> entity in library)
                {
                    booksListBox.Items.Add(string.Format("--- {0} ---", entity.Key)); //Author
                    booksListBox.Items.AddRange(entity.Value.ToArray()); //Books
                    booksListBox.Items.Add("");
                }
            }
            else if (filter == byAuthorFilter)
            {
                string currentAuthor = (string)authorsListBox.SelectedItem;
                if (currentAuthor != null)
                {
                    booksListBox.Items.AddRange(library[currentAuthor].ToArray()); //Books
                }
            }
            booksListBox.EndUpdate();
            /////////
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newFilter = (string)filterComboBox.SelectedItem;
            if (newFilter != currentFilter)
            {
                currentFilter = newFilter;
                showBooks(currentFilter);
            }
        }

        private void authorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentFilter == byAuthorFilter)
            {
                showBooks(currentFilter);
            }
        }
    }
}
