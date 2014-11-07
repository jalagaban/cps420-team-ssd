// Manages application users and provides user authentication and user privilege-level lookup services


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public class AuthenticationManager
    {
        // Attempts to log in using the provided credentials. Returns true if login was successful and false if login failed.
        public bool AttemptLogin(string username, string password);

        public void LogOut();

        // The currently logged-in user
        public User CurrentUser { get; set; }

        public User GetUser(string username);

        public void AddUser(User user);

        public void UpdateUser(User user);

        public void DeleteUser(string username);
    }
}
