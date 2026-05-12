using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class InstanceTests
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to verify it exists
            Assert.IsNotNull(AnOrder);
        }

        /// -------------------- PROPERTY OK TESTS ----------------------------

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 87;
            AnOrder.OrderNo = TestData;
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void DateOrderedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateOrdered = TestData;
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }

        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "45 Left Street, Leicester";
            AnOrder.ShippingAddress = TestData;
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "ordered";
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void DeliveryInstructionsPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "None specified.";
            AnOrder.DeliveryInstructions = TestData;
            Assert.AreEqual(AnOrder.DeliveryInstructions, TestData);
        }


        [TestMethod]
        public void ExpressShippingPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.ExpressShipping = TestData;
            Assert.AreEqual(AnOrder.ExpressShipping, TestData);
        }

        [TestMethod]
        public void SubtotalPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            decimal TestData = 789.99M;
            AnOrder.Subtotal = TestData;
            Assert.AreEqual(AnOrder.Subtotal, TestData);
        }
    }

    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            //create bool to store result of validation
            Boolean Found = false;
            //create some test data
            Int32 OrderNo = 7;
            //invoke method
            Found = AnOrder.Find(OrderNo);
            //check if result exists
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            //create bool to record if data is good
            Boolean OK = false;

            Int32 OrderNo = 7;
            Found = AnOrder.Find(OrderNo);
            //check the order no.
            if (AnOrder.OrderNo == 7) { 
                OK = true;
            }
            //test result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateOrderedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = false;

            Int32 OrderNo = 7;
            Found = AnOrder.Find(OrderNo);

            if (AnOrder.DateOrdered == Convert.ToDateTime("02/04/2026")) { 
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestShippingAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = false;

            Int32 OrderNo = 7;
            Found = AnOrder.Find(OrderNo);

            if (AnOrder.ShippingAddress == "139 Green Lane, Leicester, Leicestershire, L43 3ZT") { 
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = false;

            Int32 OrderNo = 7;
            Found = AnOrder.Find(OrderNo);

            if (AnOrder.OrderStatus == "delivered") { 
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDeliveryInstructionsFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = false;

            Int32 OrderNo = 7;
            Found = AnOrder.Find(OrderNo);

            if (AnOrder.DeliveryInstructions == "<none given>") { 
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestExpressShippingFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = false;

            Int32 OrderNo = 7;
            Found = AnOrder.Find(OrderNo);

            if (AnOrder.ExpressShipping == true) { 
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSubtotalFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = false;

            Int32 OrderNo = 7;
            Found = AnOrder.Find(OrderNo);

            if (AnOrder.Subtotal == 1399.99m) { 
                OK = true;
            }
            Assert.IsTrue(OK);

        }
    }

    
}
