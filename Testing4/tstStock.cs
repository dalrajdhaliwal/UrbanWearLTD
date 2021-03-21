using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        private int ProductId = 22;
        private string ProductName = "Jacket";
        private string ProductDescription = "whatever description";
        private decimal Price = 5;
        private DateTime LastRestockDate = DateTime.Now;
        private int InStock = 89;
        private int StockVariants = 205;





        [TestMethod]
        public void ProductDescriptionOK()
        {
            clsStock AStock = new clsStock();
            string TestData = ProductDescription;
            AStock.ProductDescription = TestData;
            Assert.AreEqual(AStock.ProductDescription, TestData);
        }

        [TestMethod]

        public void LastRestockDateOK()

        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.LastRestockDate = TestData;
            Assert.AreEqual(AStock.LastRestockDate, TestData);
        }

        [TestMethod]

        public void ProductNameOK()

        {
            clsStock AStock = new clsStock();
            String TestData = "Product Name";
            AStock.ProductName = TestData;
            Assert.AreEqual(AStock.ProductName, TestData);
        }

        [TestMethod]

        public void InStockOK()

        {
            clsStock AStock = new clsStock();
            int TestData = 121;
            AStock.InStock = TestData;
            Assert.AreEqual(AStock.InStock, TestData);
        }

        [TestMethod]

        public void ProductIdOK()

        {
            clsStock AStock = new clsStock();
            int TestData = 134;
            AStock.ProductId = TestData;
            Assert.AreEqual(AStock.ProductId, TestData);
        }

        [TestMethod]

        public void PriceOk()

        {
            clsStock AStock = new clsStock();
            decimal TestData = 35;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void StockVariantsOk()
        {
            clsStock AStock = new clsStock();
            int TestData = 'r';
            AStock.StockVariants = TestData;
            Assert.AreEqual(AStock.StockVariants, TestData);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "a";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadLeft(100, '*');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadLeft(101, '*');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ProductIdMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int ProductId = 0;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int ProductId = 1;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int ProductId = 50;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int ProductId = 501;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "b";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductNameMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadLeft(35, '*');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadLeft(36, '*');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InStockMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int InStock = 0;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InStockMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int InStock = 1;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InStockMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int InStock = 100;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InStockMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int InStock = 101;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockVariantsMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockVariants = 0;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StockVariantsMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockVariants = 1;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockVariantsMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockVariants = 300;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockVariantsMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockVariants = 301;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void LastRestockDateMinMinusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime LastRestockDate;
            LastRestockDate = DateTime.Now.Date; LastRestockDate = LastRestockDate.AddYears(-1).AddDays(-1);
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastRestockDateMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime LastRestockDate;
            LastRestockDate = DateTime.Now.Date; LastRestockDate = LastRestockDate.AddYears(-1);
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastRestockDateMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime LastRestockDate;
            LastRestockDate = DateTime.Now.Date;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastRestockDateMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime LastRestockDate;
            LastRestockDate = DateTime.Now.Date; LastRestockDate = LastRestockDate.AddDays(+1);
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            decimal Price = 0;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price); Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            decimal Price = 1;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price); Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            decimal Price = decimal.MaxValue;
            Error = AStock.Valid(ProductId, ProductDescription, InStock, ProductName, StockVariants, LastRestockDate, Price); Assert.AreEqual(Error, "");
        }



    }
}
