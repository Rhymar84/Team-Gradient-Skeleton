using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrders
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
        public void SubTotalPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            decimal TestData = 789.99;
            AnOrder.SubTotal = TestData;
            Assert.AreEqual(AnOrder.SubTotal, TestData);
        }
    }
}
