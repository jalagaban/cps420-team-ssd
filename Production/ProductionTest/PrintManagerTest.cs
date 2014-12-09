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
    }
}
