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
        AStaff.StaffName = txtStaffName.Text;
        //store the staff name in the session object
        Session["AStaff"] = AStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }





    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();

        //create a variable to store the primary key
        Int32 StaffID;

        //create a variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);

        //find the record
        Found = AStaff.Find(StaffID);

        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffRole.Text = AStaff.StaffRole;
            txtStaffName.Text = AStaff.StaffName;
            txtStaffPhoneNo.Text = AStaff.StaffPhoneNo;
            txtStaffAddress.Text = AStaff.StaffAddress;
            txtStaffDateofHire.Text = AStaff.StaffDateofHire.ToString();
            chkStaffClockIn.Checked = AStaff.StaffClockIn;

        }
    }
}
