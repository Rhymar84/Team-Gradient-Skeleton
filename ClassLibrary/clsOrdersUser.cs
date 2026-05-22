using System;

namespace ClassLibrary
{
    public class clsOrdersUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }

        public bool FindUser(string userName, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            DB.Execute("sproc_tblUsers_FindUserNamePW");

            //should be 1 or 0 records
            if (DB.Count == 1)
            {
                UserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                UserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                Password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                Department = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}