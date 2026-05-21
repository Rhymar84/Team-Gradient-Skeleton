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
        public clsOrder ThisOrder = new clsOrder();

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

        public int Add()
        {
            //adds a record to the database based on ThisOrder
            // connect to DB
            clsDataConnection DB = new clsDataConnection();
            //set params
            _Add_DB_Params(DB);

            //execute stored procedure and return primary key
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            //update existing record based on ThisOrder
            clsDataConnection DB = new clsDataConnection();
            //set params
            DB.AddParameter("@OrderNo", ThisOrder.OrderNo);
            _Add_DB_Params(DB);

            DB.Execute("sproc_tblOrders_Update");
        }

        public void SetOrder(clsOrder NewOrder)
        {
            ThisOrder = new clsOrder();
            ThisOrder.OrderNo = NewOrder.OrderNo;
            ThisOrder.DateOrdered = NewOrder.DateOrdered;
            ThisOrder.ShippingAddress = NewOrder.ShippingAddress;
            ThisOrder.OrderStatus = NewOrder.OrderStatus;
            ThisOrder.DeliveryInstructions = NewOrder.DeliveryInstructions;
            ThisOrder.ExpressShipping = NewOrder.ExpressShipping;
            ThisOrder.Subtotal = NewOrder.Subtotal;
        }



        private void _Add_DB_Params(clsDataConnection DB)
        {
            DB.AddParameter("@DateOrdered", ThisOrder.DateOrdered);
            DB.AddParameter("@ShippingAddress", ThisOrder.ShippingAddress);
            DB.AddParameter("@OrderStatus", ThisOrder.OrderStatus);
            DB.AddParameter("@DeliveryInstructions", ThisOrder.DeliveryInstructions);
            DB.AddParameter("@ExpressShipping", ThisOrder.ExpressShipping);
            DB.AddParameter("@Subtotal", ThisOrder.Subtotal);
        }

        public void Delete()
        {
            ///deletes the record pointed to by ThisOrder
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", ThisOrder.OrderNo);
            DB.Execute("sproc_tblOrders_Delete");
        }
    }
}