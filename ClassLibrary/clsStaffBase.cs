using System;
using System.Runtime.Remoting.Messaging;

namespace ClassLibrary
{
    public class clsStaffBase
    {


        /******* Valid METHOD *******/
        public string Valid(string staffName, string staffRole, string staffAddress, string staffPhoneNo, string staffDateofHire)

        {
            //create a string variable to store the error
            string Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the staffName is blank
            if (staffName.Length == 0)
            {
                //record the error
                Error = Error + "The staff name may not be blank : ";
            }
            //if the staff name is greater than 50 characters
            if (staffName.Length > 60)
            {
                //record the error
                Error = Error + "The staff name must be less than 50 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;


            try
            {


                //copy the dateofHire value to the DateTemp variable
                DateTemp = Convert.ToDateTime(staffDateofHire);
                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }

                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }
            return Error;
        }
    }
}