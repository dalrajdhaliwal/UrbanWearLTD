using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        private string ProductDescription = "Random Description";
        private int OrderId = 3;
        private int CustomerNo = 36;
        private DateTime OrderDate = DateTime.Now;
        private char ItemColour = 'r';
        private Boolean Availability = true;
        private string CustomerAddress = "LE5 1QQ, 39 Random Street";
        private decimal ItemPrice = 10;


        [TestMethod]
        public void ProductDescriptionOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = ProductDescription;
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
            AOrder.OrderId = TestData;
            Assert.AreEqual(AOrder.OrderId, TestData);
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
            char TestData = 'r';
            AOrder.ItemColour = TestData;
            Assert.AreEqual(AOrder.ItemColour, TestData);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AOrder = new clsOrder();           string Error = "";           Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);           Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "";
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "a";
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadLeft(50, '*');
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadLeft(51, '*');
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderIdMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderId = 0;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderId = 1;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIdMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderId = 500;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIdMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderId = 501;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int CustomerNo = 0;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int CustomerNo = 1;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int CustomerNo = 1000;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int CustomerNo = 1001;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemColourBlank()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            char ItemColour = ' ';
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinMinusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderDate;
            OrderDate = DateTime.Now.Date;            OrderDate = OrderDate.AddYears(-2).AddDays(-1);
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderDate;
            OrderDate = DateTime.Now.Date;            OrderDate = OrderDate.AddYears(-2);
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreEqual(Error, "");
        }        [TestMethod]        public void OrderDateMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderDate;
            OrderDate = DateTime.Now.Date;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderDate;
            OrderDate = DateTime.Now.Date;            OrderDate = OrderDate.AddDays(+1);
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            decimal ItemPrice = 0;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);            Assert.AreNotEqual(Error, "");        }
        [TestMethod]
        public void ItemPriceMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            decimal ItemPrice = 1;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);            Assert.AreEqual(Error, "");        }

        [TestMethod]
        public void ItemPriceMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            decimal ItemPrice = decimal.MaxValue;
            Error = AOrder.Valid(OrderId, ProductDescription, CustomerNo, CustomerAddress, ItemColour, OrderDate, Availability, ItemPrice);            Assert.AreEqual(Error, "");        }



    }
}