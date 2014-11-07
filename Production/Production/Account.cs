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

        public string City { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }

        public string PhoneNum { get; set; }
    }
}
