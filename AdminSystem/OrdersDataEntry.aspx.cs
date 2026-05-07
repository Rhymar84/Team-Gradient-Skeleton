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
        //create instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture data
        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AnOrder.DateOrdered = DateTime.Now;
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        AnOrder.OrderStatus = "ordered";
        AnOrder.DeliveryInstructions = txtDeliveryInstructions.Text;
        AnOrder.ExpressShipping = chkExpressShipping.Checked;
        AnOrder.SubTotal = Convert.ToSingle(txtSubTotal.Text);
        //store the order in session object
        Session["AnOrder"] = AnOrder;
        //navigate to view page
        Response.Redirect("OrdersViewer.aspx");
    }
}