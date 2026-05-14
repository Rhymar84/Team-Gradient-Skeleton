using System;
using System.Collections.Generic;
using System.Linq;

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

        private const Int32 ShippingAddressMinLength = 1;
        private const Int32 ShippingAddressMaxLength = 75;
        private const Int32 DeliveryInstructionsMinLength = 1;
        private const Int32 DeliveryInstructionsMaxLength = 50;
        private const Int32 SubtotalMinValue = 0;
        private const Int32 SubtotalMaxLength = 12;
        private const Int32 SubtotalMaxDecimalPlaces = 2;
        private List<string> ValidOrderStatuses = new List<string>
        {
            "delivered",
            "shipped",
            "ordered",
            "cancelled"
        };

        public bool Find(int orderNo)
        {
            //create instance of SQL connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for order no to search
            DB.AddParameter("@OrderNo", orderNo);
            //execute stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderNo");

            //one or zero records found
            if (DB.Count == 1) //record found
            {
                //copy data from database to private data members
                OrderNo = orderNo;
                DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["dateOrdered"]);
                ShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["shippingAddress"]);
                OrderStatus = Convert.ToString(DB.DataTable.Rows[0]["orderStatus"]);
                DeliveryInstructions = Convert.ToString(DB.DataTable.Rows[0]["deliveryInstructions"]);
                ExpressShipping = Convert.ToBoolean(DB.DataTable.Rows[0]["expressShipping"]);
                Subtotal = Convert.ToDecimal(DB.DataTable.Rows[0]["subTotal"]);
                return true;
            }
            else //no record, return false
            {   
                return false;
            }
        }

        public string Valid(string dateOrdered, string shippingAddress, string orderStatus, string deliveryInstructions, string subtotal)
        {
            String Error = "";
            DateTime DateObj;

            // ------------- SHIPPING ADDRESS -------------
            //is not blank
            if (shippingAddress.Length < ShippingAddressMinLength)
            {
                //record error
                Error += "The shipping address must have a value : ";
            }
            //is within char limit
            if (shippingAddress.Length > ShippingAddressMaxLength)
            {
                Error += "Shipping address must be " + ShippingAddressMaxLength + " characters max : ";
            }
            // ------------- ORDER STATUS -------------

            //is not blank
            if (!ValidOrderStatuses.Contains(orderStatus ))
            {
                Error += "Order status must be one of " + string.Join(", ", ValidOrderStatuses) + " : ";
            }
            // ------------- DELIVERY INSTRUCTIONS -------------
            //is not blank
            if (deliveryInstructions.Length < DeliveryInstructionsMinLength)
            {
                //record error
                Error += "The delivery instructions must have a value : ";
            }
            //is within char limit
            if (deliveryInstructions.Length > DeliveryInstructionsMaxLength)
            {
                Error += "Delivery instructions must be " + DeliveryInstructionsMaxLength + " characters max : ";
            }

            // ------------- DATE ORDERED -------------
            try
            {
                DateObj = Convert.ToDateTime(dateOrdered);
                //is less than todays date
                if (DateObj != DateTime.Now.Date)
                {
                    Error += "The date must be today : ";
                }
            }
            catch (FormatException)
            {
                Error += "The date must be valid format : ";
            }

            // ------------- SUBTOTAL -------------
            try
            {
                Decimal Total = Convert.ToDecimal(subtotal);
                //is less than todays date
                if (Total < SubtotalMinValue)
                {
                    Error += "The subtotal must be a least " + SubtotalMinValue + " : ";
                }
                if (subtotal.Length > SubtotalMaxLength)
                {
                    Error += "The subtotal must have at most " + SubtotalMaxLength + " digits : ";
                }
                String[] SubtotalDecimalSplit = subtotal.Split('.');
                if (SubtotalDecimalSplit.Length > 1 && SubtotalDecimalSplit[SubtotalDecimalSplit.Length - 1].Length > SubtotalMaxDecimalPlaces)
                {
                    Error += "The subtotal must have at most " + SubtotalMaxDecimalPlaces + " decimal places : ";
                }
            }
            catch (FormatException)
            {
                Error += "The subtotal must be valid format : ";
            }

            return Error;
            
        }
    }
}