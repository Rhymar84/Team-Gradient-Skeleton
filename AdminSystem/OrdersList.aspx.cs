using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create orderCollection instance
        clsOrderCollection Orders = new clsOrderCollection();
        //set data source to list of orders in collection
        lstOrderList.DataSource = Orders.OrderList;
        //set name of PK
        lstOrderList.DataValueField = "OrderNo";
        //set data field to display
        lstOrderList.DataTextField = "ShippingAddress";
        //bind data
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //PrimaryKey as -1 indicates this is new record
        Session["OrderNo"] = -1;
        //redirect to data entry
        Response.Redirect("OrdersDataEntry.aspx");
    }
}