using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing6
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class tstStaff
    {
        public object Assert { get; private set; }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }
        [TestMethod]
        public void DateOfBirth()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff[TestMethod]
        public void DateAddedPropertyOK()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //create some test data to assign to the property
                DateTime TestData = DateTime.Now.Date;
                //assign the data to the property
                AnStaff.DateAdded = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnStaff.DateAdded, TestData);
            }


        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.AddressNo, TestData);
        }

    
        [TestMethod]
        public void NINumberNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnStaff.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.HouseNo, TestData);
        }

        [TestMethod]
        public void TaxCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PostCode, TestData);
        }

        [TestMethod]
        public void ContactNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnStaff.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStafff.Street, TestData);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnAddress.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Town, TestData);
        }
    }

    internal class clsStaff
    {
    }
}
();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }


        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.AddressNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.AddressNo, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnAddress.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnAddress.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnAddress.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnAddress.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Town, TestData);
        }
    }
}









