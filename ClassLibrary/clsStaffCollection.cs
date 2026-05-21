using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ClassLibrary
{
 public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        public clsStaffCollection()
        {
            //variables for the index and record count
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records returned
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //blank address
                clsStaff AStaff = new clsStaff();
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AStaff.StaffPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNo"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StaffDateofHire = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateofHire"]);
                Index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }


        public clsStaff ThisStaff { get; set; }

        public int Add()
        {
            throw new NotImplementedException();
        }
    }
}

