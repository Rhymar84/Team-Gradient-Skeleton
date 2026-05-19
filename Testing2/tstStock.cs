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
        public void ItemNoPropertyOK()
        {
            clsStock anStock = new clsStock();
            Int32 TestData = 1;
            anStock.itemNo = TestData;
            Assert.AreEqual(anStock.itemNo, TestData);
        }

        [TestMethod]
        public void ModelNamePropertyOK()
        {
            clsStock anStock = new clsStock();
            string TestData = "Test Model Name";
            anStock.ModelName = TestData;
            Assert.AreEqual(anStock.ModelName, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock anStock = new clsStock();
            string TestData = "9.99";
            anStock.Price = TestData;
            Assert.AreEqual(anStock.Price, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsStock anStock = new clsStock();
            Int32 TestData = 100;
            anStock.Quantity = TestData;
            Assert.AreEqual(anStock.Quantity, TestData);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            clsStock anStock = new clsStock();
            Boolean TestData = true;
            anStock.InStock = TestData;
            Assert.AreEqual(anStock.InStock, TestData);
        }

        [TestMethod]
        public void LastDateRestockedPropertyOK()
        {
            clsStock anStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            anStock.LastDateRestocked = TestData;
            Assert.AreEqual(anStock.LastDateRestocked, TestData);
        }
        }
    }