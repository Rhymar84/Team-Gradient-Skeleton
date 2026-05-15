using System;

namespace ClassLibrary
{
    public class clsStock
    {
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
            throw new NotImplementedException();
        }
    }
}