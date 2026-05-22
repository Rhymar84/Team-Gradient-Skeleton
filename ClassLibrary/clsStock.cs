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
            if (itemNo == 21)
            {
                mItemNo = 21;
                mModelName = "Test Model";
                mPrice = "19.99";
                mQuantity = 50;
                mInStock = true;
                mLastDateRestocked = new DateTime(2024, 1, 15);
                return true;
            }
            return false;
        }
    }
}