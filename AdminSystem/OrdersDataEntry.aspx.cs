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
        String dateOrdered = txtDateOrdered.Text;
        String shippingAddress = txtShippingAddress.Text;
        String orderStatus = txtOrderStatus.Text;
        String deliveryInstructions = txtDeliveryInstructions.Text;
        String subtotal = txtSubtotal.Text;

        String Error = AnOrder.Valid(dateOrdered, shippingAddress, orderStatus, deliveryInstructions, subtotal);
        if (Error == "")
        {
            //capture data
            AnOrder.OrderNo = 1;
            AnOrder.DateOrdered = Convert.ToDateTime(txtDateOrdered.Text);
            AnOrder.ShippingAddress = txtShippingAddress.Text;
            AnOrder.OrderStatus = txtOrderStatus.Text;
            AnOrder.DeliveryInstructions = txtDeliveryInstructions.Text;
            AnOrder.ExpressShipping = chkExpressShipping.Checked;
            AnOrder.Subtotal = Convert.ToDecimal(txtSubtotal.Text);
            //store the order in session object
            Session["AnOrder"] = AnOrder;
            //navigate to view page
            Response.Redirect("OrdersViewer.aspx");
        }
        else
        {
            //display error
            lblError.Text = Error;
        }
        
    }
}