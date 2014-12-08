using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public class Config
    {
        private static readonly string connectionString = "server=158.158.143.243, 1434\teamssd; database=CheckPasser; Integrated Security=false; PWD=Te@m$$D; UID=sa";

        private static Config globalConfig;

        public static Config GlobalConfig
        {
            get
            {
                if (globalConfig == null)
                {
                    globalConfig = new Config();
                }
                return globalConfig;
            }
        }

        public void SetValue(string key, string value)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                bool keyExists = false;
                SqlCommand cmd = new SqlCommand("select 1 from [CheckPasser].[dbo].[Config] where [Key] = @Key", connection);
                cmd.Parameters.AddWithValue("@Key", key);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    keyExists = true;
                }
                reader.Close();

                SqlCommand updateCmd;
                if (keyExists)
                {
                    cmd.CommandText = "UPDATE [CheckPasser].[dbo].[Config] " +
                                         "SET Value = @Value " +
                                         "where [Key] = @Key";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO [CheckPasser].[dbo].[Config] ([Key], Value) " +
                                                "VALUES (@Key, @Value)";
                }

                cmd.Parameters.AddWithValue("@Value", value);
                cmd.ExecuteNonQuery();
            }
        }

        public string GetValue(string key)
        {
            string result = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [CheckPasser].[dbo].[Config]" +
                                                "where [Key] = @Key", connection);
                cmd.Parameters.AddWithValue("@Key", key);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = (String)reader["Value"];
                }
            }

            return result;
        }

        public bool ValueExists(string key)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select 1 from [CheckPasser].[dbo].[Config] where [Key] = @Key", connection);
                cmd.Parameters.AddWithValue("@Key", key);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = true;
                }
            }

            return result;
        }

        public void DeleteValue(string key) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [CheckPasser].[dbo].[Config]" +
                                                "where [Key] = @Key", connection);
                cmd.Parameters.AddWithValue("@Key", key);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
