// Represents a customer who wrote a bad check

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public class Account
    {
        public string RoutingNum { get; set; }

        public string AccountNum { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }

        public string PhoneNum { get; set; }

        /* A tuple containing the two identifiying attributes of the account.
        These attributes as ordered in the tuple are the RoutingNum and AccountNum. */
        public Tuple<string, string> Key
        {
            get
            {
                return Tuple.Create(RoutingNum, AccountNum);
            }
        }

        public override bool Equals(System.Object obj)
        {
            if (obj is Account)
            {
                Account account = (Account)obj;

                // Return true if the fields match:
                return (RoutingNum.Equals(account.RoutingNum)) &&
                       (AccountNum.Equals(account.AccountNum)) &&
                       (FirstName.Equals(account.FirstName)) &&
                       (LastName.Equals(account.LastName)) &&
                       (Street.Equals(account.Street)) &&
                       (City.Equals(account.City)) &&
                       (State.Equals(account.State)) &&
                       (Zipcode.Equals(account.Zipcode)) &&
                       (PhoneNum.Equals(account.PhoneNum));

            }
            else
            {
                return false;
            }
        }
    }
}
