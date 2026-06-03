using System;


namespace ClassLibrary
{
    public class clsCustomerUser
    {
        private int mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public clsCustomerUser()
        {
        }

        public int UserID
        {
            get
            {
                //return the private data 
                return mUserID;
            }
            set
            {
                //set the private data 
                mUserID = value;
            }
        }

        public string Password
        {
            get
            {
                //return the private data 
                return mPassword;
            }
            set
            {
                //set the private data 
                mPassword = value;
            }
        }

        public string UserName
        {
            get
            {
                //return the private data 
                return mUserName;
            }
            set
            {
                //set the private data 
                mUserName = value;
            }
        }
        public string Department 
        { 
            get
            {
                //return the private data 
                return mDepartment;
            }
                 
            set
            {   
                //set the private data 
                mDepartment = value;
            }

        }

        public bool FindUser(string userName, string password)
        {
            //creaate an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the stored procedure
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            //execute the stored procedure
            DB.Execute("sproc_tblUserss_FindUserNamePW");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
