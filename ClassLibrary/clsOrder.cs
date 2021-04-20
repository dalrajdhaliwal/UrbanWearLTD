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

        public string Valid(int OrderId, string ProductDescription, int CustomerNo, string CustomerAddress, string ItemColour, DateTime OrderDate, bool Availability, decimal ItemPrice)
        {
            if (OrderId < 1)
            {
                return "OrderId cannot be less than 1";
            }
            else if (OrderId > 500)
            {
                return "OrderId cannot exceed the set max of 500";
            }

            else if (ProductDescription.Length < 1)
            {
                return "Product Description cannot be blank";
            }
            else if (ProductDescription.Length > 50)
            {
                return "Product Description cannot exceed 50 chars";
            }
            else if (CustomerNo < 1)
            {
                return "Customer Number cannot be 0";
            }
            else if (CustomerNo > 1000)
            {
                return "Customer Number cannot be more than 1000";
            }
            else if (CustomerAddress.Length < 1)
            {
                return "CustomerAddress cannot be blank";
            }
            else if (CustomerAddress.Length > 25)
            {
                return "CustomerAddress cannot exceed 25 chars";
            }
            else if (ItemColour.Length < 3)
            {
                return "Item Colour cannot have less than 3 characters as red is the shortest char colour";
            }
            else if (ItemColour.Length > 10)
            {
                return "Item Colour cannot be more than 10 characters";
            }
            else if (OrderDate <= DateTime.Now.AddYears(-2).AddDays(-1))
            {
                return "Orders older than 2 years cannot be proccessed";
            }
            else if (OrderDate > DateTime.Now)
            {
                return "Order date cannot be in the future";
            }
            else if (ItemPrice < 1)
            {
                return "Item Price cannot be less than 1";
            }
            else if (ItemPrice > decimal.MaxValue) 
            {
                return "Item Price cannot exceed the max decimal value";
            }
            else
            {
                return "";
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