using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private int _itemNo = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Check if editing an existing record
            if (Request.QueryString["ItemNo"] != null)
            {
                _itemNo = Convert.ToInt32(Request.QueryString["ItemNo"]);
                LoadStockData(_itemNo);
            }
            else
            {
                txtItemNo.Text = "New (auto-generated)";
            }
        }
        else
        {
            if (ViewState["ItemNo"] != null)
                _itemNo = (int)ViewState["ItemNo"];
        }
    }

    private void LoadStockData(int itemNo)
    {
        clsStock stock = new clsStock();
        if (stock.Find(itemNo))
        {
            txtItemNo.Text = stock.ItemNo.ToString();
            txtModelName.Text = stock.ModelName;
            txtPrice.Text = stock.Price;
            txtQuantity.Text = stock.Quantity.ToString();
            chkInStock.Checked = stock.InStock;
            txtLastDateRestocked.Text = stock.LastDateRestocked.ToString("yyyy-MM-dd");

            _itemNo = itemNo;
            ViewState["ItemNo"] = itemNo;
        }
        else
        {
            lbError.Text = "Stock item not found.";
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        try
        {
            clsStock stock = new clsStock();

            if (_itemNo > 0)
                stock.ItemNo = _itemNo;

            stock.ModelName = txtModelName.Text.Trim();
            stock.Price = txtPrice.Text.Trim();
            stock.Quantity = int.Parse(txtQuantity.Text.Trim());
            stock.InStock = chkInStock.Checked;
            stock.LastDateRestocked = DateTime.Parse(txtLastDateRestocked.Text);

            string result = stock.Save();

            if (string.IsNullOrEmpty(result))
            {
                Response.Redirect("StockViewer.aspx?ItemNo=" + stock.ItemNo);
            }
            else
            {
                lbError.Text = result;
            }
        }
        catch (Exception ex)
        {
            lbError.Text = "Error: " + ex.Message;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}