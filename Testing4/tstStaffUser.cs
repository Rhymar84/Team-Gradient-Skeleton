using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "Marwan";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "123456";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "Staff Book";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Boolean Found = false;
            string username = "Marwan";
            string password = "Password11";  // capital P
            Found = AnUser.FindUser(username, password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Boolean Found = false;
            Boolean OK = true;
            string userName = "Marwan";
            string password = "Password11";
            Found = AnUser.FindUser(userName, password);
            // temporary debug - show what came back
            Assert.AreEqual(userName, AnUser.UserName);
            Assert.AreEqual(password, AnUser.Password);
            if (AnUser.UserName != userName && AnUser.Password != password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

