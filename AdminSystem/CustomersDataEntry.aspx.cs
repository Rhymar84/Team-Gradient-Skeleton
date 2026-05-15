 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture data
        ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        ACustomer.CustomerName = txtCustomerName.Text;
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        ACustomer.CustomerPhoneNo = txtCustomerPhoneNo.Text;
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        ACustomer.CustomerDateRegistered = Convert.ToDateTime(DateTime.Now);
        ACustomer.CustomerIsVerified = chkCustomerIsVerified.Checked;

        string Error = ACustomer.Valid(ACustomer.CustomerName, ACustomer.CustomerEmail, ACustomer.CustomerPhoneNo, ACustomer.CustomerAddress, ACustomer.CustomerDateRegistered.ToString());
        if (Error == "")
        {
            //capture data
            ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            ACustomer.CustomerName = txtCustomerName.Text;
            ACustomer.CustomerEmail = txtCustomerEmail.Text;
            ACustomer.CustomerPhoneNo = txtCustomerPhoneNo.Text;
            ACustomer.CustomerAddress = txtCustomerAddress.Text;
            ACustomer.CustomerDateRegistered = Convert.ToDateTime(DateTime.Now);
            ACustomer.CustomerIsVerified = chkCustomerIsVerified.Checked;
            //store the customer name in the session object
            Session["ACustomer"] = ACustomer;
            //navigate to the view page
            Response.Redirect("CustomersViewer.aspx");
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
}