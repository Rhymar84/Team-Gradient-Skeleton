using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an Item to the List
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffClockIn = true;
            TestItem.StaffID = 2893410;
            TestItem.StaffName = "Tyson Granger";
            TestItem.StaffPhoneNo = "07969454221";
            TestItem.StaffAddress = "64 Zoo Lane";
            TestItem.StaffRole = "Staff Admin";
            TestItem.StaffDateofHire = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList); ;
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an Item to the List
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffClockIn = true;
            TestItem.StaffID = 2893410;
            TestItem.StaffName = "Tyson Granger";
            TestItem.StaffPhoneNo = "07969454221";
            TestItem.StaffAddress = "64 Zoo Lane";
            TestItem.StaffRole = "Staff Admin";
            TestItem.StaffDateofHire = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        [TestMethod]
        public void ThisStaffOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data
            clsStaff TestStaff = new clsStaff();
            //set properties of test data
            TestStaff.StaffClockIn = true;
            TestStaff.StaffID = 2893410;
            TestStaff.StaffName = "Tyson Granger";
            TestStaff.StaffPhoneNo = "07969454221";
            TestStaff.StaffAddress = "64 Zoo Lane";
            TestStaff.StaffRole = "Staff Admin";
            TestStaff.StaffDateofHire = DateTime.Now;
            //assign data to thisStaff property
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestClass]
        public class AddMethodTests
        {
            [TestMethod]
            public void AddMethodOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();
                clsStaff TestItem = new clsStaff();
                Int32 PrimaryKey = 0;
                TestItem.StaffRole = "Staff Admin";
                TestItem.StaffName = "Tyson Granger";
                TestItem.StaffPhoneNo = "07969454221";
                TestItem.StaffAddress = "64 Zoo Lane";
                TestItem.StaffDateofHire = DateTime.Now;
                TestItem.StaffClockIn = true;
                AllStaff.ThisStaff = TestItem;
                PrimaryKey = AllStaff.Add();
                TestItem.StaffID = PrimaryKey;
                AllStaff.ThisStaff.Find(PrimaryKey);
                Assert.AreEqual(AllStaff.ThisStaff, TestItem);
                //cleanup - delete the test record
                AllStaff.ThisStaff.Find(PrimaryKey);
                AllStaff.Delete();
            }
        }
        [TestClass]
        public class UpdateMethodTests
        {
            [TestMethod]
            public void UpdateMethodOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();
                clsStaff TestItem = new clsStaff();
                Int32 PrimaryKey = 0;
                TestItem.StaffClockIn = true;
                TestItem.StaffRole = "Staff Admin";
                TestItem.StaffDateofHire = DateTime.Now;
                TestItem.StaffName = "Tyson Granger";
                TestItem.StaffPhoneNo = "07969454221";
                TestItem.StaffAddress = "64 Zoo Lane";
                AllStaff.ThisStaff = TestItem;
                PrimaryKey = AllStaff.Add();
                TestItem.StaffID = PrimaryKey;
                TestItem.StaffClockIn = false;
                TestItem.StaffRole = "Manager";
                TestItem.StaffDateofHire = DateTime.Now;
                TestItem.StaffName = "Another Name";
                TestItem.StaffPhoneNo = "07000000000";
                TestItem.StaffAddress = "Another Address";
                AllStaff.ThisStaff = TestItem;
                AllStaff.Update();
                AllStaff.ThisStaff.Find(PrimaryKey);
                Assert.AreEqual(AllStaff.ThisStaff, TestItem);
                //Cleanup Crew - exterminate
                AllStaff.ThisStaff.Find(PrimaryKey);
                AllStaff.Delete();
            }
        }

        [TestClass]
        public class DeleteMethodTests
        {

            [TestMethod]
            public void DeleteMethodOK()
            {
                //create an instance of the class we want to create
                clsStaffCollection AllStaff = new clsStaffCollection();
                //create the item of test data
                clsStaff TestItem = new clsStaff();
                //variable to store the primary key
                Int32 PrimaryKey = 0;
                //set its properties
                TestItem.StaffClockIn = true;
                TestItem.StaffRole = "Staff Admin";
                TestItem.StaffDateofHire = DateTime.Now;
                TestItem.StaffName = "Tyson Granger";
                TestItem.StaffPhoneNo = "07969454221";
                TestItem.StaffAddress = "64 Zoo Lane";
                //set ThisStaff to the test data
                AllStaff.ThisStaff = TestItem;
                //add the record
                PrimaryKey = AllStaff.Add();
                //set the primary key of the test data
                TestItem.StaffID = PrimaryKey;
                //find the record
                AllStaff.ThisStaff.Find(PrimaryKey);
                //delete the record
                AllStaff.Delete();
                //now find the record again
                Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
                //test to see that the record was not found
                Assert.IsFalse(Found);
            }
        }
        [TestClass]
        public class FilterMethodTests
        {

            [TestMethod]

            public void ReportByStaffNameMethodOK()
            {

                //create an instance of the class containing unfiltered results
                clsStaffCollection AllStaff = new clsStaffCollection();
                //create an instance of the filtered data
                clsStaffCollection FilteredStaff = new clsStaffCollection();
                //apply a blank string (should return all records)
                FilteredStaff.ReportByStaffName("");
                //test to see that the two values are the same
                Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
            }
            [TestMethod]

            public void ReportByStaffNameNoneFound()
            {
                //create an instance of the filtered data
                clsStaffCollection FilteredStaff = new clsStaffCollection();
                //apply a staff name that doesn't exist
                FilteredStaff.ReportByStaffName("xxxxxx");
                //test to see that there are no records
                Assert.AreEqual(0, FilteredStaff.Count);
            }
            [TestMethod]

            public void ReportByStaffNameTestDataFound()
            {
                //create an instance of the filtered data
                clsStaffCollection FilteredStaff = new clsStaffCollection();
                //variable to store the outcome
                Boolean OK = true;
                //apply a staff name that doesn't exist
                FilteredStaff.ReportByStaffName("Tyson Granger");
                //check that the correct number of records are found
                if (FilteredStaff.Count == 1)
                {
                    //check that the first record is ID 2893410
                    if (FilteredStaff.StaffList[0].StaffID != 105)
                    {
                        OK = false;
                    }
                }
                else
                {
                    OK = false;

                }
                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }
    }
}