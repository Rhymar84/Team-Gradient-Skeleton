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

        [TestMethod]

        public void FindMethodOK()
        {
            //Creating an instance of the class we want to create
            clsStock anStock = new clsStock();
            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 StockID = 21;
            //Invoke the method
            Found = anStock.Find(StockID);
            //test to see that the result is true
            Assert.isTrue(Found);
        }

        [TestMethod]
        public void TestItemNoFound()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemNo = 1;
            Found = anStock.Find(itemNo);
            if (anStock.itemNo != itemNo)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}