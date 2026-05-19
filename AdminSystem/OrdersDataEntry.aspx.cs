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

            //add record to database
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            //redirect back to list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //display error
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create clsOrder instance
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNo;
        try
        {
            OrderNo = Convert.ToInt32(txtOrderNo.Text);
        }
        catch (FormatException)
        {
            lblError.Text = "Invalid OrderNo.";
            return;
        }
        

        //search for record
        if (AnOrder.Find(OrderNo) == true)
        {
            //display values in form
            txtDateOrdered.Text = AnOrder.DateOrdered.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            txtOrderStatus.Text = AnOrder.OrderStatus;
            txtDeliveryInstructions.Text = AnOrder.DeliveryInstructions;
            chkExpressShipping.Checked = AnOrder.ExpressShipping;
            txtSubtotal.Text = AnOrder.Subtotal.ToString();

            lblError.Text = ""; //remove possible pre-existin errors
        }
        else
        {
            lblError.Text = "No record found.";
        }

    }
}