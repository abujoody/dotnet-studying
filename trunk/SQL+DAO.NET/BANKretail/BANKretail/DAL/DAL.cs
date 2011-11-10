using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;
using System.IO;

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
                SqlCommand command = new SqlCommand("GetAllCreditsForDebitor", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@debitorID";
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                param.Direction = System.Data.ParameterDirection.Input;
                param.Value = new Guid(debitorID);

                command.Parameters.Add(param);

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
                "VALUES (@ID, @DebitorID, @Amount, @Balance, @OpenDate)");

            bool flagResult = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                //query changed to parametrized for security reason
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = ID;
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DebitorID";
                param.Value = debitorID;
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Amount";
                param.Value = amount;
                param.SqlDbType = System.Data.SqlDbType.Money;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Balance";
                param.Value = balance;
                param.SqlDbType = System.Data.SqlDbType.Money;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@OpenDate";
                param.Value = openDate;
                param.SqlDbType = System.Data.SqlDbType.DateTime;
                com.Parameters.Add(param);

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

        public bool SaveDBToLocalFile()
        {
            bool result = true;

            string query;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    StreamWriter file = new StreamWriter(new FileStream("Debitors.csv", FileMode.Create), Encoding.GetEncoding(1251));

                    query = "SELECT * FROM Debitors";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    //CSV Format
                    file.WriteLine(@"""ID"";""Name"";""PostNumber"";""PhoneNumber""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" +
                            reader.GetString(1) + @""";""" +
                            reader[2].ToString() + @""";""" +
                            reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of of file");

                    file.Close();
                }
                catch
                {
                    result = false;
                }
            }

            if (result)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        StreamWriter file = new StreamWriter(new FileStream("Credits.csv", FileMode.Create), Encoding.GetEncoding(1251));

                        query = "SELECT * FROM Credits";
                        SqlCommand com = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader reader = com.ExecuteReader();

                        //CSV Format
                        file.WriteLine(@"""ID"";""DebitorID"";""Amount"";""Balance"";""OpenDate""");
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @""";""" +
                                reader[4].ToString() + @"""", Encoding.ASCII);
                            }
                        }
                        else
                        {
                            file.WriteLine("No one row to save");
                        }

                        file.WriteLine("End of of file");

                        file.Close();
                    }
                    catch
                    {
                        result = false;
                    }
                }
            }

            if (result)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        StreamWriter file = new StreamWriter(new FileStream("Payments.csv", FileMode.Create), Encoding.GetEncoding(1251));

                        query = "SELECT * FROM Payments";
                        SqlCommand com = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader reader = com.ExecuteReader();

                        //CSV Format
                        file.WriteLine(@"""ID"";""CreditID"";""Amount"";""OpenDate""");
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @"""", Encoding.ASCII);
                            }
                        }
                        else
                        {
                            file.WriteLine("No one row to save");
                        }

                        file.WriteLine("End of of file");

                        file.Close();
                    }
                    catch
                    {
                        result = false;
                    }
                }
            }

            return result;
        }

        public ArrayList searchByDebitor(string debName, string debPostNum, string debPhoneNum)
        {
            ArrayList searchedDebitors = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SearchByDebitor", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@debitorName";
                param.Value = debName;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@debitorPostNumber";
                param.Value = debPostNum;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@debitorPhoneNumber";
                param.Value = debPhoneNum;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                            searchedDebitors.Add(result);
                    }
                }
                catch(Exception)
                {

                }
            }

            return searchedDebitors;            
        }
    }
}
