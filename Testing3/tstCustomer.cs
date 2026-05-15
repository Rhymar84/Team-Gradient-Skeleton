using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string CustomerName = "Drake Lamar";
        string CustomerEmail = "drakelamar@gmail.com";
        string CustomerPhoneNo = "01234567890";
        string CustomerAddress = "1 High Street, Anytown, AT1 1AA";
        string CustomerDateRegistered = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        /// -------------------- PROPERTY OK TESTS ----------------------------

        [TestMethod]
        public void CustomerIsVerifiedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            ACustomer.CustomerIsVerified = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerIsVerified, TestData);

        }
        [TestMethod]
        public void CustomerDateregisteredPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.CustomerDateRegistered = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerDateRegistered, TestData);

        }
        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "1 High Street, Anytown, AT1 1AA";
            //assign the data to the property
            ACustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void CustomerPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "01234567890";
            //assign the data to the property
            ACustomer.CustomerPhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerPhoneNo, TestData);
        }
        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "drakelamar@gmail.com";
            //assign the data to the property
            ACustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Drake Lamar";
            //assign the data to the property
            ACustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        /// -------------------- FIND METHOD TESTS ----------------------------

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store results of validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 10;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            //check the customer name
            if (ACustomer.CustomerID != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store results of validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 10;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            //check the customer name
            if (ACustomer.CustomerName != "Lee Tom")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store results of validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 10;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            //check the customer email
            if (ACustomer.CustomerEmail != "lee@gmail.com")
            {
                OK = false;
            }

        }
        [TestMethod]
        public void TestCustomerPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store results of validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 10;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            //check the customer phone number
            if (ACustomer.CustomerPhoneNo != "07861728291")
            {
                OK = false;
            }

        }
        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store results of validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 10;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            //check the customer address
            if (ACustomer.CustomerAddress != "23 Licon Rd, Leicester")
            {
                OK = false;
            }

        }
        [TestMethod]
        public void TestCustomerDateRegisteredFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store results of validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 10;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            //check the customer date registered
            if (ACustomer.CustomerDateRegistered != Convert.ToDateTime("21/04/2026"))
            {
                OK = false;
            }
        }
        [TestMethod]
        public void TestCustomerIsVerifiedFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store results of validation
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 10;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            //check the customer is verified
            if (ACustomer.CustomerIsVerified != true)
            {
                OK = false;
            }

        }
        [TestMethod]
        public void ValidateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {             //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error;
            //create some test data to pass to the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerName = "a"; //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerName = "aa"; //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerName = new string('a', 49); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerName = new string('a', 50); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerName = new string('a', 51); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = new string('a', 25); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerName = new string('a', 500); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateRegisteredExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CustomerDateRegistered = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateRegisteredMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            DateTime TestDate;
            TestDate = DateTime.Now.Date;//set the date to today's date
            TestDate = TestDate.AddDays(-1); //change the date to be yesterday
            string CustomerDateRegistered = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateRegisteredMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            DateTime TestDate;
            TestDate = DateTime.Now.Date;//set the date to today's date
            TestDate = TestDate.AddDays(1); //change the date to be tomorrow
            string CustomerDateRegistered = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateRegisteredExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            DateTime TestDate;
            TestDate = DateTime.Now.Date;//set the date to today's date
            TestDate = TestDate.AddYears(100); //change the date to be 100 years in the future
            string CustomerDateRegistered = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateRegisteredInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerDateRegistered = "this is not a date!"; //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerEmail = ""; //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerEmail = "a"; //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerEmail = "aa"; //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerEmail = new string('a', 61); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerEmail = new string('a', 60); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxlessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerEmail = new string('a', 59); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerEmail = new string('a', 30); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerEmail = new string('a', 1000); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNoMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerPhoneNo = new string('a', 11); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNoMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerPhoneNo = new string('a', 10); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNoMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerPhoneNo = new string('a', 12); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNoMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerPhoneNo = new string('a', 15); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNoMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerPhoneNo = new string('a', 16); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNoMaxMinusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerPhoneNo = new string('a', 14); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNoMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerPhoneNo = new string('a', 8); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void CustomerPhoneNoExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerPhoneNo = new string('a', 100); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerAddress = new string('a', 1); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerAddress = new string('a', 0); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerAddress = new string('a', 2); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerAddress = new string('a', 70); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerAddress = new string('a', 71); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerAddress = new string('a', 69); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerAddress = new string('a', 35); //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error;
            string CustomerAddress = new string('a', 1000); //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPhoneNo, CustomerAddress, CustomerDateRegistered);
            Assert.AreNotEqual(Error, "");
        }
    }
}


