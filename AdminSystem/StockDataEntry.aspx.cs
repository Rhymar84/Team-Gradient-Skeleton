using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStock
        clsStock anStock = new clsStock();
        //capture the item number
        anStock.itemNo = Convert.ToInt32(txtItemNo.Text);
        //Store the address in the session object
        Session["AnStock"] = anStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");

    }
}