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
        //store the customer name in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the view page
        Response.Redirect("CustomersViewer.aspx");
    }
}