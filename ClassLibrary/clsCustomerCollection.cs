using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public clsCustomerCollection()
        {
            //variables for the index and record count
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records returned
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create an instance of the class we want to create
                clsCustomer AnCustomer = new clsCustomer();
                //get the customer details from the database
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNo"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.CustomerDateRegistered = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateRegistered"]);
                AnCustomer.CustomerIsVerified = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerIsVerified"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point to the next record
                Index++;
            }
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }


        public clsCustomer ThisCustomer { get; set; }

    }
}