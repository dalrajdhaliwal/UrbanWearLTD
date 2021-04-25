using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }


        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductId = 1;
            TestItem.ProductName = "shirt";
            TestItem.StockVariants = 118;
            TestItem.Price = 239;
            TestItem.InStock = 58;
            TestItem.LastRestockDate = DateTime.Now.Date;
            TestItem.ProductDescription = "long sleeve shirt";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }



        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            TestItem.ProductId = 1;
            TestItem.ProductName = "shirt";
            TestItem.StockVariants = 118;
            TestItem.Price = 239;
            TestItem.InStock = 58;
            TestItem.LastRestockDate = DateTime.Now.Date;
            TestItem.ProductDescription = "long sleeve shirt";
            AllStock.ThisStock = TestItem;
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductId = 1;
            TestItem.ProductName = "shirt";
            TestItem.StockVariants = 118;
            TestItem.Price = 239;
            TestItem.InStock = 58;
            TestItem.LastRestockDate = DateTime.Now.Date;
            TestItem.ProductDescription = "long sleeve shirt";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductId = 1;
            TestItem.ProductName = "jeans";
            TestItem.StockVariants = 278;
            TestItem.Price = 17;
            TestItem.InStock = 75;
            TestItem.LastRestockDate = DateTime.Now.Date;
            TestItem.ProductDescription = "tapered jeans";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.ProductId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //test data to update

            TestItem.ProductName = "jeans";
            TestItem.StockVariants = 278;
            TestItem.Price = 17;
            TestItem.InStock = 75;
            TestItem.LastRestockDate = DateTime.Now.Date;
            TestItem.ProductDescription = "tapered jeans";
            AllStock.ThisStock = TestItem;
            TestItem.ProductId = PrimaryKey;
            //new test data
            TestItem.ProductName = "trousers";
            TestItem.StockVariants = 298;
            TestItem.Price = 19;
            TestItem.InStock = 76;
            TestItem.LastRestockDate = DateTime.Now.Date;
            TestItem.ProductDescription = "tepered trousers";
            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //data to delete
            TestItem.ProductName = "jeans";
            TestItem.StockVariants = 278;
            TestItem.Price = 17;
            TestItem.InStock = 75;
            TestItem.LastRestockDate = DateTime.Now.Date;
            TestItem.ProductDescription = "tapered jeans";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.ProductId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void FilterByProductNameMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.FilterByProductName("");
            Assert.AreEqual(AllStock.Count, FilteredStocks.Count);

        }

        [TestMethod]
        public void FilterByProductNameNoneFound()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.FilterByProductName("xxxxxxxxxx");
            Assert.AreEqual(0, FilteredStocks.Count);

        }

        [TestMethod]
        public void FilterByProductNameTestDataFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            Boolean OK = true;
            FilteredStocks.FilterByProductName("shoe");
            if (FilteredStocks.Count == 2)
            {
                if (FilteredStocks.StockList[0].ProductId != 1)
                {
                    OK = false;
                }
                if (FilteredStocks.StockList[1].ProductId != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
