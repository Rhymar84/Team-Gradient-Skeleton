using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the item number property
        private Int32 mStockID;

        //StockID public property
        public Int32 StockID
        {
            get
            {
                //return the private data
                return mStockID;
            }
            set
            {
                //set the private data
                mStockID = value;
            }
        }

        public int itemNo;

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int txtStockID { get; set; }
        public string ModelName { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public bool InStock { get; set; }
        public DateTime LastDateRestocked { get; set; }

        public bool Find(int itemNo)
        {
            return true;
        }
    }
}