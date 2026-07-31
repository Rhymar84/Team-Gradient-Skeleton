using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    private int _itemNo = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["ItemNo"] != null)
            {
                _itemNo = Convert.ToInt32(Request.QueryString["ItemNo"]);
                LoadStockData(_itemNo);
            }
            else if (Session["AnStock"] != null)
            {
                clsStock stock = (clsStock)Session["AnStock"];
                DisplayStockData(stock);
            }
            else
            {
                lbError.Text = "No stock item specified.";
            }
        }
    }

    private void LoadStockData(int itemNo)
    {
        clsStock stock = new clsStock();
        if (stock.Find(itemNo))
        {
            DisplayStockData(stock);
            ViewState["ItemNo"] = itemNo;
        }
        else
        {
            lbError.Text = "Stock item not found.";
        }
    }

    private void DisplayStockData(clsStock stock)
    {
        lblItemNoValue.Text = stock.ItemNo.ToString();
        lblModelNameValue.Text = stock.ModelName;
        lblPriceValue.Text = stock.Price;
        lblQuantityValue.Text = stock.Quantity.ToString();
        lblInStockValue.Text = stock.InStock ? "Yes" : "No";
        lblLastRestockedValue.Text = stock.LastDateRestocked.ToShortDateString();
        _itemNo = stock.ItemNo;
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDataEntry.aspx?ItemNo=" + _itemNo);
    }
}