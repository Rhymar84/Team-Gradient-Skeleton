using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
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


        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = aStaff.Valid(staffName, staffAddress, staffPhoneNo, staffRole, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //good test data for the other fields 
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string staffName = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(staffName, staffAddress, staffRole, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //good test data
        //create some test data to pass the method
        string staffName = "Tyson Granger";
        string staffAddress = "64 Zoo Lane";
        string staffRole = "Staff Admin";
        string staffPhoneNo = "07969454221";
        string staffDateofHire = DateTime.Now.Date.ToString();


        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Name = "T"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Name, staffAddress, staffRole, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Name = "Ty"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Name, staffAddress, staffRole, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Name = "Tyson Grange"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Name, staffAddress, staffRole, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Name = "Tyson Granger"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Name, staffAddress, staffRole, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Name = "Tyson Grang"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(Name, staffAddress, staffRole, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Name = "Tyson Grangeraaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = aStaff.Valid(Name, staffAddress, staffRole, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'a'); //this should fail
                                            //invoke the method
            Error = aStaff.Valid(Name, staffAddress, staffRole, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

       public void StaffDateofHireExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1000 years
            TestDate = TestDate.AddYears(-1000);
            string staffDateofHire = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is incore
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDateOfHireMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-101);
            //convert the date variable to a string variable
            string staffDateofHire = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateOfHireMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string staffDateofHire = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StaffDateOfHireMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string staffDateofHire = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffDateOfHireExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string staffDateofHire = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDateOfHireInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string staffDateofHire = "This is not a date!";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String staffAddress = "64 Z";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffAddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String staffAddress = "64 Zo";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String staffAddress = "64";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffAddress = "64 Zoo Lan";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffAddress = "64 Zoo Lane";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffAddress = "64 Zoo Lanee";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffAddress = "64 Zoo La";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error;
            //test data
            String staffPhoneNo = ""; //should fail

            Error=AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            Assert.AreNotEqual(Error, "");
  
        }
        [TestMethod]
        public void StaffPhoneNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "0";
            //this should pass
            string staffPhoneNo = "0796945";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffPhoneNo = "07969454";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffPhoneNo = "0796945422";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffPhoneNo = "07969454221";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffPhoneNo = "07969454211";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            //this should pass
            string staffPhoneNo = "079694542";
            //invoke the method
            Error = AStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
