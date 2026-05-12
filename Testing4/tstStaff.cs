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
            int TestData = 2893410;
            //assign the data to the property
            aStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffID, TestData);

        }
    }
}


