using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            TestItem.StaffID = 8;
            TestItem.Availability = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
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
            TestItem.StaffID = 8;
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
            TestItem.StaffID = 8;
            TestItem.Availability = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 1;
            TestItem.CustomerNo = 10;
            TestItem.CustomerAddress = "45 Linton Street";
            TestItem.ItemColour = "white";
            TestItem.ItemPrice = 19;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductDescription = "white shirt";
            TestItem.StaffID = 15;
            TestItem.Availability = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        [TestMethod]
        public void UpddateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //test data to update
            TestItem.CustomerNo = 10;
            TestItem.CustomerAddress = "45 Linton Street";
            TestItem.ItemColour = "white";
            TestItem.ItemPrice = 19;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductDescription = "white shirt";
            TestItem.StaffID = 15;
            TestItem.Availability = true;
            AllOrders.ThisOrder = TestItem;
            TestItem.OrderID = PrimaryKey;
            //new test data
            TestItem.CustomerNo = 12;
            TestItem.CustomerAddress = "36 Linton Street";
            TestItem.ItemColour = "white";
            TestItem.ItemPrice = 21;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductDescription = "white shirt";
            TestItem.StaffID = 18;
            TestItem.Availability = true;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //data to delete
            TestItem.CustomerNo = 13;
            TestItem.CustomerAddress = "38 Linton Street";
            TestItem.ItemColour = "white";
            TestItem.ItemPrice = 21;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductDescription = "blue shirt";
            TestItem.StaffID = 12;
            TestItem.Availability = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void FilterByCustomerAddressMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.FilterByCustomerAddress("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);

        }

        [TestMethod]
        public void FilterByCustomerAddressNoneFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.FilterByCustomerAddress("xxxxxxxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);

        }


        [TestMethod]
        public void FilterByCustomerAddressTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.FilterByCustomerAddress("37");
            if (FilteredOrders.Count == 1)
            {
                if (FilteredOrders.OrderList[0].OrderID != 6)
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