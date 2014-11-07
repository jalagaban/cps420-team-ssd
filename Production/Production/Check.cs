// Represents a bad check tracked by the application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public class Check
    {
        public Account Account { get; set; }
        
        public string CheckNum { get; set; }

        public int Amount { get; set; }

        public bool IsPaid { get; set; }

        public DateTime Date { get; set; }

        public Store Store { get; set; }

        public string CashierID { get; set; }
    }
}
