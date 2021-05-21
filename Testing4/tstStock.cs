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
            clsStaff AStock = new clsStaff();
            string TestData = ProductDescription;
            AStock.ProductDescription = TestData;
            Assert.AreEqual(AStock.ProductDescription, TestData);
        }

        [TestMethod]

        public void LastRestockDateOK()

        {
            clsStaff AStock = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStock.LastRestockDate = TestData;
            Assert.AreEqual(AStock.LastRestockDate, TestData);
        }

        [TestMethod]

        public void ProductNameOK()

        {
            clsStaff AStock = new clsStaff();
            String TestData = "Product Name";
            AStock.ProductName = TestData;
            Assert.AreEqual(AStock.ProductName, TestData);
        }

        [TestMethod]

        public void InStockOK()

        {
            clsStaff AStock = new clsStaff();
            int TestData = 121;
            AStock.StaffFirstName = TestData;
            Assert.AreEqual(AStock.StaffFirstName, TestData);
        }

        [TestMethod]

        public void ProductIdOK()

        {
            clsStaff AStock = new clsStaff();
            int TestData = 134;
            AStock.StaffId = TestData;
            Assert.AreEqual(AStock.StaffId, TestData);
        }

        [TestMethod]

        public void PriceOk()

        {
            clsStaff AStock = new clsStaff();
            decimal TestData = 35;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void StockVariantsOk()
        {
            clsStaff AStock = new clsStaff();
            int TestData = 'r';
            AStock.StockVariants = TestData;
            Assert.AreEqual(AStock.StockVariants, TestData);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
            
        } 
         
         
         
         
         
        [TestMethod]
        public void LastRestockDateExtremeMin()
        {
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
            string Error = "";
            string LastRestockDate = "invalid";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ProductIdExtremeMin()
        {
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductId = "invalid";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void InStockExtremeMin()
        {
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
            string Error = "";
            string InStock = "invalid";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void StockVariantsExtremeMin()
        {
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
            string Error = "";
            string StockVariants = "invalid";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");

        }        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
            string Error = "";
            Decimal TestData;
            TestData = 0;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            Decimal TestData;
            TestData = 1;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            Decimal TestData;
            TestData = decimal.MaxValue / 2;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            Decimal TestData;
            TestData = decimal.MaxValue;
            string Price = TestData.ToString();
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string Price = "Not valid data";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants); Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductDescription = "";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMin()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductDescription = "a";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMid()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(50, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(100, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(101, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(10000, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductName = "";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductName = "a";
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(17, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(35, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(36, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsStaff AStock = new clsStaff();
            string Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(10000, 'a');
            Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStock = new clsStaff();
            Boolean Found = false;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            clsStaff AStock = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.StaffId != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            int ProductId = 1;
            Found = AStock.Find(ProductId);
            if (AStock.StaffFirstName != 5)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStockVariantsFound()
        {
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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
            clsStaff AStock = new clsStaff();
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

