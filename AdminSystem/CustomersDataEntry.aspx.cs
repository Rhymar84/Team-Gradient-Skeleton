 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //if this is not a new record
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture data
        string customerName = txtCustomerName.Text;
        string customerEmail = txtCustomerEmail.Text;
        string customerPhoneNo = txtCustomerPhoneNo.Text;
        string customerAddress = txtCustomerAddress.Text;
        string customerDateRegistered = txtCustomerDateRegistered.Text;
        

        string Error = ACustomer.Valid(customerName, customerEmail, customerPhoneNo, customerAddress, customerDateRegistered);
        if (Error == "")
        {
            //capture data
            ACustomer.CustomerID = CustomerID;
            ACustomer.CustomerName = txtCustomerName.Text;
            ACustomer.CustomerEmail = txtCustomerEmail.Text;
            ACustomer.CustomerPhoneNo = txtCustomerPhoneNo.Text;
            ACustomer.CustomerAddress = txtCustomerAddress.Text;
            ACustomer.CustomerDateRegistered = Convert.ToDateTime(txtCustomerDateRegistered.Text);
            ACustomer.CustomerIsVerified = chkCustomerIsVerified.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //if this is a new record i.e. CustomerID = -1 then add the data
            if (CustomerID == -1)
             {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect to the list page
            Response.Redirect("CustomersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerPhoneNo.Text = ACustomer.CustomerPhoneNo;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtCustomerDateRegistered.Text = ACustomer.CustomerDateRegistered.ToString("dd/MM/yyyy");
            chkCustomerIsVerified.Checked = ACustomer.CustomerIsVerified;
        }
    }
  


    void DisplayCustomers()
    {
        // create a direct instance of clsCustomer (same as btnFind_Click)
        clsCustomer ACustomer = new clsCustomer();

        // find the record
        Boolean Found = ACustomer.Find(CustomerID);

        if (Found)
        {
            txtCustomerID.Text = ACustomer.CustomerID.ToString();
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerPhoneNo.Text = ACustomer.CustomerPhoneNo;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtCustomerDateRegistered.Text = ACustomer.CustomerDateRegistered.ToString("dd/MM/yyyy");
            chkCustomerIsVerified.Checked = ACustomer.CustomerIsVerified;
        }
    }
    protected void txtCustomerDateRegistered_TextChanged(object sender, EventArgs e)
    {

    }
}
