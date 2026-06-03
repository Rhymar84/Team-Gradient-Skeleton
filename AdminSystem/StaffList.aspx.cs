using ClassLibrary;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }
    }

    void DisplayStaffs()
    {
        //create an instance of the staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to the list of customers in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");


    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else    //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);


            // store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }

        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete";

        }
    }
        protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        //retrieve staff name filter from presentation layer and filter
        AllStaff.ReportByStaffName(txtFilter.Text);
        //set data source of list to filtered collection
        lstStaffList.DataSource = AllStaff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        //filter by empty string (revert to all records)
        AllStaff.ReportByStaffName("");
        //clear filter text box to tidy up UI
        txtFilter.Text = "";
        //set data source of list to filtered collection
        lstStaffList.DataSource = AllStaff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }
}



