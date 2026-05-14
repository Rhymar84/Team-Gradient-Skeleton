using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock anStock = new clsStock();

            Assert.IsNotNull(anStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStock anStock = new clsStock();
            Boolean TestData = true;
            anStock.Active = TestData;
            Assert.AreEqual(anStock.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStock anStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            anStock.DateAdded = TestData;
            Assert.AreEqual(anStock.DateAdded, TestData);
        }
}
}
