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
        //create new clsOrder
        clsOrder AnOrder = new clsOrder();
        //get data from session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display data
        Response.Write("<b>OrderNo: </b>" + AnOrder.OrderNo + "<br>");
        Response.Write("<b>Date Ordered: </b>" + AnOrder.DateOrdered + "<br>");
        Response.Write("<b>Shipping Address: </b>" + AnOrder.ShippingAddress + "<br>");
        Response.Write("<b>Order Status: </b>" + AnOrder.OrderStatus + "<br>");
        Response.Write("<b>Delivery Instructions: </b>" + AnOrder.DeliveryInstructions + "<br>");
        Response.Write("<b>Express Shipping: </b>" + AnOrder.ExpressShipping + "<br>");
        Response.Write("<b>Subtotal: </b>£" + AnOrder.Subtotal + "<br>");
    }
}