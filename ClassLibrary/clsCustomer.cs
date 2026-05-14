using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

        //private data member for the Customer Is Verified property
        private bool mCustomerIsVerified;
        public bool CustomerIsVerified 
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerIsVerified;
            }
                set
            {
                   //this line of code allows data into the property
                    mCustomerIsVerified = value;
            }
          
        }

        //private data member for the Customer Date Registered property
        private DateTime mCustomerDateRegistered;
        public DateTime CustomerDateRegistered 
        { 
            get
            {   //this line of code sends data out of the property
                return mCustomerDateRegistered;
            }
            set
            {  //this line of code allows data into the property
                mCustomerDateRegistered = value;
            }
        }

        //private data member for the Customer Address property
        private string mCustomerAddress;
        public string CustomerAddress 
        { 
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
             //this line of code allows data into the property
                mCustomerAddress = value;   
            }
        }

        //private data member for the Customer Phone No property
        private string mCustomerPhoneNo;
        public string CustomerPhoneNo 
        { 
            get
            {
                //this line of code sends data out of the property
                return mCustomerPhoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerPhoneNo = value;
            }
        }
        

        //private data member for the Customer Email property
        private string mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value
                ;
            }
        }

        //private data member for the Customer Name property
        private string mCustomerName;
        public string CustomerName 
        { 
            get
                {
                //this line of code sends data out of the property
                return mCustomerName;
            }
            set
                {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }

        //private data member for the Customer ID property
        private Int32 mCustomerID;
        public int CustomerID 
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        public bool Find(int customerID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer ID to search for
            DB.AddParameter("@CustomerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNo"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerDateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateRegistered"]);
                mCustomerIsVerified = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerIsVerified"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                //return that there was a problem
                return false;
            }
        }

        public string Valid(string customerName, string customerEmail, string customerPhoneNo, string customerAddress, string customerDateRegistered)
        {
            //create a string variable to store the error
             String Error = "";
            //if the customer name is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be blank : ";
            }
            //if the customer name is greater than 50 characters
            if (customerName.Length > 50)
            {
                //record the error
                Error = Error + "The customer name must be less than 50 characters : ";
            }
            //return any error messages
            return "";
        }
    }
}

