using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        private string Pdescription = "Random Description";
        int OrderId = 3;
        int CustomerNo = 36;
        string OrderDate = DateTime.Now.Date.ToString();
        char ItemColour = 'r';
        bool Availability = true;
        string CustomerAddress = "LE2 1PQ";
        decimal ItemPrice = 10;


        [TestMethod]
        public void ProductDescriptionOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = Pdescription;
            AOrder.ProductDescription = TestData;
            Assert.AreEqual(AOrder.ProductDescription, TestData);
        }

        [TestMethod]
        public void AvailabilityOK()
        {
            clsOrder AOrder = new clsOrder();
            Boolean TestData = true;
            AOrder.Item = TestData;
            Assert.AreEqual(AOrder.Item, TestData);
        }
        [TestMethod]
        public void OrderDateOK()
        {
            clsOrder AOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AOrder.OrderDate = TestData;
            Assert.AreEqual(AOrder.OrderDate, TestData);
        }        [TestMethod]
        public void CustomerAddressOK()
        {
            clsOrder AOrder = new clsOrder();
            String TestData = "Delivery Address";
            AOrder.Address = TestData;
            Assert.AreEqual(AOrder.Address, TestData);
        }        [TestMethod]
        public void CustomerNumberOK()
        {
            clsOrder AOrder = new clsOrder();
            int TestData = 121;
            AOrder.Customer = TestData;
            Assert.AreEqual(AOrder.Customer, TestData);
        }        [TestMethod]
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
            AOrder.Price = TestData;
            Assert.AreEqual(AOrder.Price, TestData);
        }

        [TestMethod]
        public void ItemColourOk()
        {
            clsOrder AOrder = new clsOrder();
            char TestData = 'r';
            AOrder.Colour = TestData;
            Assert.AreEqual(AOrder.Colour, TestData);

        }

    }
}