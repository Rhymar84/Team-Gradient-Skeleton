using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
         clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
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

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get 
            {
                //return the private data
                return mThisCustomer;
            }

            set 
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
          //mThisCustomer.CustomerID = 1;
         // return mThisCustomer.CustomerID;

            //adds a new record to the database based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPhoneNo", mThisCustomer.CustomerPhoneNo);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerDateRegistered", mThisCustomer.CustomerDateRegistered);
            DB.AddParameter("@CustomerIsVerified", mThisCustomer.CustomerIsVerified);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            //filters the records based on a full or partial customer name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", CustomerName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
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

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPhoneNo", mThisCustomer.CustomerPhoneNo);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerDateRegistered", mThisCustomer.CustomerDateRegistered);
            DB.AddParameter("@CustomerIsVerified", mThisCustomer.CustomerIsVerified);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}