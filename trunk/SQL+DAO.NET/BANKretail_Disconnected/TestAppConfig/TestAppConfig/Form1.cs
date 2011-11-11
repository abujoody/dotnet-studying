using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace TestAppConfig
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BANKConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                List<string> allNames = new List<string>();

                SqlCommand com = new SqlCommand("SELECT [Name] FROM debitors;", con);

                try
                {
                    con.Open();
                    SqlDataReader rd = com.ExecuteReader();

                    if (rd.HasRows)
                    {
                        foreach (DbDataRecord dbr in rd)
                        {
                            allNames.Add(dbr[0].ToString());
                        }
                    }

                    Console.WriteLine("OK !!!!");

                    foreach (string s in allNames)
                        Console.WriteLine(s);
                }
                catch
                {
                    Console.WriteLine("Error !!!!");
                }
            }
        }
    }
}
