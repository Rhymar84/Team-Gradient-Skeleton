
using System;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class clsStock
    {
        // Private fields (match database columns)
        private Int32 mItemNo;
        private string mModelName;
        private string mPrice;
        private Int32 mQuantity;
        private Boolean mInStock;
        private DateTime mLastDateRestocked;

        // Public properties
        public Int32 ItemNo
        {
            get { return mItemNo; }
            set { mItemNo = value; }
        }

        public string ModelName
        {
            get { return mModelName; }
            set { mModelName = value; }
        }

        public string Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public Int32 Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }

        public Boolean InStock
        {
            get { return mInStock; }
            set { mInStock = value; }
        }

        public DateTime LastDateRestocked
        {
            get { return mLastDateRestocked; }
            set { mLastDateRestocked = value; }
        }

        // FIND method – uses stored procedure
        public bool Find(int itemNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", itemNo);  // Fixed: using parameter, not property
            DB.Execute("sproc_tblStock_FilterByItemNo");

            if (DB.Count == 1)
            {
                mItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["ItemNo"]);
                mModelName = Convert.ToString(DB.DataTable.Rows[0]["ModelName"]);
                mPrice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mLastDateRestocked = Convert.ToDateTime(DB.DataTable.Rows[0]["LastDateRestocked"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        // SAVE method – INSERT or UPDATE
        public string Save()
        {
            string error = "";

            // Validation
            if (string.IsNullOrWhiteSpace(ModelName)) error += "Model Name is required. ";
            if (string.IsNullOrWhiteSpace(Price)) error += "Price is required. ";
            if (Quantity < 0) error += "Quantity cannot be negative. ";
            if (LastDateRestocked == DateTime.MinValue) error += "Valid date is required. ";

            if (!string.IsNullOrEmpty(error)) return error;

            clsDataConnection DB = new clsDataConnection();

            if (ItemNo == 0) // INSERT NEW
            {
                DB.AddParameter("@ModelName", ModelName);
                DB.AddParameter("@Price", Price);
                DB.AddParameter("@Quantity", Quantity);
                DB.AddParameter("@InStock", InStock);
                DB.AddParameter("@LastDateRestocked", LastDateRestocked);
                DB.Execute("sproc_tblStock_Insert");

                // Get the new ID (assuming stored procedure returns it)
                if (DB.Count > 0)
                {
                    mItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["ItemNo"]);
                }
            }
            else // UPDATE EXISTING
            {
                DB.AddParameter("@ItemNo", ItemNo);
                DB.AddParameter("@ModelName", ModelName);
                DB.AddParameter("@Price", Price);
                DB.AddParameter("@Quantity", Quantity);
                DB.AddParameter("@InStock", InStock);
                DB.AddParameter("@LastDateRestocked", LastDateRestocked);
                DB.Execute("sproc_tblStock_Update");
            }

            return "";
        }
    }
}