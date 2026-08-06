using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        // Private fields
        private List<clsStock> mStockList = new List<clsStock>();
        private clsStock mThisStock = new clsStock();

        // Public properties
        public List<clsStock> StockList
        {
            get { return mStockList; }
            set { mStockList = value; }
        }

        public clsStock ThisStock
        {
            get { return mThisStock; }
            set { mThisStock = value; }
        }

        // Constructor
        public clsStockCollection()
        {
            ListAll();
        }

        // List all stock items
        public void ListAll()
        {
            mStockList.Clear();
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_ListAll");

            foreach (DataRow row in DB.DataTable.Rows)
            {
                clsStock stock = new clsStock();
                stock.ItemNo = Convert.ToInt32(row["ItemNo"]);
                stock.ModelName = Convert.ToString(row["ModelName"]);
                stock.Price = Convert.ToString(row["Price"]);
                stock.Quantity = Convert.ToInt32(row["Quantity"]);
                stock.InStock = Convert.ToBoolean(row["InStock"]);
                stock.LastDateRestocked = Convert.ToDateTime(row["LastDateRestocked"]);
                mStockList.Add(stock);
            }
        }

        // Add a new stock item
        public void Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ModelName", ThisStock.ModelName);
            DB.AddParameter("@Price", ThisStock.Price);
            DB.AddParameter("@Quantity", ThisStock.Quantity);
            DB.AddParameter("@InStock", ThisStock.InStock);
            DB.AddParameter("@LastDateRestocked", ThisStock.LastDateRestocked);
            DB.Execute("sproc_tblStock_Insert");
        }

        // Update an existing stock item
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", ThisStock.ItemNo);
            DB.AddParameter("@ModelName", ThisStock.ModelName);
            DB.AddParameter("@Price", ThisStock.Price);
            DB.AddParameter("@Quantity", ThisStock.Quantity);
            DB.AddParameter("@InStock", ThisStock.InStock);
            DB.AddParameter("@LastDateRestocked", ThisStock.LastDateRestocked);
            DB.Execute("sproc_tblStock_Update");
        }

        // Delete a stock item
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", ThisStock.ItemNo);
            DB.Execute("sproc_tblStock_Delete");
        }

        // Filter by ModelName (optional)
        public void FilterByModelName(string modelName)
        {
            mStockList.Clear();
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ModelName", modelName);
            DB.Execute("sproc_tblStock_FilterByModelName");

            foreach (DataRow row in DB.DataTable.Rows)
            {
                clsStock stock = new clsStock();
                stock.ItemNo = Convert.ToInt32(row["ItemNo"]);
                stock.ModelName = Convert.ToString(row["ModelName"]);
                stock.Price = Convert.ToString(row["Price"]);
                stock.Quantity = Convert.ToInt32(row["Quantity"]);
                stock.InStock = Convert.ToBoolean(row["InStock"]);
                stock.LastDateRestocked = Convert.ToDateTime(row["LastDateRestocked"]);
                mStockList.Add(stock);
            }
        }
    }
}