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
        //validate data input to ensure accurate data input
        System.Text.RegularExpressions.Regex nameRegex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z\s]+$");
        if (!nameRegex.IsMatch(txtCustomerName.Text))
        {
            lblError.Text = "Customer Name must contain letters only.";
            return;
        }

        System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        if (!emailRegex.IsMatch(txtCustomerEmail.Text))
        {
            lblError.Text = "Please enter a valid email address (e.g. name@example.com).";
            return;
        }

       
        System.Text.RegularExpressions.Regex phoneRegex = new System.Text.RegularExpressions.Regex(@"^\d+$");
        if (!phoneRegex.IsMatch(txtCustomerPhoneNo.Text))
        {
            lblError.Text = "Phone number must contain numbers only.";
            return;
        }

       
        DateTime dateRegistered;
        if (!DateTime.TryParseExact(txtCustomerDateRegistered.Text, "dd/MM/yyyy",
            System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None, out dateRegistered))
        {
            lblError.Text = "Date Registered must be in the format dd/MM/yyyy.";
            return;
        }

        // clear any previous error
        lblError.Text = "";

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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect back to the customer list
        Response.Redirect("CustomersList.aspx");
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // clear all fields
        txtCustomerID.Text = "";
        txtCustomerName.Text = "";
        txtCustomerEmail.Text = "";
        txtCustomerPhoneNo.Text = "";
        txtCustomerAddress.Text = "";
        txtCustomerDateRegistered.Text = "";
        chkCustomerIsVerified.Checked = false;
        lblError.Text = "";
    }

   
}
