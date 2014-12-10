using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Production;

namespace ProductionTest
{
    [TestClass]
    public class ConfigTest
    {
        [TestMethod]
        public void TestSetValue()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();
            
            Config config = Config.GlobalConfig;

            config.SetValue("this", "that");
            Assert.AreEqual<string>("that", config.GetValue("this"), "value not set for key");
            config.SetValue("this", "those");
            Assert.AreEqual<string>("those", config.GetValue("this"), "value not updated for key");
            
            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestGetValue()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            Config config = Config.GlobalConfig;

            Assert.AreEqual<string>("Greenville", config.GetValue("company_city"), "incorrect value retrieved for key");
            Assert.AreEqual<string>("Walmart", config.GetValue("company_name"), "incorrect value retrieved for key");
            Assert.AreEqual<string>("15", config.GetValue("company_fee"), "incorrect value retrieved");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestValueExists()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            Config config = Config.GlobalConfig;

            Assert.IsTrue(config.ValueExists("company_city"), "existing value reported as non-existing");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        [TestMethod]
        public void TestDeleteValue()
        {
            DatabaseAgent.DefaultAgent.ResetTestData();

            Config config = Config.GlobalConfig;

            config.DeleteValue("company_city");
            Assert.IsFalse(config.ValueExists("company_city"), "value not deleted");

            DatabaseAgent.DefaultAgent.ResetTestData();
        }
    }
}
