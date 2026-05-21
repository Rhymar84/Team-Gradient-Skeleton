using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        public List<clsStaff> StaffList { get; set; }
    }
}
public class clsStaffCollection
{
    //private data member for the list
    List<clsStaff> mStaffList = new List<clsStaff>();
    //public property for the staff list
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

    public int Count { get; set; }

    //constructor of the class
    public clsStaffCollection()
    {
        Int32 Index = 0;
        Int32 RecordCount = 0;

        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblStaff_SelectAll");
        RecordCount = DB.Count;

        //while there are records to process
        while (Index < RecordCount)
        {
            //blank address
            clsStaff AStaff = new clsStaff();
            AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["staff ID"]);
            AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["staff name"]);
            AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["staff role"]);
            AStaff.StaffPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["staff phone no"]);
            AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["staff address"]);
            AStaff.StaffDateofHire = Convert.ToDateTime(DB.DataTable.Rows[Index]["staff date of hire"]);
            Index++;
        }
    }
}