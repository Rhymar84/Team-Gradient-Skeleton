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
    //variable to store the primary key with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1 && StaffID != 0)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
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
            //capture the staff id // DON'T MISS THIS BIT !!!!!
            AStaff.StaffID = StaffID;
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
            //capture staff clock in
            AStaff.StaffClockIn = chkStaffClockIn.Checked;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffID = -1 then add the data
            if (StaffID == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffID);
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
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

    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffID);
        //display the data for the record
        txtStaffID.Text = StaffBook.ThisStaff.StaffID.ToString();
        txtStaffName.Text = StaffBook.ThisStaff.StaffName.ToString();
        txtStaffRole.Text = StaffBook.ThisStaff.StaffRole.ToString();
        txtStaffPhoneNo.Text = StaffBook.ThisStaff.StaffPhoneNo.ToString();
        txtStaffAddress.Text = StaffBook.ThisStaff.StaffAddress.ToString();
        txtStaffDateofHire.Text = StaffBook.ThisStaff.StaffDateofHire.ToString();
        chkStaffClockIn.Checked = StaffBook.ThisStaff.StaffClockIn;
    }
}

