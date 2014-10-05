using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace AddressBook
{
    class AddressEntry
    {
        private string name;
        private string eAddr;

        public AddressEntry(string bname, string beAddr)
        {
            this.name = bname;
            this.eAddr = beAddr;
        }

        public string getName() { return name; }
        public string getAddr() { return eAddr; }

        public void setName(string bname) { name = bname; }
        public void setAddr(string beAddr) { eAddr = beAddr; }
    }

    class AddressEntryDAO
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
                    string name = rd.GetString(0);
                    string emAddr = rd.GetString(1);
                    AddressEntry entry = new AddressEntry(name, emAddr);
                    addrBook.Add(entry);
                }
            }
            db.Close();
            return addrBook;
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
                                    Set name = @ent.getName(), EmailAddr = @ent.getAddr() 
                                    where name = @ent.getName() and EmailAddr = @ent.getAddr())"; //Update SQL command
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
                SqlCeCommand cmd = new SqlCeCommand("Insert into AddressEntry Values('@ent.getName()','@ent.getAddr()')", db); //Insert SQL command
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
                cmd.CommandText = @"Delete from AddressEntry where Name = @ent.getName() and EmailAddr = @ent.getAddr()"; //Delete SQL command
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
