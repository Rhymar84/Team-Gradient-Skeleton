using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestClass]
        public class TestInstance
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
        }
        [TestClass]
        public class PropertyTests
        {

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
        }
        [TestClass]
        public class FindMethodTests
        {

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
            [TestMethod]

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
            [TestMethod]

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
            [TestMethod]
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
            [TestMethod]

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
                //check staff name
                if (aStaff.StaffName != "Tyson Granger")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
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
                //check staff role
                if (aStaff.StaffRole != "Staff Admin")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);

            }
            [TestMethod]
            public void TestStaffAddressFound()
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
                //check staff address
                if (aStaff.StaffAddress != "64 Zoo Lane")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
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
                //check staff clock in
                if (aStaff.StaffClockIn != true)
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
        }
        [TestClass]
        public class ValidMethodTests
        {

            [TestMethod]
            public void ValidMethodOK()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            //good test data
            string staffName = "Tyson Granger";
            string staffAddress = "64 Zoo Lane";
            string staffRole = "Staff Admin";
            string staffPhoneNo = "07969454221";
            string staffDateofHire = DateTime.Now.Date.ToString();

            [TestMethod]
            public void StaffNameExtremeMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = ""; //this should fail
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMinLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = ""; //this should fail
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = "T"; //this should be ok
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMinPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = "Ty"; //this should be ok
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMid()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = "";
                Name = Name.PadRight(30, 'a'); //this should be ok
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMaxLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = "";
                Name = Name.PadRight(59, 'a'); //this should be ok
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = "";
                Name = Name.PadRight(60, 'a'); //this should be ok
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMaxPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = "";
                Name = Name.PadRight(61, 'a'); //this should fail
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameExtremeMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = "";
                Name = Name.PadRight(500, 'a'); //this should fail
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameInvalidData()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string Name = ""; //this should fail
                Error = aStaff.Valid(Name, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateofHireExtremeMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(-1000);
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireMinLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(-101);
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(-100);
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireMinPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(-99);
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireMid()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(-50);
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireMaxLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddDays(-1);
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireMaxPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddDays(1);
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireExtremeMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                DateTime TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(100);
                string staffDateofHire = TestDate.ToString();
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffDateOfHireInvalidData()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffDateofHire = "This is not a date!";
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoExtremeMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = ""; //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoMinLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = "079694"; //this should fail - 6 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = "0796945"; //this should be ok - 7 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoMinPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = "07969454"; //this should be ok - 8 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoMid()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = "079694542"; //this should be ok
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoMaxLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = "07969454221123"; //this should be ok - 14 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = "079694542211234"; //this should be ok - 15 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoMaxPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = "0796945422112345"; //this should fail - 16 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoExtremeMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = "";
                staffPhoneNo = staffPhoneNo.PadRight(500, '1'); //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffPhoneNoInvalidData()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffPhoneNo = ""; //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressExtremeMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = ""; //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressMinLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = "64 Zo"; //this should fail - 5 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = "64 Zoo"; //this should be ok - 6 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressMinPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = "64 Zoo "; //this should be ok - 7 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressMid()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = "";
                staffAddress = staffAddress.PadRight(50, 'a'); //this should be ok
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressMaxLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = "";
                staffAddress = staffAddress.PadRight(99, 'a'); //this should be ok
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = "";
                staffAddress = staffAddress.PadRight(100, 'a'); //this should be ok
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressMaxPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = "";
                staffAddress = staffAddress.PadRight(101, 'a'); //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressExtremeMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = "";
                staffAddress = staffAddress.PadRight(500, 'a'); //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffAddressInvalidData()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffAddress = ""; //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleExtremeMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = ""; //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleMinLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = "IT"; //this should fail - 2 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleMin()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = "CEO"; //this should be ok - 3 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleMinPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = "Chef"; //this should be ok - 4 chars
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleMid()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = "";
                staffRole = staffRole.PadRight(25, 'a'); //this should be ok
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleMaxLessOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = "";
                staffRole = staffRole.PadRight(49, 'a'); //this should be ok
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = "";
                staffRole = staffRole.PadRight(50, 'a'); //this should be ok
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleMaxPlusOne()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = "";
                staffRole = staffRole.PadRight(51, 'a'); //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleExtremeMax()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = "";
                staffRole = staffRole.PadRight(500, 'a'); //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StaffRoleInvalidData()
            {
                clsStaff aStaff = new clsStaff();
                String Error = "";
                string staffRole = ""; //this should fail
                Error = aStaff.Valid(staffName, staffRole, staffAddress, staffPhoneNo, staffDateofHire);
                Assert.AreNotEqual(Error, "");
            }
        }
    }
        [TestClass]
        public class clsAuditLogTests
        {
            [TestMethod]
            public void StaffIDPropertyOK()
            {
                //create an instance of the class we want to create
                clsStaffAuditLogs aLog = new clsStaffAuditLogs();
                //create some test data to assign to the property
                int TestData = 105;
                //assign the data to the property
                aLog.StaffID = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(aLog.StaffID, TestData);
            }
            [TestMethod]
            public void ActionPropertyOK()
            {
                //create an instance of the class we want to create
                clsStaffAuditLogs aLog = new clsStaffAuditLogs();
                //create some test data to assign to the property
                string TestData = "Added new staff member";
                //assign the data to the property
                aLog.Action = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(aLog.Action, TestData);
            }
            [TestMethod]
            public void TimestampPropertyOK()
            {
                //create an instance of the class we want to create
                clsStaffAuditLogs aLog = new clsStaffAuditLogs();
                //create some test data to assign to the property
                DateTime TestData = DateTime.Now;
                //assign the data to the property
                aLog.Timestamp = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(aLog.Timestamp, TestData);
            }
            [TestMethod]
            public void PerformedByPropertyOK()
            {
                //create an instance of the class we want to create
                clsStaffAuditLogs aLog = new clsStaffAuditLogs();
                //create some test data to assign to the property
                string TestData = "Admin User";
                //assign the data to the property
                aLog.PerformedBy = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(aLog.PerformedBy, TestData);
            }
        }
    }

