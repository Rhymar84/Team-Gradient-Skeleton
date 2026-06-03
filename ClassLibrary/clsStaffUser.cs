using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace ClassLibrary
{
    public class clsStaffUser
    {
        private string mPassword;
        private string mDepartment;
        private int mUserID;
        private string mUserName;

        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }
        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }

        public bool FindUser(string UserName, string Password)
        {
            Password = HashPassword(Password);

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);

            DB.Execute("sproc_tblUsers_FindUserNamePW");

            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string HashPassword(string Password)
        {
            // Initialize a SHA256 hash object.
            using (SHA256 mySHA256 = SHA256.Create())
            {
                // Compute the hash of the password
                byte[] hashValue = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return Convert.ToBase64String(hashValue);
            }
        }
    }
}


