using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);
            
        }
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierID = 1;
            TestItem.CompanyName = "teesLTD";
            TestItem.Product = "tShirts";
            TestItem.PhoneNumber = "07456332127";
            TestItem.EmailAddress = "teeslt@gmail.com";
            TestItem.Address = "101 Second Avenue";
            TestItem.PostCode = "LE1 1ST";
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);

        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierID = 1;
            TestItem.CompanyName = "teesLTD";
            TestItem.Product = "tShirts";
            TestItem.PhoneNumber = "07456332127";
            TestItem.EmailAddress = "teeslt@gmail.com";
            TestItem.Address = "101 Second Avenue";
            TestItem.PostCode = "LE1 1ST";
            AllSupplier.ThisSupplier = TestItem;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierID = 1;
            TestItem.CompanyName = "teesLTD";
            TestItem.Product = "tShirts";
            TestItem.PhoneNumber = "07456332127";
            TestItem.EmailAddress = "teeslt@gmail.com";
            TestItem.Address = "101 Second Avenue";
            TestItem.PostCode = "LE1 1ST";
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierID = 1;
            TestItem.CompanyName = "teesLTD";
            TestItem.Product = "tShirts";
            TestItem.PhoneNumber = "07456332127";
            TestItem.EmailAddress = "teeslt@gmail.com";
            TestItem.Address = "101 Second Avenue";
            TestItem.PostCode = "LE1 1ST";
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            //test data to update

            TestItem.CompanyName = "teesLTD";
            TestItem.Product = "tShirts";
            TestItem.PhoneNumber = "07456332127";
            TestItem.EmailAddress = "teeslt@gmail.com";
            TestItem.Address = "101 Second Avenue";
            TestItem.PostCode = "LE1 1ST";
            TestItem.SupplierID = PrimaryKey;
            //new test data            
            TestItem.CompanyName = "denim4u";
            TestItem.Product = "jeans";
            TestItem.PhoneNumber = "07463234936";
            TestItem.EmailAddress = "denim4u@gmail.com";
            TestItem.Address = "72 Lunt Street";
            TestItem.PostCode = "WV01 3NN";
            AllSupplier.ThisSupplier = TestItem;
            AllSupplier.Update();
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            //data to delete
            TestItem.CompanyName = "teesLTD";
            TestItem.Product = "tShirts";
            TestItem.PhoneNumber = "07456332127";
            TestItem.EmailAddress = "teeslt@gmail.com";
            TestItem.Address = "101 Second Avenue";
            TestItem.PostCode = "LE1 1ST";
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            AllSupplier.Delete();
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void FilterByProductNameMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            FilteredSupplier.FilterByCompanyName("");
            Assert.AreEqual(AllSupplier.Count, FilteredSupplier.Count);

        }

        [TestMethod]
        public void FilterByProductNameNoneFound()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            FilteredSupplier.FilterByCompanyName("xxxxxxxxxx");
            Assert.AreEqual(0, FilteredSupplier.Count);

        }

        [TestMethod]
        public void FilterByCompanyNameTestDataFound()
        {
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSupplier.FilterByCompanyName("d");
            if (FilteredSupplier.Count == 1)
            {
                if (FilteredSupplier.SupplierList[0].SupplierID != 2)
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
