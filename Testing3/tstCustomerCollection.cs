using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsCustomerCollection AllCustomers = new ClassLibrary.clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOk()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsCustomerCollection AllCustomers = new ClassLibrary.clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerIsVerified = true;
            TestItem.CustomerDateRegistered = DateTime.Now.Date;
            TestItem.CustomerAddress = "23 Holmes Street, Coventry";
            TestItem.CustomerPhoneNo = "07881727289";
            TestItem.CustomerEmail = "dennis@gmail.com";
            TestItem.CustomerName = "Dennis Ani ";
            TestItem.CustomerID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
      
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerIsVerified = true;
            TestCustomer.CustomerDateRegistered = DateTime.Now.Date;
            TestCustomer.CustomerAddress = "23 Holmes Street, Coventry";
            TestCustomer.CustomerPhoneNo = "07881727289";
            TestCustomer.CustomerEmail = "dennis@gmail.com";
            TestCustomer.CustomerName = "Dennis Ani ";
            TestCustomer.CustomerID = 1;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerIsVerified = true;
            TestItem.CustomerDateRegistered = DateTime.Now.Date;
            TestItem.CustomerAddress = "23 Holmes Street, Coventry";
            TestItem.CustomerPhoneNo = "07881727289";
            TestItem.CustomerEmail = "dennis@gmail.com";
            TestItem.CustomerName = "Dennis Ani ";
            TestItem.CustomerID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
       
    }
}

