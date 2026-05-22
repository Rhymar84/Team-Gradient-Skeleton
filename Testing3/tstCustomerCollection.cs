using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //variable to store primary key
            int PrimaryKey = 0;
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerIsVerified = true;
            TestItem.CustomerDateRegistered = DateTime.Now.Date;
            TestItem.CustomerAddress = "23 Holmes Street, Coventry";
            TestItem.CustomerPhoneNo = "07881727289";
            TestItem.CustomerEmail = "dennis@gmail.com";
            TestItem.CustomerName = "Dennis Ani ";
            TestItem.CustomerID = 1;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //variable to store primary key
            int PrimaryKey = 0;
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerIsVerified = true;
            TestItem.CustomerDateRegistered = DateTime.Now.Date;
            TestItem.CustomerAddress = "23 Holmes Street, Coventry";
            TestItem.CustomerPhoneNo = "07881727289";
            TestItem.CustomerEmail = "dennis@gmail.com";
            TestItem.CustomerName = "Dennis Ani ";
            TestItem.CustomerID = 1;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.CustomerIsVerified = false;
            TestItem.CustomerDateRegistered = DateTime.Now.Date;
            TestItem.CustomerAddress = "287 Holmes Street, Coventry";
            TestItem.CustomerPhoneNo = "07881722289";
            TestItem.CustomerEmail = "dennisani2667@yahoo.com";
            TestItem.CustomerName = "Desmond Ani ";
            TestItem.CustomerID = 3;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //variable to store primary key
            int PrimaryKey = 0;
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerIsVerified = true;
            TestItem.CustomerDateRegistered = DateTime.Now.Date;
            TestItem.CustomerAddress = "23 Holmes Street, Coventry";
            TestItem.CustomerPhoneNo = "07881727289";
            TestItem.CustomerEmail = "dennis@gmail.com";
            TestItem.CustomerName = "Dennis Ani ";
            TestItem.CustomerID = 1;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCustomerNameMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByCustomerName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByCustomerNameNoneFound()
        {
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a customer name that doesn't exist
            FilteredCustomers.ReportByCustomerName("xxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store outcome
            Boolean OK = true;
            //apply a customer name that doesn't exist
            FilteredCustomers.ReportByCustomerName("Dennis Ani");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredCustomers.CustomerList[0].CustomerID != 1)
                {
                    OK = false;
                }
                //check that the second record is ID 3
                if (FilteredCustomers.CustomerList[1].CustomerID != 3)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records

        }
    }
}


