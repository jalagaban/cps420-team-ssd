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
}
