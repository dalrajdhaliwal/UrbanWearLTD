using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        

        public string ProductDescription { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerNo { get; set; }
        public int OrderId { get; set; }
        public decimal ItemPrice { get; set; }
        public char ItemColour { get; set; }
        public bool Availability { get; set; }

        public string Valid(int OrderId, string ProductDescription, int CustomerNo, string CustomerAddress, char ItemColour, DateTime OrderDate, bool Availability, decimal ItemPrice)
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
            else if (ItemColour == ' ')
            {
                return "Item Colour cannot be blank";
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


        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the game Id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                OrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                Availability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                CustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                ItemPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemPrice"]);
                CustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                ItemColour = Convert.ToChar(DB.DataTable.Rows[0]["Item Colour"]);
                OrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                ProductDescription = Convert.ToString(DB.DataTable.Rows[0]["Product Description"]);
                //return that everthing worked ok
                return true;
            }
            //if no records was found
            else
            {
                //return false indicating a problem
                return false;
           }
        }
    }
}