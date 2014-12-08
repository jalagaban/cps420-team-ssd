// Manages application users and provides user authentication and user privilege-level lookup services


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Production
{
    public class AuthenticationManager
    {
        private static readonly string connectionString = "server=158.158.143.243, 1434\teamssd; database=CheckPasser; Integrated Security=false; PWD=Te@m$$D; UID=sa";

        private static AuthenticationManager defaultAuthenticationManager;

        public static AuthenticationManager DefaultAuthenticationManager
        {
            get
            {
                if (defaultAuthenticationManager == null)
                {
                    defaultAuthenticationManager = new AuthenticationManager();
                }
                return defaultAuthenticationManager;
            }
        }
        
        // Attempts to log in using the provided credentials. Returns true if login was successful and false if login failed.
        public bool AttemptLogin(string username, string password)
        {
            // Get user for given username
            try
            {
                User usr = GetUser(username);
                // Check user.Password against given password
                if (password.Equals(usr.Password)) { CurrentUser = usr;  return true; }
                // If equal, set CurrentUser to user and return true
                // else return false
            }
            catch { return false; }
            return false;
        }

        public void LogOut()
        {
            // Set CurrentUser to null
            CurrentUser = null;
        }

        // The currently logged-in user
        public User CurrentUser { get; set; }

        public List<string> UserNames
        {
            get
            {
                List<string> result = new List<string>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT [UserID] FROM [CheckPasser].[dbo].[User]", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add((String)reader["UserID"]);
                    }
                }

                return result;
            }
        }

        public bool UserExists(string username)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select 1 from [CheckPasser].[dbo].[User] where [UserID] = @UserID", connection);
                cmd.Parameters.AddWithValue("@UserID", username);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = true;
                }
            }

            return result;
        }

        public User GetUser(string username)
        {
            // Get user from database where user.username == username
            User usr = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from [CheckPasser].[dbo].[User] where [UserID] = @UserID", connection);
                cmd.Parameters.AddWithValue("@UserID", username);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usr = new User();
                    usr.Username = (String)reader["UserID"];
                    usr.FirstName = (String)reader["FirstName"];
                    usr.LastName = (String)reader["LastName"];
                    usr.IsAdmin = (Boolean)reader["IsAdmin"];
                    usr.Password = (String)reader["Passwrd"];
                }
            }
            return usr;
        }

        public void AddUser(User user)
        {
            // Insert user into database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //Used insert stored procedure 
                SqlCommand cmd = new SqlCommand("[CheckPasser].[dbo].[sp_InsertUserRec]", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", user.Username);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
                cmd.Parameters.AddWithValue("@Passwrd", user.Password);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            // Replace User table row in database with user where UserID column == user.Username
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Update [CheckPasser].[dbo].[User]" +
                                                "Set FirstName = @FirstName, LastName = @LastName, IsAdmin = @IsAdmin, Passwrd = @Passwrd " +
                                                "where [UserID] = @UserID", connection);

                cmd.Parameters.AddWithValue("@UserID", user.Username);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
                cmd.Parameters.AddWithValue("@Passwrd", user.Password);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(string username)
        {
            // Delete user from database where user.username == username
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [CheckPasser].[dbo].[User]" +
                                                "where [UserID] = @UserID", connection);
                cmd.Parameters.AddWithValue("@UserID", username);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
