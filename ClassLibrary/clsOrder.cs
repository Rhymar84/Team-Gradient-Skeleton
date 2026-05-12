using System;

namespace ClassLibrary
{
    public class clsOrder
    {


        public int OrderNo { get; set; }
        public DateTime DateOrdered { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryInstructions { get; set; }
        public bool ExpressShipping { get; set; }
        public Decimal Subtotal { get; set; }

        public bool Find(int primaryKey)
        {
            OrderNo = 7;
            DateOrdered = Convert.ToDateTime("02/04/2026");
            ShippingAddress = "139 Green Lane, Leicester, Leicestershire, L43 3ZT";
            OrderStatus = "delivered";
            DeliveryInstructions = "<none given>";
            ExpressShipping = true;
            Subtotal = 1399.99m;

            return true;
        }
    }
}