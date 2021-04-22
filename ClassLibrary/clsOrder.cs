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


        public string Valid(string orderID, string customerNo, string customerAddress, string orderDate, string itemPrice, string itemColour, string productDescription)
        {
            String Error = "";
            DateTime OrderDateTemp;
            int CustomerNoTemp;
            Decimal ItemPriceTemp;
            int orderIDTemp;

            if (productDescription.Length <1)
            {
                Error = Error + "Product Description cannot be blank: ";
            }
        if (productDescription.Length > 50)
            {
                Error = Error + "Product Description cannot exceed 50 chars: ";
            }
        if (customerAddress.Length<1)
            {
                Error = Error + "Customer Address cannot be blank: ";
            }
        if (customerAddress.Length > 25)
            {
                Error = Error + "Customer Address cannot exceed 25 chars:";
            }
        if (itemColour.Length < 3)
            {
                Error = Error + "Item Colour cannot be less than 3 chars as the shortest colour name is red: ";
            }
        if (itemColour.Length > 10)
            {
                Error = Error + "Item Colour cannot exceed 10 chars:";
            }
        try
            {
                OrderDateTemp = Convert.ToDateTime(orderDate);
                if (OrderDateTemp <= DateTime.Now.AddYears(-2).AddDays(-1))
                {
                    Error = Error + "Orders older than 2 years cannot be proccessed: ";
                }
                if (OrderDateTemp > DateTime.Now)
                {
                    Error = Error + "Order date cannot be in the future: ";
                }
            }
        catch
            {
                Error = Error + "Invalid data for date: ";
            }
            try
            {
                CustomerNoTemp = Convert.ToInt32(customerNo);
                if (CustomerNoTemp <1)
                {
                    Error = Error + "Customer Number cannot be 0: ";
                }
                if (CustomerNoTemp > 1000)
                {
                    Error = Error + "Customer Number cannot be more than 1000: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Customer Number: ";
            }

            try
            {
                ItemPriceTemp = Convert.ToDecimal(itemPrice);
                if (ItemPriceTemp < 1)
                {
                    Error = Error + "Item Price cannot be less than 1: ";
                }
                if (ItemPriceTemp > decimal.MaxValue)
                {
                    Error = Error + "Item Price cannot exceed decimal max value: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Item Price: ";
            }

            try
            {
                orderIDTemp = Convert.ToInt32(orderID);
                if (orderIDTemp < 1)
                {
                    Error = Error + "Order ID cannot be less than 1: ";
                }
                if (orderIDTemp > 500)
                {
                    Error = Error + "Order ID cannot exceed number 500: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Order ID:";
            }

            return Error;
        }
    }
}