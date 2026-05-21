using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the order number to be deleted from session obj
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        AllOrders.ThisOrder.Find(OrderNo);
        AllOrders.Delete();
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}