using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff name
        string StaffName = txtStaffName.Text;
        //capture the staff role
        string StaffRole = txtStaffRole.Text;
        //capture the staff address
        string StaffAddress = txtStaffAddress.Text;
        //capture the staff phone number
        string StaffPhoneNo = txtStaffPhoneNo.Text;
        //capture the staff date of hire
        string StaffDateofHire = txtStaffDateofHire.Text;
        //capture the staff clock in status
        string StaffClockIn = chkStaffClockIn.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffName, StaffRole, StaffAddress, StaffPhoneNo, StaffDateofHire);
        if (Error == "")
        {
            //capture the staff name
            AStaff.StaffName = StaffName;
            //capture the staff role
            AStaff.StaffRole = StaffRole;
            //capture the staff address
            AStaff.StaffAddress = StaffAddress;
            //capture the staff phone number
            AStaff.StaffPhoneNo = StaffPhoneNo;
            //capture the staff date of hire
            AStaff.StaffDateofHire = Convert.ToDateTime(StaffDateofHire);
            //store the staff in the session object
            Session["AStaff"] = AStaff;
            //navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();

    }
}

