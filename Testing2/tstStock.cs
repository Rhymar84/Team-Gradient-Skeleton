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
        [TestMethod]

        public void StockIDPropertyOK()
        {
            clsStock anStock = new clsStock();
            Int32 TestData = 1;
            anStock.StockID = TestData;
            Assert.AreEqual(anStock.StockID, TestData);
        }

        [TestMethod]

        public void StockNamePropertyOK()
        {
            clsStock anStock = new clsStock();
            string TestData = "Test Stock Name";
            anStock.StockName = TestData;
            Assert.AreEqual(anStock.StockName, TestData);
        }

        [TestMethod]

        public void StockPricePropertyOK()
        {
            clsStock anStock = new clsStock();
            decimal TestData = 9.99m;
            anStock.StockPrice = TestData;
            Assert.AreEqual(anStock.StockPrice, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = anStock.Find(StockID);
            Assert.IsTrue(Found);
        }

        [TestMethod]

    }
}

