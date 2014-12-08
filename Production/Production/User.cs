// Represents a user of the application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsAdmin { get; set; }

        public override bool Equals(System.Object obj)
        {
            if (obj is User)
            {
                User check = (User)obj;

                // Return true if the fields match:
                return (Username.Equals(check.Username)) &&
                       (Password.Equals(check.Password)) &&
                       (FirstName.Equals(check.FirstName)) &&
                       (LastName.Equals(check.LastName)) &&
                       (IsAdmin.Equals(check.IsAdmin));

            }
            else
            {
                return false;
            }
        }
    }
}
