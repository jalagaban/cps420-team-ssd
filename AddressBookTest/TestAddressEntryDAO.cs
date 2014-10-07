using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook;

namespace AddressBookTest
{
    [TestClass]
    public class TestAddressEntryDAO
    {
        [TestMethod]
        public void TestAll()
        {
            AddressEntry entry = new AddressEntry("cow", "barn");
            Assert.IsTrue(AddressEntryDAO.CreateRecord(entry), "CreateRecord() failed");

            Assert.AreEqual<AddressEntry>(entry, AddressEntryDAO.LoadAll()[0], "newly created record could not be found");

            AddressEntry modifiedEntry = new AddressEntry("cow", "pen");
            Assert.IsTrue(AddressEntryDAO.UpdateRecord(modifiedEntry), "UpdateRecord() failed");

            Assert.AreEqual<AddressEntry>(modifiedEntry, AddressEntryDAO.LoadAll()[0], "updated record could not be found");

            Assert.IsTrue(AddressEntryDAO.DeleteRecord(modifiedEntry), "DeleteRecord() failed");

            Assert.AreEqual(new List<AddressEntry> { }, AddressEntryDAO.LoadAll(), "record could not be deleted");
        }
    }
}
