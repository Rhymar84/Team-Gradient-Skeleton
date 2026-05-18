using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff : ItstStaff
    {
        [TestMethod]
        public void TestMethod()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to verify it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffClockInPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.StaffClockIn = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffClockIn, TestData);

        }
        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "64 Zoo Lane";
            //assign the data to the property
            aStaff.StaffAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffAddress, TestData);

        }
        [TestMethod]
        public void StaffDateofHirePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStaff.StaffDateofHire = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffDateofHire, TestData);

        }
        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "07969454221";
            //assign the data to the property
            aStaff.StaffPhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffPhoneNo, TestData);

        }
        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Tyson Granger";
            //assign the data to the property
            aStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffName, TestData);

        }
        [TestMethod]
        public void StaffRolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Staff Admin";
            //assign the data to the property
            aStaff.StaffRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffRole, TestData);

        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 105;
            //assign the data to the property
            aStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffID, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            //create bool to store result of validation
            Boolean Found = false;
            //create some test data
            int StaffID = 105;
            //invoke method
            Found = AStaff.Find(StaffID);
            //check if result exists
            Assert.IsTrue(Found);

        }
        public void TestStaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of our search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            int StaffID = 105;
            //invoke the method
            Found = aStaff.Find(StaffID);
            //check the staff id
            if (aStaff.StaffID != 105)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestDateofHireFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of our search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            int StaffID = 105;
            //invoke the method
            Found = aStaff.Find(StaffID);
            //check the date of hire
            if (aStaff.StaffDateofHire != Convert.ToDateTime("01/01/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestStaffPhoneNoFound()
        {

            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of our search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            int StaffID = 105;
            //invoke the method
            Found = aStaff.Find(StaffID);
            //check the date of hire
            if (aStaff.StaffPhoneNo != "07969454221")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestStaffNameFound()
        {

            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of our search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            int StaffID = 105;
            //invoke the method
            Found = aStaff.Find(StaffID);
            //check the date of hire
            if (aStaff.StaffName != "Tyson Granger")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestStaffRoleFound()
        {

            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of our search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            int StaffID = 105;
            //invoke the method
            Found = aStaff.Find(StaffID);
            //check the date of hire
            if (aStaff.StaffID != 105)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestStaffAddress()
        {

            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of our search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            int StaffID = 105;
            //invoke the method
            Found = aStaff.Find(StaffID);
            //check the date of hire
            if (aStaff.StaffAddress != "64 Zoo Lane")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestStaffClockInFound()
        {

            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of our search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            int StaffID = 105;
            //invoke the method
            Found = aStaff.Find(StaffID);
            //check the date of hire
            if (aStaff.StaffClockIn != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = aStaff.Valid(aStaff.StaffName, aStaff.StaffAddress, aStaff.StaffPhoneNo, aStaff.StaffRole);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}