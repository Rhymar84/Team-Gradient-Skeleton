using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrderUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrdersUser AUser = new clsOrdersUser();
            Assert.IsNotNull(AUser);
        }
    
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsOrdersUser AUser = new clsOrdersUser();
            Int32 TestData = 1; //corresponds to Rhys
            AUser.UserID = TestData;
            Assert.AreEqual(AUser.UserID, TestData);
        }
    
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsOrdersUser AUser = new clsOrdersUser();
            string TestData = "Rhys"; //corresponds to Rhys
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }
    
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsOrdersUser AUser = new clsOrdersUser();
            string TestData = "RandomString42"; //corresponds to Rhys
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }
    
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsOrdersUser AUser = new clsOrdersUser();
            string TestData = "Order Processing"; //corresponds to Rhys
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }
    
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsOrdersUser AUser = new clsOrdersUser();
            //test data
            string UserName = "Rhys";
            string Password = "RandomString42";
            //invoke method and check if found
            Assert.IsTrue(AUser.FindUser(UserName, Password));

        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsOrdersUser AUser = new clsOrdersUser();
            //test data
            string UserName = "Rhys";
            string Password = "RandomString42";
            //invoke method and check details are correct
            AUser.FindUser(UserName, Password);
            Assert.IsTrue(AUser.UserName == UserName && AUser.Password == Password);

        }
    }
}
