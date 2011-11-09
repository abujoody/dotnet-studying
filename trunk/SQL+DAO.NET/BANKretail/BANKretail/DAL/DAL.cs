using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;

namespace BANKretail
{
    //Data Access Layer
    class DAL
    {
        //Connection params
        //For sql server authentification we must use uid and pwd fields instead of integrated security 
        string connectionString = @"Data Source=WIN-Q9KSS3JTNEI\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=true;";

        public ArrayList GetAllDebitors()
        {
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

        public ArrayList GetAllCreditsForDebitor(string debitorID)
        {
            ArrayList allCredits = new ArrayList();

            //Step 1: create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Step 2: create encapsulated sql request
                string query = String.Format("SELECT * FROM Credits WHERE DebitorID='{0}' ORDER BY OpenDate", debitorID);
                SqlCommand command = new SqlCommand(query, connection);

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
                            allCredits.Add(dr);
                        }
                    }
                }
                catch
                {

                }
            }

            return allCredits;
        }

        public object GetAllPaymentsForCredit(string creditID)
        {
            ArrayList allPayments = new ArrayList();

            //Step 1: create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Step 2: create encapsulated sql request
                string query = String.Format("SELECT * FROM Payments WHERE CreditID='{0}' ORDER BY PaymentDate DESC", creditID);
                SqlCommand command = new SqlCommand(query, connection);

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
                            allPayments.Add(dr);
                        }
                    }
                }
                catch
                {

                }
            }

            return allPayments;
        }

        // all types are string (because implicit conversion will take place anyway)
        public bool SaveNewDebitor(string ID, string Name,
            string PostNumber, string PhoneNumber)
        {
            bool flagResult = false;

            string query = string.Format("INSERT INTO Debitors " +
                "([ID], [Name], [PostNumber], [PhoneNumber]) " +
                "VALUES ('{0}', '{1}', {2}, '{3}')",
                ID, Name, PostNumber, (PhoneNumber != String.Empty) ? PhoneNumber : null);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }
            }

            return flagResult;
        }

        //Right way: arguments are of types similar to types database works
        public bool SaveNewCredit(Guid ID, Guid debitorID, int amount,
            decimal balance, DateTime openDate)
        {
            string query = String.Format(
                "INSERT INTO Credits " +
                "(ID, DebitorID, Amount, Balance, OpenDate) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                ID, debitorID, amount, balance, openDate);

            bool flagResult = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch(Exception)
                {

                }
            }

            return flagResult;            
        }

        public bool SaveNewPayment(Guid ID, Guid creditID, decimal paymentAmount, DateTime dateTime)
        {
            bool flag = true;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();
                SqlCommand com = con.CreateCommand();
                com.Transaction = transaction;

                try
                {
                    string paymentAmountString = paymentAmount.ToString(CultureInfo.InvariantCulture.NumberFormat);
                    string query = string.Format(
                        "INSERT INTO Payments (ID, CreditID, Amount, PaymentDate) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}')",
                        ID, creditID, paymentAmountString, dateTime);

                    com.CommandText = query;
                    com.ExecuteNonQuery();

                    query = string.Format("UPDATE Credits SET Balance = (Balance - {0}) WHERE ID = '{1}'",
                        paymentAmountString, creditID);
                    com.CommandText = query;
                    com.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    flag = false;
                }
                finally
                {
                    //for example
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Dispose();
                    }
                }
            }

            return flag;
        }
    }
}
