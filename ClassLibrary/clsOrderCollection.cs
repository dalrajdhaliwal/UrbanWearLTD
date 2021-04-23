using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();


        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;

            }
        }

        public clsOrderCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }





        public clsOrder ThisOrder {
            get
            {
                return mThisOrder;
            }
                set
            {
                mThisOrder = value;
            }
                
                
                
                }

        public void FilterByCustomerAddress(string CustomerAddress)
        {
            //Filters the records based on a full or partial CustomerAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the OrderID parameter to the database
            DB.AddParameter("@CustomerAddress", CustomerAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AOrder = new clsOrder();
                AOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AOrder.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AOrder.ItemColour = Convert.ToString(DB.DataTable.Rows[Index]["ItemColour"]);
                AOrder.ItemPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ItemPrice"]);
                AOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AOrder.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AOrder.Availability = true;
                mOrderList.Add(AOrder);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@CustomerAddress", mThisOrder.CustomerAddress);
            DB.AddParameter("@ItemColour", mThisOrder.ItemColour);
            DB.AddParameter("@ItemPrice", mThisOrder.ItemPrice);
            DB.AddParameter("@Availability", mThisOrder.Availability);
            DB.AddParameter("@ProductDescription", mThisOrder.ProductDescription);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@CustomerAddress", mThisOrder.CustomerAddress);
            DB.AddParameter("@ItemColour", mThisOrder.ItemColour);
            DB.AddParameter("@ItemPrice", mThisOrder.ItemPrice);
            DB.AddParameter("@Availability", mThisOrder.Availability);
            DB.AddParameter("@ProductDescription", mThisOrder.ProductDescription);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }
    }

}