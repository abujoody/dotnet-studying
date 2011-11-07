using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;

namespace BANKretail
{
    //Data Access Layer
    class DAL
    {
        public ArrayList GetAllDebitors()
        {
            //Connection params
            //For sql server authentification we must use uid and pwd fields instead of integrated security 
            string connectionString = @"Data Source=WIN-Q9KSS3JTNEI\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=true;";

            ArrayList allDebitors = new ArrayList();

            //Step 1: create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Step 2: create encapsulated sql request
                SqlCommand command = new SqlCommand("SELECT * FROM Debitors ORDER BY Name", connection);

                try
                {
                    //Step 3: open a database connection
                    connection.Open();

                    //Step 4: perform request
                    SqlDataReader reader = command.ExecuteReader();

                    //Step 5: extract data
                    if (reader.HasRows)
                    {
                        foreach (DbDataRecord dr in reader)
                        {
                            allDebitors.Add(dr);
                        }
                    }
                }
                catch
                {

                }
            }

            return allDebitors;
        }
    }
}
