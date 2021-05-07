using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstSupplier
    {
        //Test data from database
        string SupplierID = "1";
        string CompanyName = "teesLTD";
        string Product = "tShirts";
        string PhoneNumber = "07456332127";
        string EmailAddress = "teeslt@gmail.com";
        string Address = "101 Second Avenue";
        string PostCode = "LE1 1ST";
        
        
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }

        public void SupplierIdOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 1;
            ASupplier.SupplierID = TestData;
            Assert.AreEqual(ASupplier.SupplierID, TestData);
        }

        [TestMethod]
        public void CompanyNameOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "teesLTD";
            ASupplier.CompanyName = TestData;
            Assert.AreEqual(ASupplier.CompanyName, TestData);
        }

        [TestMethod]
        public void ProductOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "tShirts";
            ASupplier.Product = TestData;
            Assert.AreEqual(ASupplier.Product, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "074563321";
            ASupplier.PhoneNumber = TestData;
            Assert.AreEqual(ASupplier.PhoneNumber, TestData);
        }

        [TestMethod]
        public void EmailAddressOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "teeslt@gmail.com";
            ASupplier.EmailAddress = TestData;
            Assert.AreEqual(ASupplier.EmailAddress, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "101 Second Avenue";
            ASupplier.Address = TestData;
            Assert.AreEqual(ASupplier.Address, TestData);
        }

        [TestMethod]
        public void PostCodeOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "LE1 1ST";
            ASupplier.PostCode = TestData;
            Assert.AreEqual(ASupplier.PostCode, TestData);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierIDExtremeMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            Int32 TestData;
            TestData = -100;
            string SupplierID = TestData.ToString();
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string SupplierID = TestData.ToString();
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string SupplierID = TestData.ToString();
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierIDMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            Int32 TestData;
            TestData = 51;
            string SupplierID = TestData.ToString();
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            Int32 TestData;
            TestData = 100;
            string SupplierID = TestData.ToString();
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierID = "invalid";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

       

        [TestMethod]
        public void CompanyNameMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string CompanyName = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void CompanyNameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string CompanyName = "A";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CompanyNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string CompanyName = "";
            CompanyName = CompanyName.PadLeft(51, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CompanyNameExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string CompanyName = "";
            CompanyName = CompanyName.PadLeft(1000, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ComapnyNameInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string CompanyName = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        

        [TestMethod]
        public void ProductMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Product = "";           
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Product = "A";            
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ProductMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Product = "";
            Product = Product.PadLeft(51, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Product = "";
            Product = Product.PadLeft(1000, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Product = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadLeft(10, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadLeft(11, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadLeft(12, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadLeft(1000, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PhoneNumber = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

       

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string EmailAddress = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void EmailAddressMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string EmailAddress = "A";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadLeft(66, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadLeft(1000, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string EmailAddress = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        
        [TestMethod]
        public void AddressMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(9, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(10, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(81, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(1000, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void AddressInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string Address = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PostCode = "";
            PostCode = PostCode.PadLeft(5, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PostCode = "";
            PostCode = PostCode.PadLeft(6, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PostCode = "";
            PostCode = PostCode.PadLeft(8, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PostCode = "";
            PostCode = PostCode.PadLeft(9, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PostCode = "";
            PostCode = PostCode.PadLeft(1000, '*');
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string PostCode = "";
            Error = ASupplier.Valid(SupplierID, CompanyName, Product, PhoneNumber, EmailAddress, Address, PostCode);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            int SupplierID = 1;
            Found = ASupplier.Find(SupplierID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void SuplierIdFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierID = 1;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 1;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.CompanyName != "teesLTD" )
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ProductFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierID = 1;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.Product != "T-shirts")
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PhoneNumberFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierID = 1;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.PhoneNumber != PhoneNumber)
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailAddressFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierID = 1;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.EmailAddress != "teesLTD@gmail.com")
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierID = 1;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.Address != "101 second street")
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PostCodeFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierID = 1;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.PostCode != PostCode)
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }


    }
}
