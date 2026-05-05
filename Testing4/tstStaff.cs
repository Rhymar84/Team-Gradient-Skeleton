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
            aStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Active, TestData);

        }
        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Active, TestData);

        }
        [TestMethod]
        public void StaffDateofHirePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Active, TestData);

        }
        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Active, TestData);

        }
        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Active, TestData);

        }
        [TestMethod]
        public void StaffRolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Active, TestData);

        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.Active, TestData);

        }
    }
}


