using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        string ProductDescription = "Random Description";
        string CustomerNo = "36";
        string OrderDate = DateTime.Now.Date.ToString();
        string ItemColour = "red";
        string CustomerAddress = "LE5 1QQ, 39 Random Street";
        string ItemPrice = "10";


        [TestMethod]
        public void ProductDescriptionOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "Random";
            AOrder.ProductDescription = TestData;
            Assert.AreEqual(AOrder.ProductDescription, TestData);
        }

        [TestMethod]

        public void AvailabilityOK()

        {
            clsOrder AOrder = new clsOrder();
            Boolean TestData = true;
            AOrder.Availability = TestData;
            Assert.AreEqual(AOrder.Availability, TestData);
        }

        [TestMethod]

        public void OrderDateOK()

        {
            clsOrder AOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AOrder.OrderDate = TestData;
            Assert.AreEqual(AOrder.OrderDate, TestData);
        }

        [TestMethod]

        public void CustomerAddressOK()

        {
            clsOrder AOrder = new clsOrder();
            String TestData = "Delivery Address";
            AOrder.CustomerAddress = TestData;
            Assert.AreEqual(AOrder.CustomerAddress, TestData);
        }

        [TestMethod]

        public void CustomerNoOK()

        {
            clsOrder AOrder = new clsOrder();
            int TestData = 121;
            AOrder.CustomerNo = TestData;
            Assert.AreEqual(AOrder.CustomerNo, TestData);
        }

        [TestMethod]

        public void OrderIdOK()

        {
            clsOrder AOrder = new clsOrder();
            int TestData = 134;
            AOrder.OrderID = TestData;
            Assert.AreEqual(AOrder.OrderID, TestData);
        }

        [TestMethod]

        public void ItemPriceOk()

        {
            clsOrder AOrder = new clsOrder();
            decimal TestData = 35;
            AOrder.ItemPrice = TestData;
            Assert.AreEqual(AOrder.ItemPrice, TestData);
        }

        [TestMethod]
        public void ItemColourOk()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "blue";
            AOrder.ItemColour = TestData;
            Assert.AreEqual(AOrder.ItemColour, TestData);

        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductDescriptionMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "a";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductDescriptionMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(25, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(50, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(51, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(501, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string CustomerAddress = "";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string CustomerAddress = "a";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(12, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(26, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(501, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ItemColourMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "aa";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ItemColourMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "red";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemColourMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            ItemColour = ItemColour.PadRight(5, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemColourMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            ItemColour = ItemColour.PadRight(10, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemColourMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            ItemColour = ItemColour.PadRight(11, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ItemColourExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            ItemColour = ItemColour.PadRight(101, 'a');
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-2).AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-2);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string OrderDate = "Not valid date";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = -1000;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerNoMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 500;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1000;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNoMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1001;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void CustomerNoExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 100001;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void CustomerNoInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string CustomerNo = "Not valid data";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ItemPriceExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = -1000;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ItemPriceMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 0;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ItemPriceMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 1;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemPriceMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = decimal.MaxValue/2;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemPriceMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = decimal.MaxValue;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ItemPriceInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemPrice = "Not valid data";
            Error = AOrder.Valid(CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.OrderID != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.CustomerNo != 876)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.OrderDate != Convert.ToDateTime("20/04/2021"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.Availability != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.CustomerAddress != "LE1 2MA")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestItemColourFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.ItemColour != "red")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestItemPriceFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.ItemPrice != 43)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestProductDescriptionFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.ProductDescription != "Three long sleeve shirts")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


    }
}