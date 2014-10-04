using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        public bool testConnection()
        {
            return true; 
        }
        //LoadAll records
        public static List<AddressEntry> LoadAll()
        {
            //return a List of AddressEntry objects populated with data from AddressEntry database
            List<AddressEntry> addrBook = new List<AddressEntry>();
            return addrBook;
        }

        //Update a record
        //Create a new record
        //Delete a record
        //Update, Create, Delete methods uses AddressEntry parameter, extract information from instance, and issue calls
    }
}
