using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        //good test data
         string ProductId = "22";
         string ProductName = "Jacket";
         string ProductDescription = "whatever description";
         string Price = "5";
         string LastRestockDate = DateTime.Now.Date.ToString();
         string InStock = "89";
         string StockVariants = "205";





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
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
            
        } 
         
         
         
         
         
        [TestMethod]
        public void LastRestockDateExtremeMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50);
            string LastRestockDate = TestDate.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");             
        }          
        [TestMethod]
        public void LastRestockDateMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1).AddDays(-1);
            string LastRestockDate = TestDate.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }    
        [TestMethod]
        public void LastRestockDateMin()

        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string LastRestockDate = TestDate.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastRestockDateMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddMonths(-6);
            string LastRestockDate = TestDate.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastRestockDateMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string LastRestockDate = TestDate.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastRestockDateMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string LastRestockDate = TestDate.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastRestockDateExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(50);
            string LastRestockDate = TestDate.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void LastRestockDateInvalidData()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string LastRestockDate = "invalid";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ProductIdExtremeMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = -100;
            string ProductId = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string ProductId = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string ProductId = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 25;
            string ProductId = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 50;
            string ProductId = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 51;
            string ProductId = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 500;
            string ProductId = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdInvalidData()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductId = "invalid";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void InStockExtremeMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = -1000;
            string InStock = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void InStockMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string InStock = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void InStockMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string InStock = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InStockMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 50;
            string InStock = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void InStockMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 100;
            string InStock = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InStockMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 101;
            string InStock = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void InStockExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 5000;
            string InStock = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void InStockInvalidData()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string InStock = "invalid";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void StockVariantsExtremeMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = -1000;
            string StockVariants = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void StockVariantsMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string StockVariants = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockVariantsMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string StockVariants = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StockVariantsMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 150;
            string StockVariants = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockVariantsMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 300;
            string StockVariants = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StockVariantsMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 301;
            string StockVariants = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockVariantsExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Int32 TestData;
            TestData = 5000;
            string StockVariants = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StockVariantsInvalidData()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockVariants = "invalid";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");

        }        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Decimal TestData;
            TestData = -1000;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Decimal TestData;
            TestData = 0;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Decimal TestData;
            TestData = 1;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Decimal TestData;
            TestData = decimal.MaxValue / 2;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Decimal TestData;
            TestData = decimal.MaxValue;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string Price = "Not valid data";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "a";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(50, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(100, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(101, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(10000, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "a";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(17, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(35, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(36, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(10000, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.ProductId != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.ProductName != ("aa"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestLastRestockDateFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.LastRestockDate != Convert.ToDateTime("19/03/2021"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.InStock != 5)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStockVariantsFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.StockVariants != 2)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestIPriceFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.Price != 5)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestProductDescriptionFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.ProductDescription != "aa")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

    }
}

