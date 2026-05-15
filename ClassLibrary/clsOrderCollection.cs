using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public List<clsOrder> OrderList = new List<clsOrder>();
        public int Count 
        {
            get { return OrderList.Count; }
            set { }

        }
        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //blank address
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["orderNo"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateOrdered"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["shippingAddress"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["orderStatus"]);
                AnOrder.DeliveryInstructions = Convert.ToString(DB.DataTable.Rows[Index]["deliveryInstructions"]);
                AnOrder.ExpressShipping = Convert.ToBoolean(DB.DataTable.Rows[Index]["expressShipping"]);
                AnOrder.Subtotal = Convert.ToDecimal(DB.DataTable.Rows[Index]["subTotal"]);
                //add to list
                OrderList.Add(AnOrder);
                Index++;

            }
        }
    }
}