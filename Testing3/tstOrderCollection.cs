using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
       [TestMethod]
       public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }


        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerNo = 10;
            TestItem.CustomerAddress = "39 Random Street";
            TestItem.ItemColour = "red";
            TestItem.ItemPrice = 7;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductDescription = "white shirt";
            TestItem.Availability = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 SomeCount = 0;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerNo = 10;
            TestItem.CustomerAddress = "39 Random Street";
            TestItem.ItemColour = "red";
            TestItem.ItemPrice = 7;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductDescription = "white shirt";
            TestItem.Availability = true;
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerNo = 10;
            TestItem.CustomerAddress = "39 Random Street";
            TestItem.ItemColour = "red";
            TestItem.ItemPrice = 7;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductDescription = "white shirt";
            TestItem.Availability = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }



        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }

    }
}