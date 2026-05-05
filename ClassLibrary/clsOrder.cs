using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool ExpressShipping { get; set; }
        public DateTime DateOrdered { get; set; }
        public int OrderNo { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryInstructions { get; set; }
        public float SubTotal { get; set; }
    }
}