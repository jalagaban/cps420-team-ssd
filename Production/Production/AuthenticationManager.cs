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
        public bool AttemptLogin(string username, string password)
        {
            // Get user for given username
            // Check user.Password against given password
                // If equal, set CurrentUser to user and return true
                // else return false
            return false;
        }

        public void LogOut()
        {
            // Set CurrentUser to null
        }

        // The currently logged-in user
        public User CurrentUser { get; set; }

        public User GetUser(string username)
        {
            // Get user from database where user.username == username
            return null;
        }

        public void AddUser(User user)
        {
            // Insert user into database
        }

        public void UpdateUser(User user)
        {
            // Replace User table row in database with user where UserID column == user.Username
        }

        public void DeleteUser(string username)
        {
            // Delete user from database where user.username == username
        }
    }
}
