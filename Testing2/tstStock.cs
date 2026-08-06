using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        // ---- Instance test ----
        [TestMethod]
        public void InstanceOK()
        {
            clsStock anStock = new clsStock();
            Assert.IsNotNull(anStock);
        }

        // ---- Property tests (get/set) ----
        [TestMethod]
        public void ItemNoPropertyOK()
        {
            clsStock anStock = new clsStock();
            Int32 TestData = 1;
            anStock.ItemNo = TestData;
            Assert.AreEqual(anStock.ItemNo, TestData);
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

        // ---- Find method test (basic) ----
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Int32 ItemNo = 1;  // Changed from 21 to 1
            Found = anStock.Find(ItemNo);
            Assert.IsTrue(Found);
        }

        // ---- "Found" tests (each attribute gets set correctly by Find) ----
        [TestMethod]
        public void TestItemNoFound()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 1;  // Changed from 21 to 1
            Found = anStock.Find(ItemNo);
            if (anStock.ItemNo != 1)  // Changed from 21 to 1
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelNameFound()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 1;  // Changed from 21 to 1
            Found = anStock.Find(ItemNo);
            if (anStock.ModelName != "Test Model")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 1;  // Changed from 21 to 1
            Found = anStock.Find(ItemNo);
            if (anStock.Price != "19.99")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 1;  // Changed from 21 to 1
            Found = anStock.Find(ItemNo);
            if (anStock.Quantity != 50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 1;  // Changed from 21 to 1
            Found = anStock.Find(ItemNo);
            if (anStock.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastDateRestockedFound()
        {
            clsStock anStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 1;  // Changed from 21 to 1
            Found = anStock.Find(ItemNo);
            if (anStock.LastDateRestocked != new DateTime(2024, 1, 15))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestClass]
        public class ValidationTests
        {
            // Good test data
            string ModelName = "Test Model";
            string Price = "19.99";
            string Quantity = "50";
            string LastDateRestocked = DateTime.Now.ToShortDateString();

            [TestMethod]
            public void ValidMethodOK()
            {
                clsStock stock = new clsStock();
                string Error = "";
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ModelNameMinLessOne()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string ModelName = ""; // should fail
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ModelNameMin()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string ModelName = "a"; // should pass
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ModelNameMax()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string ModelName = "".PadRight(50, 'a'); // should pass
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ModelNameMaxPlusOne()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string ModelName = "".PadRight(51, 'a'); // should fail
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void PriceInvalidFormat()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string Price = "abc"; // should fail
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void PriceMin()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string Price = "0.01"; // should pass
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void QuantityNegative()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string Quantity = "-1"; // should fail
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void QuantityMin()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string Quantity = "0"; // should pass
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void LastDateRestockedInvalidDate()
            {
                clsStock stock = new clsStock();
                string Error = "";
                string LastDateRestocked = "not a date"; // should fail
                Error = stock.Valid(ModelName, Price, Quantity, LastDateRestocked);
                Assert.AreNotEqual(Error, "");
            }
        }
    }
}
