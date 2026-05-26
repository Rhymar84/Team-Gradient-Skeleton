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
            if (Convert.ToString(Session["Login"]) == "") //redirect to login if not logged in
            {
                Response.Redirect("OrdersLogin.aspx");
                return;
            }
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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        //if record is selected
        if (lstOrderList.SelectedIndex != -1)
        {
            //get PK
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            //store data in session obj
            Session["OrderNo"] = OrderNo;
            Response.Redirect("OrdersDataEntry.aspx");

        } 
        else //no record selected
        {
            lblError.Text = "Please select a record.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        //if record selected
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        //retrieve address filter from presentation layer and filter
        AllOrders.FilterByAddress(txtFilter.Text);
        //set data source of list to filtered collection
        lstOrderList.DataSource = AllOrders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        //filter by empty string (revert to all records)
        AllOrders.FilterByAddress("");
        //clear filter text box to tidy up UI
        txtFilter.Text = "";
        //set data source of list to filtered collection
        lstOrderList.DataSource = AllOrders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();
    }
}