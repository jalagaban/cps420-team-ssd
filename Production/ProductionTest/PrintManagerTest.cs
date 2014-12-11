using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Production;

namespace ProductionTest
{
    [TestClass]
    public class PrintManagerTest
    {
        [TestMethod]
        public void TestGetDocuments()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            db.ResetTestData();
            PrintManager pm = PrintManager.DefaultPrintManager;
            List<Document> docs = pm.GetLettersToPrint();

            Assert.IsTrue(docs.Count == 4, "incorrect number to print");
        }

        [TestMethod]
        public void TestGetDates()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            db.ResetTestData();
            PrintManager pm = PrintManager.DefaultPrintManager;

            Check chk = new Check();
            chk.RoutingNum = "12345678910";
            chk.AccountNum = "01987654321";
            chk.CheckNum = "3";
            chk.Amount = 100;
            chk.IsPaid = false;
            chk.Date = new DateTime(2014, 12, 8);
            chk.StoreID = "StrWalm335";
            chk.CashierID = "bleh";
            chk.LetterADate = new DateTime (2014, 11, 10);
            DateTime testDate = DateTime.Now.AddDays(20);

            DateTime chkDate = pm.getDate(chk);

            Assert.AreEqual<DateTime>(testDate, chkDate, "wrong date");

        }
    }
}
