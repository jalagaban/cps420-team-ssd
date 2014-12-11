// The core model-layer class. Mediates access between the application and the server-side database.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Production
{
    public class DatabaseAgent
    {
        private static readonly string connectionString = "server=158.158.143.243, 1434\teamssd; database=CheckPasser; Integrated Security=false; PWD=Te@m$$D; UID=sa";

        private static DatabaseAgent defaultAgent;

        public static DatabaseAgent DefaultAgent
        {
           get 
           {
               if (defaultAgent == null)
               {
                   defaultAgent = new DatabaseAgent();
               }
               return defaultAgent;
           }
        }
        
        /* Clears the database and repopulates it with a standard set of test data */
        public void ResetTestData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_ResetData]", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteReader();
            }

        }

        public void ResetProduction()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_ResetProduction]", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteReader();
            }

        }

        
        /* Check Access */

        /* A list containing the primary keys of all checks in the database. 
         Each key is a tuple containing the three identifiying attributes of a check.
         These attributes as ordered in the tuple are the RoutingNum, AccountNum, and CheckNum. */
        public List<Tuple<string, string, string>> CheckKeys
        {
            get 
            {
                List<Tuple<string, string, string>> result = new List<Tuple<string, string, string>>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    SqlCommand cmd = new SqlCommand("SELECT [AcctNum] ,[RoutNum] ,[ChkNum] FROM [CheckPasser].[dbo].[Check]", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(Tuple.Create((String)reader["RoutNum"], (String)reader["AcctNum"], (String)reader["ChkNum"]));
                    }
                }

                return result;
            }
        }

        public bool CheckExists(Tuple<string, string, string> key)
        {
            bool result = false;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select 1 from [CheckPasser].[dbo].[Check] where [RoutNum] = @Rout AND [AcctNum] = @Acct AND [ChkNum] = @Chk", connection);
              
                cmd.Parameters.AddWithValue("@Rout", key.Item1);
                cmd.Parameters.AddWithValue("@Acct", key.Item2);
                cmd.Parameters.AddWithValue("@Chk", key.Item3);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = true; 
                }
            }

            return result;
        } 

        public Check GetCheck(Tuple<string, string, string> key)
        {
            Check result = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [CheckPasser].[dbo].[Check]" +
                                                "where [RoutNum] = @Rout AND [AcctNum] = @Acct AND [ChkNum] = @Chk", connection);
                cmd.Parameters.AddWithValue("@Rout", key.Item1);
                cmd.Parameters.AddWithValue("@Acct", key.Item2);
                cmd.Parameters.AddWithValue("@Chk", key.Item3);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = new Check();
                    result.RoutingNum = (String)reader["RoutNum"];
                    result.AccountNum = (String)reader["AcctNum"];
                    result.CheckNum = (String)reader["ChkNum"];
                    result.Amount = (int)reader["ChkAmt"];
                    result.Date = (DateTime)reader["ChkDate"];
                    result.IsPaid = (bool)reader["Paid"];
                    result.StoreID = (String)reader["StoreID"];
                    result.CashierID = (String)reader["CashID"];

                    int ord = reader.GetOrdinal("LetterA");
                    result.LetterADate = reader.IsDBNull(ord) ? (DateTime?)null : reader.GetDateTime(ord);
                    ord = reader.GetOrdinal("LetterB");
                    result.LetterBDate = reader.IsDBNull(ord) ? (DateTime?)null : reader.GetDateTime(ord);
                    ord = reader.GetOrdinal("LetterC");
                    result.LetterCDate = reader.IsDBNull(ord) ? (DateTime?)null : reader.GetDateTime(ord);
                }
            }

            return result; ;
        }

        public void AddCheck(Check check)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [CheckPasser].[dbo].[Check] (RoutNum, AcctNum, ChkNum, ChkAmt, ChkDate, Paid, StoreID, CashID, LetterA, LetterB, LetterC)" +
                                                "VALUES (@Rout, @Acct, @Chk, @Amount, @Date, @Paid, @Store, @Cashier, @LetterA, @LetterB, @LetterC)", connection);
                cmd.Parameters.AddWithValue("@Rout", check.RoutingNum);
                cmd.Parameters.AddWithValue("@Acct", check.AccountNum);
                cmd.Parameters.AddWithValue("@Chk", check.CheckNum);
                cmd.Parameters.AddWithValue("@Amount", check.Amount);
                cmd.Parameters.AddWithValue("@Date", check.Date);
                cmd.Parameters.AddWithValue("@Paid", check.IsPaid);
                cmd.Parameters.AddWithValue("@Store", check.StoreID);
                cmd.Parameters.AddWithValue("@Cashier", check.CashierID);
                cmd.Parameters.AddWithValue("@LetterA", (object)check.LetterADate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LetterB", (object)check.LetterBDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LetterC", (object)check.LetterCDate ?? DBNull.Value);
          
                cmd.ExecuteNonQuery();
            }
        } 

        public void UpdateCheck(Check check)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("UPDATE [CheckPasser].[dbo].[Check]" +
                                                "SET ChkAmt = @Amount, ChkDate = @Date, Paid = @Paid, StoreID = @Store, CashID = @Cashier, LetterA = @LetterA, LetterB = @LetterB, LetterC = @LetterC " +
                                                "where [RoutNum] = @Rout AND [AcctNum] = @Acct AND [ChkNum] = @Chk", connection);
                cmd.Parameters.AddWithValue("@Rout", check.RoutingNum);
                cmd.Parameters.AddWithValue("@Acct", check.AccountNum);
                cmd.Parameters.AddWithValue("@Chk", check.CheckNum);
                cmd.Parameters.AddWithValue("@Amount", check.Amount);
                cmd.Parameters.AddWithValue("@Date", check.Date);
                cmd.Parameters.AddWithValue("@Paid", check.IsPaid);
                cmd.Parameters.AddWithValue("@Store", check.StoreID);
                cmd.Parameters.AddWithValue("@Cashier", check.CashierID);
                cmd.Parameters.AddWithValue("@LetterA", (object)check.LetterADate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LetterB", (object)check.LetterBDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LetterC", (object)check.LetterCDate ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }    
        }

        public void DeleteCheck(Tuple<string, string, string> key)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [CheckPasser].[dbo].[Check]" +
                                                "where [RoutNum] = @Rout AND [AcctNum] = @Acct AND [ChkNum] = @Chk", connection);
                cmd.Parameters.AddWithValue("@Rout", key.Item1);
                cmd.Parameters.AddWithValue("@Acct", key.Item2);
                cmd.Parameters.AddWithValue("@Chk", key.Item3);

                cmd.ExecuteNonQuery();
            }
        }

        
        /* Account Access */

        /* A list containing the primary keys of all accounts in the database. 
        Each key is a tuple containing the two identifiying attributes of an account.
        These attributes as ordered in the tuple are the RoutingNum and AccountNum. */
        public List<Tuple<string, string>> AccountKeys
        {
            get
            {
                List<Tuple<string, string>> result = new List<Tuple<string, string>>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT [AcctNum] ,[RoutNum] FROM [CheckPasser].[dbo].[Account]", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(Tuple.Create((String)reader["RoutNum"], (String)reader["AcctNum"]));
                    }
                }

                return result;
            }
        }

        public bool AccountExists(Tuple<string, string> key)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select 1 from [CheckPasser].[dbo].[Account] where [RoutNum] = @Rout AND [AcctNum] = @Acct", connection);

                cmd.Parameters.AddWithValue("@Rout", key.Item1);
                cmd.Parameters.AddWithValue("@Acct", key.Item2);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = true;
                }
            }

            return result;
        }

        public bool AccountIsReferenced(Tuple<string, string> key)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select 1 from [CheckPasser].[dbo].[Check] where [RoutNum] = @Rout AND [AcctNum] = @Acct", connection);

                cmd.Parameters.AddWithValue("@Rout", key.Item1);
                cmd.Parameters.AddWithValue("@Acct", key.Item2);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = true;
                }
            }

            return result;
        }

        public Account GetAccount(Tuple<string, string> key)
        {
            Account result = null;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {                
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [CheckPasser].[dbo].[Account]" +
                                                "where [RoutNum] = @Rout AND [AcctNum] = @Acct", connection);
                cmd.Parameters.AddWithValue("@Rout", key.Item1);
                cmd.Parameters.AddWithValue("@Acct", key.Item2);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = new Account();
                    result.AccountNum = (String)reader["AcctNum"];
                    result.RoutingNum = (String)reader["RoutNum"];
                    result.FirstName = (String)reader["FirstName"];
                    result.LastName = (String)reader["LastName"];
                    result.Street = (String)reader["Street"];
                    result.City = (String)reader["City"];
                    result.State = (String)reader["State"];
                    result.Zipcode = (String)reader["Zipcode"];
                    result.PhoneNum = (String)reader["PhoneNum"];
                }
            }

            return result;
        }

        public void AddAccount(Account account)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [CheckPasser].[dbo].[Account] (RoutNum, AcctNum, FirstName, LastName, Street, City, State, Zipcode, PhoneNum)" +
                                                "VALUES (@Rout, @Acct, @FName, @LName, @Street, @City, @State, @Zipcode, @PhoneNum)", connection);
                cmd.Parameters.AddWithValue("@Rout", account.RoutingNum);
                cmd.Parameters.AddWithValue("@Acct", account.AccountNum);
                cmd.Parameters.AddWithValue("@FName", account.FirstName);
                cmd.Parameters.AddWithValue("@LName", account.LastName);
                cmd.Parameters.AddWithValue("@Street", account.Street);
                cmd.Parameters.AddWithValue("@City", account.City);
                cmd.Parameters.AddWithValue("@State", account.State);
                cmd.Parameters.AddWithValue("@Zipcode", account.Zipcode);
                cmd.Parameters.AddWithValue("@PhoneNum", account.PhoneNum);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAccount(Account account)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("UPDATE [CheckPasser].[dbo].[Account]" +
                                                "SET FirstName = @FName, LastName = @LName, Street = @Street, City = @City, State = @State, Zipcode = @Zipcode, PhoneNum = @PhoneNum " +
                                                "where [RoutNum] = @Rout AND [AcctNum] = @Acct", connection);
                cmd.Parameters.AddWithValue("@Rout", account.RoutingNum);
                cmd.Parameters.AddWithValue("@Acct", account.AccountNum);
                cmd.Parameters.AddWithValue("@FName", account.FirstName);
                cmd.Parameters.AddWithValue("@LName", account.LastName);
                cmd.Parameters.AddWithValue("@Street", account.Street);
                cmd.Parameters.AddWithValue("@City", account.City);
                cmd.Parameters.AddWithValue("@State", account.State);
                cmd.Parameters.AddWithValue("@Zipcode", account.Zipcode);
                cmd.Parameters.AddWithValue("@PhoneNum", account.PhoneNum);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAccount(Tuple<string, string> key)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [CheckPasser].[dbo].[Account]" +
                                                "where [RoutNum] = @Rout AND [AcctNum] = @Acct", connection);
                cmd.Parameters.AddWithValue("@Rout", key.Item1);
                cmd.Parameters.AddWithValue("@Acct", key.Item2);

                cmd.ExecuteNonQuery();
            }
        }

        
        /* Store Access */

        /* A list containing the primary keys of all stores in the database. 
         The primary key for a store is equivalent to its StoreNum. */
        public List<string> StoreKeys
        {
            get
            {
                List<string> result = new List<string>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT [StoreID] FROM [CheckPasser].[dbo].[Store]", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add((String)reader["StoreID"]);
                    }
                }

                return result;
            }
        }

        public bool StoreExists(string ID)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select 1 from [CheckPasser].[dbo].[Store] where [StoreID] = @ID", connection);

                cmd.Parameters.AddWithValue("@ID", ID);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = true;
                }
            }

            return result;
        }

        public bool StoreIsReferenced(string ID)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select 1 from [CheckPasser].[dbo].[Check] where [StoreID] = @ID", connection);

                cmd.Parameters.AddWithValue("@ID", ID);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = true;
                }
            }

            return result;
        }

        public Store GetStore(string ID)
        {
            Store result = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [CheckPasser].[dbo].[Store]" +
                                                "where [StoreID] = @Store", connection);
                cmd.Parameters.AddWithValue("@Store", ID);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = new Store();
                    result.ID = (String)reader["StoreID"];
                    result.Name = (String)reader["StoreName"];
                    result.Street = (String)reader["Street"];
                    result.City = (String)reader["City"];
                    result.State = (String)reader["State"];
                    result.Zipcode = (String)reader["Zipcode"];
                }
            }

            return result;
        }

        public void AddStore(Store store)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [CheckPasser].[dbo].[Store] (StoreID, StoreName, Street, City, State, Zipcode)" +
                                                "VALUES (@ID, @Name, @Street, @City, @State, @Zip)", connection);
                cmd.Parameters.AddWithValue("@ID", store.ID);
                cmd.Parameters.AddWithValue("@Name", store.Name);
                cmd.Parameters.AddWithValue("@Street", store.Street);
                cmd.Parameters.AddWithValue("@City", store.City);
                cmd.Parameters.AddWithValue("@State", store.State);
                cmd.Parameters.AddWithValue("@Zip", store.Zipcode);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStore(Store store)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("UPDATE [CheckPasser].[dbo].[Store]" +
                                                "SET StoreName = @Name, Street = @Street, City = @City, State = @State, Zipcode = @Zipcode " +
                                                "where [StoreID] = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", store.ID);
                cmd.Parameters.AddWithValue("@Name", store.Name);
                cmd.Parameters.AddWithValue("@Street", store.Street);
                cmd.Parameters.AddWithValue("@City", store.City);
                cmd.Parameters.AddWithValue("@State", store.State);
                cmd.Parameters.AddWithValue("@Zipcode", store.Zipcode);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStore(string ID)
        {
            // Delete store from database where store.ID == storeNum
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [CheckPasser].[dbo].[Store]" +
                                                "where [StoreID] = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
