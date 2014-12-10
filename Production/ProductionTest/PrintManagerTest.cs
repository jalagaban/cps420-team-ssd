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

            Check chk = db.GetCheck(Tuple.Create("1111111111111112", "111111111111112", "11"));

            DateTime dt = pm.getDate(chk);
            DateTime test1 = new DateTime (2014, 11, 22);
            Assert.AreEqual<DateTime>(dt, test1, "incorrect date");
        }
    }
}
