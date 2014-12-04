using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Production;

namespace ProductionTest
{
    [TestClass]
    public class DatabaseAgentTest
    {
        // Check

        [TestMethod]
        public void TestCheckKeys()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            List<Tuple<string, string, string>> keys = db.CheckKeys;
            Assert.AreEqual<int>(9, keys.Count, "invalid number of keys");
            Assert.IsTrue(keys.Contains(Tuple.Create("1111111111111111", "111111111111111", "11")), "expected key not present");
            Assert.IsTrue(keys.Contains(Tuple.Create("1111111111111117", "111111111111117", "11")), "expected key not present");
            Assert.IsTrue(keys.Contains(Tuple.Create("1111111111111119", "111111111111119", "11")), "expected key not present");
        }

        [TestMethod]
        public void TestCheckExists()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Assert.IsTrue(db.CheckExists(Tuple.Create("1111111111111111", "111111111111111", "11")), "expected check not found");
            Assert.IsTrue(db.CheckExists(Tuple.Create("1111111111111117", "111111111111117", "11")), "expected check not found");
            Assert.IsFalse(db.CheckExists(Tuple.Create("1111111111111128", "111111111111128", "11")), "unexpected check found");
            Assert.IsFalse(db.CheckExists(Tuple.Create("1111111111111171", "111111111111171", "19")), "unexpected check found");
        }

        [TestMethod]
        public void TestGetCheck()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Check check = new Check();
            check.RoutingNum = "1111111111111111";
            check.AccountNum = "111111111111111";
            check.CheckNum = "11";
            check.Amount = 1550;
            check.Date = new DateTime(2014, 10, 31);
            check.IsPaid = true;
            check.StoreID = "StrWalm225";
            check.CashierID = "CshJTrot245";
            Assert.AreEqual<Check>(check, db.GetCheck(check.Key), "expected check not fetched from database");
        }

        [TestMethod]
        public void TestAddCheck()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Check check = new Check();
            check.RoutingNum = "101001010101001";
            check.AccountNum = "123456789";
            check.CheckNum = "1234";
            check.Amount = 50010;
            check.Date = new DateTime(2012, 9, 12);
            check.IsPaid = false;
            check.StoreID = "StrWalm225";
            check.CashierID = "CshNPal301";

            db.AddCheck(check);
            Assert.AreEqual<Check>(check, db.GetCheck(check.Key), "check not added to database");
        }

        [TestMethod]
        public void TestUpdateCheck()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Check check = new Check();
            check.RoutingNum = "1111111111111111";
            check.AccountNum = "111111111111111";
            check.CheckNum = "11";
            check.Amount = 50010;
            check.Date = new DateTime(2012, 9, 12);
            check.IsPaid = false;
            check.StoreID = "StrWalm225";
            check.CashierID = "CshNPal301";

            Assert.IsTrue(db.CheckExists(check.Key), "no account to update");

            db.UpdateCheck(check);
            Assert.AreEqual<Check>(check, db.GetCheck(check.Key), "check not updated");
        }

        [TestMethod]
        public void TestDeleteCheck()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Tuple<string, string, string> key = Tuple.Create("1111111111111114", "111111111111114", "11");
            db.DeleteCheck(key);
            Assert.IsFalse(db.CheckExists(key), "check not deleted");
        }

        // Account

        [TestMethod]
        public void TestAccountKeys()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            List<Tuple<string, string>> keys = db.AccountKeys;
            Assert.AreEqual<int>(17, keys.Count, "invalid number of keys");
            Assert.IsTrue(keys.Contains(Tuple.Create("1111111111111111", "111111111111111")), "expected key not present");
            Assert.IsTrue(keys.Contains(Tuple.Create("1111111111111117", "111111111111117")), "expected key not present");
            Assert.IsTrue(keys.Contains(Tuple.Create("1111111111111121", "111111111111121")), "expected key not present");
            Assert.IsTrue(keys.Contains(Tuple.Create("1111111111111128", "111111111111128")), "expected key not present");
        }

        [TestMethod]
        public void TestAccountExists()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Assert.IsTrue(db.AccountExists(Tuple.Create("1111111111111111", "111111111111111")), "expected account not found");
            Assert.IsTrue(db.AccountExists(Tuple.Create("1111111111111121", "111111111111121")), "expected account not found");
            Assert.IsFalse(db.AccountExists(Tuple.Create("1111111111111150", "111111111111150")), "unexpected account found");
            Assert.IsFalse(db.AccountExists(Tuple.Create("1111111111111171", "111111111111171")), "unexpected account found");
        }

        [TestMethod]
        public void TestGetAccount()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Account account = new Account();
            account.AccountNum = "111111111111111";
            account.RoutingNum = "1111111111111111";
            account.FirstName = "Space";
            account.LastName = "Unicorn";
            account.Street = "Soaring";
            account.City = "Greenville,";
            account.State = "SC";
            account.Zipcode = "29615";
            account.PhoneNum = "867-5309";
            Assert.AreEqual<Account>(account, db.GetAccount(account.Key), "expected account not fetched from database");
        }

        [TestMethod]
        public void TestAddAccount()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Account account = new Account();
            account.AccountNum = "4857209348570293";
            account.RoutingNum = "727273747273727";
            account.FirstName = "Stahn";
            account.LastName = "Nazey";
            account.Street = "Road";
            account.City = "Towney-place,";
            account.State = "ME";
            account.Zipcode = "5666666";
            account.PhoneNum = "010-9119";

            db.AddAccount(account);
            Assert.AreEqual<Account>(account, db.GetAccount(account.Key), "account not added to database");
        }

        [TestMethod]
        public void TestUpdateAccount()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Account account = new Account();
            account.AccountNum = "111111111111111";
            account.RoutingNum = "1111111111111111";
            account.FirstName = "Stahn";
            account.LastName = "Nazey";
            account.Street = "Road";
            account.City = "Towney-place,";
            account.State = "ME";
            account.Zipcode = "5666666";
            account.PhoneNum = "010-9119";

            Assert.IsTrue(db.AccountExists(account.Key), "no account to update");

            db.UpdateAccount(account);
            Assert.AreEqual<Account>(account, db.GetAccount(account.Key), "account not updated");
        }

        [TestMethod]
        public void TestDeleteAccount()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Tuple<string, string> key = Tuple.Create("1111111111111114", "111111111111114");
            db.DeleteAccount(key);
            Assert.IsFalse(db.AccountExists(key), "account not deleted");
        }

        // Store

        [TestMethod]
        public void TestStoreExists()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Assert.IsTrue(db.StoreExists("StrWalm225"), "expected store not found");
            Assert.IsTrue(db.StoreExists("StrWalg337"), "expected store not found");
            Assert.IsFalse(db.StoreExists("StrWalg231"), "unexpected store found");
            Assert.IsFalse(db.StoreExists("StrTar535"), "unexpected store found");
            Assert.IsFalse(db.StoreExists("a"), "unexpected store found");
        }

        [TestMethod]
        public void TestGetStore()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Store store = new Store();
            store.ID = "StrWalm225";
            store.Name = "Walmart";
            store.Street = "225 Wade Hampton Blvd.";
            store.City = "Greenville";
            store.State = "SC";
            store.Zipcode = "29615";
            Assert.AreEqual<Store>(store, db.GetStore(store.ID), "expected store not fetched from database");
        }

        [TestMethod]
        public void TestAddStore()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Store store = new Store();
            store.ID = "StrTar535";
            store.Name = "Target";
            store.Street = "112 Fade Ln.";
            store.City = "GrungeVille";
            store.State = "AK";
            store.Zipcode = "101010";

            db.AddStore(store);
            Assert.AreEqual<Store>(store, db.GetStore(store.ID), "store not added to database");
        }

        [TestMethod]
        public void TestUpdateStore()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            Store store = new Store();
            store.ID = "StrWalg337";
            store.Name = "Walgoro";
            store.Street = "34 Apple Ln.";
            store.City = "Moscow";
            store.State = "RU";
            store.Zipcode = "64737";

            Assert.IsTrue(db.StoreExists(store.ID), "no store to update");

            db.UpdateStore(store);
            Assert.AreEqual<Store>(store, db.GetStore(store.ID), "store not updated");
        }

        [TestMethod]
        public void TestDeleteStore()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            db.ResetTestData();

            String ID = "StrWalm225";
            db.DeleteStore(ID);
            Assert.IsFalse(db.StoreExists(ID), "store not deleted");
        }
    }
}
