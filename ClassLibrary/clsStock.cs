using System;

namespace ClassLibrary
{
    public class clsStock
    {


        public string ProductDescription { get; set; }
        public DateTime LastRestockDate { get; set; }
        public string ProductName { get; set; }
        public int InStock { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int StockVariants { get; set; }

        public string Valid(int ProductId, string ProductDescription, int InStock, string ProductName, int StockVariants, DateTime LastRestockDate, decimal Price)
        {
            if (ProductId < 1)
            {
                return "ProductId cannot be less than 1";
            }
            else if (ProductId > 50)
            {
                return "ProductId cannot exceed the set max of 500";
            }

            else if (ProductDescription.Length < 1)
            {
                return "Product Description cannot be blank";
            }
            else if (ProductDescription.Length > 100)
            {
                return "Product Description cannot exceed 100 chars";
            }
            else if (InStock < 1)
            {
                return "InStock amount cannot be 0";
            }
            else if (InStock > 100)
            {
                return "InStock amount cannot be more than 1000";
            }
            else if (ProductName.Length < 1)
            {
                return "Product Name cannot be blank";
            }
            else if (ProductName.Length >= 36)
            {
                return "Product Name cannot exceed 35 chars";
            }
            else if (StockVariants < 1)
            {
                return "StockVariety cannot be less than 1";
            }
            else if (StockVariants > 300)
            {
                return "StockVariety cannot exceed be less than 300";
            }
            else if (LastRestockDate <= DateTime.Now.AddYears(-1).AddDays(-1))
            {
                return "LastRestockDate need to be within a year";
            }
            else if (LastRestockDate > DateTime.Now)
            {
                return "LastRestockDate  cannot be tomorrow";
            }
            else if (Price < 1)
            {
                return "Price cannot be less than 0.1";
            }
            else if (Price > decimal.MaxValue)
            {
                return "Price cannot be higher than the max value available for decimals";
            }
            else
            {
                return "";
            }
        }
    }
}
