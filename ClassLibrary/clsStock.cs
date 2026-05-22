using System;

namespace ClassLibrary
{
    public class clsStock
    {
        // Private fields (match database to columns)
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

        // Find method – uses dummy data for testing (record with ItemNo = 21)
        public bool Find(int itemNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", ItemNo);
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
    }
}