using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member of data for thisstaff
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            //variables for the index and record count  
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
            //get the count of records returned
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


        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffPhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@StaffClockIn", mThisStaff.StaffClockIn);
            DB.AddParameter("@StaffDateOfHire", mThisStaff.StaffDateofHire);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffPhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@StaffDateOfHire", mThisStaff.StaffDateofHire);
            DB.AddParameter("@StaffClockIn", mThisStaff.StaffClockIn);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffName(string StaffName)
        {
            //filters the record based on a full or partial staff name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the StaffName parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index< RecordCount)
            {
                //create a blank staff object
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AStaff.StaffPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNo"]);
                AStaff.StaffClockIn = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffClockIn"]);
                AStaff.StaffDateofHire = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateofHire"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point to the next record
                Index++;
            }
        }
    }
}
