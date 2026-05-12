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
            //set the private data member to the test data value
            mCustomerID = 1;
            mCustomerName = "Drake Lamar";
            mCustomerEmail = "drakelamar@gmail.com";
            mCustomerPhoneNo = "01234567890";
            mCustomerAddress = "1 Test Street, Test Town, Test Country";
            mCustomerDateRegistered = Convert.ToDateTime("2020-01-01");
            mCustomerIsVerified = true;
            //return that everything worked OK
            return true;
        }
    }
}

