using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display data
        Response.Write("<b>Customer ID: </b>" + ACustomer.CustomerID + "<br>");
        Response.Write("<b>Customer Name: </b>" + ACustomer.CustomerName + "<br>");
        Response.Write("<b>Customer Email: </b>" + ACustomer.CustomerEmail + "<br>");
        Response.Write("<b>Customer Phone No: </b>" + ACustomer.CustomerPhoneNo + "<br>");
        Response.Write("<b>Customer Address: </b>" + ACustomer.CustomerAddress + "<br>");
        Response.Write("<b>Customer Date Registered: </b>" + ACustomer.CustomerDateRegistered + "<br>");
        Response.Write("<b>Customer Is Verified: </b>" + ACustomer.CustomerIsVerified + "<br>");
    }
}