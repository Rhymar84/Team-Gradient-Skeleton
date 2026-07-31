using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    private clsDataConnection DB = new clsDataConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadStockList();
        }
    }

    private void LoadStockList()
    {
        try
        {
            DB.Execute("sproc_tblStock_ListAll");
            gvStock.DataSource = DB.DataTable;
            gvStock.DataBind();
        }
        catch (Exception ex)
        {
            lbError.Text = "Error loading stock: " + ex.Message;
        }
    }

    protected void gvStock_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        int itemNo = Convert.ToInt32(gvStock.DataKeys[index].Value);

        if (e.CommandName == "View")
        {
            Response.Redirect("StockViewer.aspx?ItemNo=" + itemNo);
        }
        else if (e.CommandName == "Edit")
        {
            Response.Redirect("StockDataEntry.aspx?ItemNo=" + itemNo);
        }
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDataEntry.aspx");
    }
}