using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            if (AnOrder.OrderNo == 7)
            {
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

            if (AnOrder.DateOrdered == Convert.ToDateTime("02/04/2026"))
            {
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

            if (AnOrder.ShippingAddress == "139 Green Lane, Leicester, Leicestershire, L43 3ZT")
            {
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

            if (AnOrder.OrderStatus == "delivered")
            {
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

            if (AnOrder.DeliveryInstructions == "none given")
            {
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

            if (AnOrder.ExpressShipping == true)
            {
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

            if (AnOrder.Subtotal == 1399.99m)
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }

    }

    [TestClass]
    public class ValidationTests
    {

        //good test data
        String DateOrdered = DateTime.Now.ToShortDateString();
        String ShippingAddress = "15 Left Rd";
        String OrderStatus = "delivered";
        String DeliveryInstructions = "none given";
        String Subtotal = "399.99";

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            //string to store error
            String Error;

            //invoke method
            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            //test
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String ShippingAddress = ""; //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String ShippingAddress = "a"; //should pass

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String ShippingAddress = "".PadRight(75, 'a'); //should pass

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String ShippingAddress = "".PadRight(76, 'a'); //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateOrderedMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            DateTime TestDate = DateTime.Now.Date.AddDays(-1); //date yesterday, should fail
            String DateOrdered = TestDate.ToString();

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateOrderedMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            DateTime TestDate = DateTime.Now.Date; //date yesterday, should fail
            String DateOrdered = TestDate.ToString();

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateOrderedMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            DateTime TestDate = DateTime.Now.Date.AddDays(1); //date yesterday, should fail
            String DateOrdered = TestDate.ToString();

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateOrderedInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String DateOrdered = "this is not a date"; //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderStatusInvalidOption()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String OrderStatus = "".PadRight(7, 'a'); //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderStatusValidOption()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String OrderStatus = "delivered"; //should pass

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryInstructionsMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String DeliveryInstructions = ""; //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryInstructionsMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String DeliveryInstructions = "a"; //should pass

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryInstructionsMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String DeliveryInstructions = "".PadRight(50, 'a'); //should pass

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryInstructionsMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String DeliveryInstructions = "".PadRight(51, 'a'); //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SubtotalMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String Subtotal = "-1"; //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SubtotalMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String Subtotal = "0"; //should pass

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SubtotalMaxLength()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String Subtotal = "".PadRight(12, '9'); //should pass

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SubtotalMaxLengthPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String Subtotal = "".PadRight(13, '9'); //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SubtotalMaxDecimalPlaces()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String Subtotal = "399.99"; //should pass

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SubtotalMaxDecimalPlacesPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error;
            //test data
            String Subtotal = "399.995"; //should fail

            Error = AnOrder.Valid(DateOrdered, ShippingAddress, OrderStatus, DeliveryInstructions, Subtotal);
            Assert.AreNotEqual(Error, "");

        }
    }

    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void CollectionInstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to list
            clsOrder TestItem = new clsOrder();
            //set properties
            TestItem.DateOrdered = DateTime.Now;
            TestItem.ShippingAddress = "14 Right Rd";
            TestItem.ExpressShipping = true;
            TestItem.OrderStatus = "shipped";
            TestItem.OrderNo = 18;
            TestItem.DeliveryInstructions = "none given";
            TestItem.Subtotal = 289.99m;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to OrderList property
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data
            clsOrder TestOrder = new clsOrder();
            //set properties
            TestOrder.DateOrdered = DateTime.Now;
            TestOrder.ShippingAddress = "14 Right Rd";
            TestOrder.ExpressShipping = true;
            TestOrder.OrderStatus = "shipped";
            TestOrder.OrderNo = 18;
            TestOrder.DeliveryInstructions = "none given";
            TestOrder.Subtotal = 289.99m;
            //assign data to ThisOrder property
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to list
            clsOrder TestItem = new clsOrder();
            //set properties
            TestItem.DateOrdered = DateTime.Now;
            TestItem.ShippingAddress = "14 Right Rd";
            TestItem.ExpressShipping = true;
            TestItem.OrderStatus = "shipped";
            TestItem.OrderNo = 18;
            TestItem.DeliveryInstructions = "none given";
            TestItem.Subtotal = 289.99m;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to OrderList property
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey;
            //set properties
            TestItem.DateOrdered = DateTime.Now;
            TestItem.ShippingAddress = "14 Right Rd";
            TestItem.ExpressShipping = true;
            TestItem.OrderStatus = "shipped";
            TestItem.OrderNo = 18;
            TestItem.DeliveryInstructions = "none given";
            TestItem.Subtotal = 289.99m;
            //add item to collection
            AllOrders.SetOrder(TestItem);
            //add the record
            PrimaryKey = AllOrders.Add();
            //Get primary key and search for it
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test that the record was found in the database
            Assert.IsTrue(AllOrders.ThisOrder.Equals(TestItem));
            //Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey;
            //set properties
            TestItem.DateOrdered = DateTime.Now;
            TestItem.ShippingAddress = "14 Right Rd";
            TestItem.ExpressShipping = true;
            TestItem.OrderStatus = "shipped";
            TestItem.OrderNo = 18;
            TestItem.DeliveryInstructions = "none given";
            TestItem.Subtotal = 289.99m;
            //add item to collection
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //Get primary key and search for it
            TestItem.OrderNo = PrimaryKey;
            //modify the test data
            TestItem.ShippingAddress = "16 Down Avenue";
            TestItem.OrderStatus = "cancelled";
            TestItem.DeliveryInstructions = "put in parcel box";
            //set record based on new data
            AllOrders.SetOrder(TestItem);
            //AllOrders.ThisOrder = TestItem;
            Console.WriteLine(TestItem.ShippingAddress);
            //invoke update method
            AllOrders.Update();
            //find record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test that the record was found in the database
            Console.WriteLine(AllOrders.ThisOrder.ShippingAddress);
            Console.WriteLine(TestItem.ShippingAddress);
            Assert.IsTrue(AllOrders.ThisOrder.Equals(TestItem));
            //Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }

    
}
