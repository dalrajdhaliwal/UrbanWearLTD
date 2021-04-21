using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderID;
        private int mCustomerNo;
        private string mCustomerAddress;
        private DateTime mOrderDate;
        private decimal mItemPrice;
        private string mItemColour;
        private bool mAvailability;
        private string mProductDescription;




        public Int32 OrderID {
        get
            {
                return mOrderID;
            }
        set
            {
                mOrderID = value;
            }

        }


        public Int32 CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }

        }

        public string ProductDescription
        {
            get
            {
                return mProductDescription;
            }
            set
            {
                mProductDescription = value;
            }

        }

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }

        }

        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }

        }

        public decimal ItemPrice
        {
            get
            {
                return mItemPrice;
            }
            set
            {
                mItemPrice = value;
            }

        }



        public string ItemColour
        {
            get
            {
                return mItemColour;
            }
            set
            {
                mItemColour = value;
            }

        }

        public bool Availability
        {
            get
            {
                return mAvailability;
            }
            set
            {
                mAvailability = value;
            }

        }

        public string Valid(string orderId, string productDescription, string customerNo, string customerAddress, string itemColour, string orderDate, string itemPrice)
        {
            String Error = "";
            DateTime DateTemp;
            int OrderIDTemp;
            int CustomerNoTemp;
            Decimal ItemPriceTemp;
            OrderIDTemp = Convert.ToInt32(orderId);
            if (OrderIDTemp < 1)
            {
                Error = Error + "OrderId cannot be less than 1 : ";
            }
            else if (OrderIDTemp > 500)
            {
                Error = Error + "OrderId cannot exceed the set max of 500";
            }
            if (productDescription.Length < 1)
            {
                Error= Error+ "Product Description cannot be blank";
            }
            else if (productDescription.Length > 50)
            {
                Error= Error+ "Product Description cannot exceed 50 chars";
            }
            CustomerNoTemp = Convert.ToInt32(customerNo);
            if (CustomerNoTemp < 1)
            {
                Error= Error+ "Customer Number cannot be 0";
            }
            else if (CustomerNoTemp > 1000)
            {
                Error= Error+ "Customer Number cannot be more than 1000";
            }
             if (customerAddress.Length < 1)
            {
                Error= Error+ "CustomerAddress cannot be blank";
            }
            else if (customerAddress.Length > 25)
            {
                Error= Error+ "CustomerAddress cannot exceed 25 chars";
            }
             if (itemColour.Length < 3)
            {
                Error= Error+ "Item Colour cannot have less than 3 characters as red is the shortest char colour";
            }
            else if (itemColour.Length > 10)
            {
                Error= Error+ "Item Colour cannot be more than 10 characters";
            }



            try
            {
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp <= DateTime.Now.AddYears(-2).AddDays(-1))
                {

                    Error = Error+ "Orders older than 2 years cannot be proccessed";
                }
                else if (DateTemp > DateTime.Now)
                {
                    Error = Error+ "Order date cannot be in the future";
                }

            }
            catch
            {
                Error = Error + "Invalid data for date";
            }





            ItemPriceTemp = Convert.ToDecimal(itemPrice);
            if (ItemPriceTemp < 1)
            {
                Error= Error+  "Item Price cannot be less than 1";
            }
            else if (ItemPriceTemp > decimal.MaxValue) 
            {
                Error= Error+  "Item Price cannot exceed the max decimal value";
            }
            else
            {
                return Error;
            }
        }







        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");

            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mItemColour = Convert.ToString(DB.DataTable.Rows[0]["ItemColour"]);
                mItemPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemPrice"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}