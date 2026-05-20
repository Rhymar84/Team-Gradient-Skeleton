using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff Clock In property
        private bool mStaffClockIn;
        public bool StaffClockIn
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffClockIn;
            }
            set
            {
                //this line of code allows data into the property
                mStaffClockIn = value;
            }

        }

        //private data member for the Staff Date of Hire property
        private DateTime mStaffDateofHire;
        public DateTime StaffDateofHire
        {
            get
            {   //this line of code sends data out of the property
                return mStaffDateofHire;
            }
            set
            {  //this line of code allows data into the property
                mStaffDateofHire = value;
            }
        }

        //private data member for the Staff Address property
        private string mStaffAddress;
        public string StaffAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffAddress;
            }
            set
            {
                //this line of code allows data into the property
                mStaffAddress = value;
            }
        }

        //private data member for the Staff Phone No property
        private string mStaffPhoneNo;
        public string StaffPhoneNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffPhoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffPhoneNo = value;
            }
        }


        //private data member for the Staff Name property
        private string mStaffName;
        public string StaffName
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value
                ;
            }
        }

        //private data member for the Staff Role property
        private string mStaffRole;
        public string StaffRole
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffRole;
            }
            set
            {
                //this line of code allows data into the property
                mStaffRole = value;
            }
        }

        //private data member for the Staff ID property
        private Int32 mStaffID;
        public int StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        /******* FIND METHOD *******/
        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the Staff id to search for
            DB.AddParameter("@StaffId", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNo"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffDateofHire = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateofHire"]);
                mStaffClockIn = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffClockIn"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }


        /******* Valid METHOD *******/
        public string Valid(string staffName, string staffRole, string staffAddress, string staffPhoneNo, string staffDateofHire)
        {
            //create a string variable to store the error
            string Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;
            // ------------- STAFF NAME -------------
            //if the staffName is blank
            if (staffName.Length == 0)
            {
                //record the error
                Error = Error + "This is not a valid staff name: ";
            }
            //if the staff name is greater than 50 characters
            if (staffName.Length > 60)
            {
                //record the error
                Error = Error + "Please enter a valid staff name: ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;


            try
            {


                //copy the dateofHire value to the DateTemp variable
                DateTemp = Convert.ToDateTime(staffDateofHire);
                if (DateTemp < DateComp.AddYears(-100))
                {
                    //record the error
                    Error = Error + "This is an incorrect date of hire : ";
                }


                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "This is not a valid date of hire: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "Please enter a valid date of hire: ";
            }
            // ------------- STAFF PHONE NUMBER -------------
            //if the staff phone No is too long
            if (staffPhoneNo.Length > 15)
            {
                //record the error
                Error = Error + "This isn't a valid phone number: ";
            }
            if (staffPhoneNo.Length <6)
            {
                //record the error
                Error = Error + "Please enter a valid phone number: ";
            }
            // ------------- STAFF ADDRESS -------------
            //if the staff address is too long
            if (staffAddress.Length > 100)
            {
                //record the error
                Error = Error + "This isn't a valid address:";
            }
            if (staffAddress.Length == 0)
            {
                //record the error
                Error = Error + "Please enter a valid address: ";
            }
            //if the staff role is too long
            if (staffRole.Length > 50)
            {
                //record the error
                Error = Error + "This isn't a valid staff role: ";
            }
            // ------------- STAFF ROLE -------------
            //if the staff role is blank
            if (staffRole.Length == 0)
            {
                //record the error
                Error = Error + "Please enter a valid staff role: ";
            }

            //return any error messages
            return Error;
        }
    }
}
