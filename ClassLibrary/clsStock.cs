using System;

namespace ClassLibrary
{
    public class clsStock
    {
         int mProductId;
         string mProductName;
         string mProductDescription;
         int mInStock;
         DateTime mLastRestockDate;
         int mStockVariants;
         decimal mPrice;

        public Int32 ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }

        }


        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
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

        public DateTime LastRestockDate
        {
            get
            {
                return mLastRestockDate;
            }
            set
            {
                mLastRestockDate = value;
            }

        }

        public int StockVariants
        {
            get
            {
                return mStockVariants;
            }
            set
            {
                mStockVariants = value;
            }

        }

        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }

        }

        public int InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }

        }




        public bool Find(int ProductId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            DB.Execute("sproc_tblStocks_FilterByProductId");

            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mInStock = Convert.ToInt32(DB.DataTable.Rows[0]["InStock"]);
                mLastRestockDate = Convert.ToDateTime(DB.DataTable.Rows[0]["LastRestockDate"]);
                mStockVariants = Convert.ToInt32(DB.DataTable.Rows[0]["StockVariants"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string productId, string productDescription, string inStock, string lastRestockDate, string price, string productName, string stockVariants)
        {
            String Error = "";
            DateTime LastRestockDateTemp;
            int InStockTemp;
            Decimal PriceTemp;
            int ProductIdTemp;
            int StockVariantsTemp;

            if (productDescription.Length < 1)
            {
                Error = Error + "Product Description cannot be blank: ";
            }
            if (productDescription.Length > 100)
            {
                Error = Error + "Product Description cannot exceed 100 chars: ";
            }
            if (productName.Length < 1)
            {
                Error = Error + "ProductName cannot be blank: ";
            }
            if (productName.Length > 35)
            {
                Error = Error + "Product Name cannot exceed 35 chars: ";
            }
            try
            {
                LastRestockDateTemp = Convert.ToDateTime(lastRestockDate);
                if (LastRestockDateTemp <= DateTime.Now.AddYears(-1).AddDays(-1))
                {
                    Error = Error + "LastRestockDate need to be within a year: ";
                }
                if (LastRestockDateTemp > DateTime.Now)
                {
                    Error = Error + "LastRestockDate  can’t be in the future: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for date: ";
            }
            try
            {
                ProductIdTemp = Convert.ToInt32(productId);
                if (ProductIdTemp < 1)
                {
                    Error = Error + "Product Id cannot be 0: ";
                }
                if (ProductIdTemp > 50)
                {
                    Error = Error + "Product Id cannot be more than 50: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for ProductId: ";
            }

            try
            {
                PriceTemp = Convert.ToDecimal(price);
                if (PriceTemp < 1)
                {
                    Error = Error + "Price cannot be less than 1: ";
                }
                if (PriceTemp > decimal.MaxValue)
                {
                    Error = Error + "Price cannot exceed decimal max value: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Price: ";
            }

            try
            {
                InStockTemp = Convert.ToInt32(inStock);
                if (InStockTemp < 1)
                {
                    Error = Error + "InStock amount can’t be 0: ";
                }
                if (InStockTemp > 100)
                {
                    Error = Error + "InStock amount can’t exceed 100: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for InStock: ";
            }

            try
            {
                StockVariantsTemp = Convert.ToInt32(stockVariants);
                if (StockVariantsTemp < 1)
                {
                    Error = Error + "Stock Variants cannot be less than 1: ";
                }
                if (StockVariantsTemp > 300)
                {
                    Error = Error + "Stock Variants cannot exceed 300: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Stock Variants: ";
            }


            return Error;
        }




    }
}