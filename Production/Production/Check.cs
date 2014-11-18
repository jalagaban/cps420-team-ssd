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
        public string RoutingNum { get; set; }

        public string AccountNum { get; set; }
        
        public string CheckNum { get; set; }

        public int Amount { get; set; }

        public bool IsPaid { get; set; }

        public DateTime Date { get; set; }

        public string StoreID { get; set; }

        public string CashierID { get; set; }

        /* A tuple containing the three identifiying attributes of the check.
         These attributes as ordered in the tuple are the RoutingNum, AccountNum, and CheckNum. */
        public Tuple<string, string, string> Key
        {
            get
            {
                return Tuple.Create(RoutingNum, AccountNum, CheckNum);
            }
        }

        /* A tuple containing the two identifiying attributes of the associated account.
         These attributes as ordered in the tuple are the RoutingNum and AccountNum. */
        public Tuple<string, string> AccountKey
        {
            get
            {
                return Tuple.Create(RoutingNum, AccountNum);
            }
        }

       public override bool Equals(System.Object obj)
        {
            if (obj is Check)
            {
                Check check = (Check)obj;

                // Return true if the fields match:
                return (AccountKey.Equals(check.AccountKey)) &&
                       (CheckNum.Equals(check.CheckNum)) &&
                       (Amount.Equals(check.Amount)) &&
                       (IsPaid.Equals(check.IsPaid)) &&
                       (Date.Equals(check.Date)) &&
                       (StoreID.Equals(check.StoreID)) &&
                       (CashierID.Equals(check.CashierID));

            }
            else
            {
                return false;
            }
        }
    }
}
