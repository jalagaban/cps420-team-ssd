using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace AddressBook
{
    public class AddressEntry
    {
        private string name;
        private string eAddr;

        public AddressEntry(string bname, string beAddr)
        {
            this.name = bname;
            this.eAddr = beAddr;
        }

        public override bool Equals(Object obj)
        {
            AddressEntry entry = obj as AddressEntry;
            if (entry == null)
                return false;
            else
                return name.Equals(entry.getName()) && eAddr.Equals(entry.getAddr());
        }

        public string getName() { return name; }
        public string getAddr() { return eAddr; }

        public void setName(string bname) { name = bname; }
        public void setAddr(string beAddr) { eAddr = beAddr; }
    }
}
