using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Production;
using System.Collections.Generic;

namespace ProductionTest
{
    [TestClass]
    public class AuthenticationManagerTest
    {
        [TestMethod]
        public void TestAttemptLogin()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;

            Assert.IsFalse(auth.AttemptLogin("nouser", "wut"), "login successful for bad credentials");
            Assert.IsTrue(auth.AttemptLogin("BWill321", "password"), "login unsuccessful for valid credentials");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestCurrentUser()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;

            auth.AttemptLogin("BWill321", "password");

            User user = new User();
            user.Username = "BWill321";
            user.Password = "password";
            user.FirstName = "Bruce";
            user.LastName = "Willis";
            user.IsAdmin = false;

            Assert.AreEqual<User>(user, auth.CurrentUser, "incorrect current user");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestGetUser()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();
            
            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;

            User user = new User();
            user.Username = "BWill321";
            user.Password = "password";
            user.FirstName = "Bruce";
            user.LastName = "Willis";
            user.IsAdmin = false;

            Assert.AreEqual<User>(user, auth.GetUser("BWill321"), "expected user not retrieved");
            
            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestAddUser()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;

            User user = new User();
            user.Username = "wall-e";
            user.Password = "pixarbot123";
            user.FirstName = "Walter";
            user.LastName = "Estaban";
            user.IsAdmin = true;

            auth.AddUser(user);

            Assert.AreEqual<User>(user, auth.GetUser("wall-e"), "user not successfully added");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestUpdateUser()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;

            User user = new User();
            user.Username = "BWill321";
            user.Password = "pixarbot123";
            user.FirstName = "Walter";
            user.LastName = "Estaban";
            user.IsAdmin = true;

            auth.UpdateUser(user);

            Assert.AreEqual<User>(user, auth.GetUser("BWill321"), "user not successfully updated");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestDeleteUser()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;

            auth.DeleteUser("BWill321");
            Assert.IsFalse(auth.UserExists("BWill321"), "user not successfully deleted");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestUserNames()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;

            List<string> usernames = auth.UserNames;
            Assert.AreEqual<int>(7, usernames.Count, "invalid number of usernames");
            Assert.IsTrue(usernames.Contains("BWill321"), "expected username not found");
            Assert.IsTrue(usernames.Contains("cacree101"), "expected username not found");
            Assert.IsFalse(usernames.Contains("notauser"), "unexpected username found");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }
    }
}
