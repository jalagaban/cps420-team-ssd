using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace AddressBook
{
    public class AddressEntryDAO
    {
        private static AddressEntryDAO instance;
        private AddressEntryDAO() { }
        public static AddressEntryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AddressEntryDAO();
                }
                return instance;
            }
        }
        //test connection to database
        public bool testConnection()
        {
            SqlCeConnection db = new SqlCeConnection("Data Source = AddressEntry.sdf");
            try
            {
                db.Open();
                db.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //LoadAll records
        public static List<AddressEntry> LoadAll()
        {
            //return a List of AddressEntry objects populated with data from AddressEntry database
            List<AddressEntry> addrBook = new List<AddressEntry>();
            SqlCeConnection db = new SqlCeConnection("Data Source = AddressEntry.sdf");
            db.Open();
            SqlCeCommand cmd = new SqlCeCommand("Select * from AddressEntry", db);
            using (SqlCeDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string name = (string)rd["name"];
                    string emAddr = (string)rd["EmailAddr"];
                    AddressEntry entry = new AddressEntry(name, emAddr);
                    addrBook.Add(entry);
                }
            }
            db.Close();
            return addrBook;
        }

        //CLearAll records
        public static void ClearAll() 
        {
            SqlCeConnection db = new SqlCeConnection("Data Source = AddressEntry.sdf");
            db.Open();
            SqlCeCommand cmd = db.CreateCommand();
            cmd.CommandText = @"Delete from AddressEntry"; //Delete SQL command
            cmd.ExecuteNonQuery();
            db.Close();
        }

        //Update a record
        public static bool UpdateRecord(AddressEntry ent)
        {
            try
            {
                SqlCeConnection db = new SqlCeConnection("Data Source = AddressEntry.sdf");
                db.Open();
                SqlCeCommand cmd = db.CreateCommand();
                cmd.CommandText = @"Update AddressEntry 
                                    Set EmailAddr = @addr 
                                    where name = @name"; //Update SQL command
                cmd.Parameters.AddWithValue("@name", ent.getName());
                cmd.Parameters.AddWithValue("@addr", ent.getAddr());
                cmd.ExecuteNonQuery();
                db.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //Create a new record
        public static bool CreateRecord(AddressEntry ent)
        {
            try
            {
                SqlCeConnection db = new SqlCeConnection("Data Source = AddressEntry.sdf");
                db.Open();
                SqlCeCommand cmd = new SqlCeCommand("Insert into AddressEntry Values(@name,@addr);", db); //Insert SQL command
                cmd.Parameters.AddWithValue("@name", ent.getName());
                cmd.Parameters.AddWithValue("@addr", ent.getAddr());
                cmd.ExecuteNonQuery();
                db.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //Delete a record
        public static bool DeleteRecord(AddressEntry ent)
        {
            try
            {
                SqlCeConnection db = new SqlCeConnection("Data Source = AddressEntry.sdf");
                db.Open();
                SqlCeCommand cmd = db.CreateCommand();
                cmd.CommandText = @"Delete from AddressEntry where Name = @name"; //Delete SQL command
                cmd.Parameters.AddWithValue("@name", ent.getName());
                cmd.ExecuteNonQuery();
                db.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //Update, Create, Delete methods uses AddressEntry parameter, extract information from instance, and issue calls
    }
}
