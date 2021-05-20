using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;


namespace Testing6
{


    [TestClass]
    public class tstStaff
    {
        //private int mStaff;

        //good test data
        String StaffFirstName = "Kim";
        String StaffLastName = "Amir";
        String TaxCode = "P56";
        String NINumber = "P56";
        String ContactNumber = "0765432";
        String DateStarted = DateTime.Now.Date.ToString();
        String DateEnded = DateTime.Now.Date.ToString();


        public DateTime mDateStarted { get; private set; }
        public string mName { get; private set; }
        public bool Found { get; private set; }

public bool OK { get; private set; }
        public object name { get; private set; }

        public class clsStaff   
    {
        private String mStaffLastName;
        public string StaffLastName
        {

            get
            {
                return mStaffLastName;

            }
            set
            {
                mStaffLastName = value;
            }
        }

        private String mContactNumber;
        public string ContactNumber
        {
            get
            {
                return mContactNumber;
            }

            set
            {
                mContactNumber = value;
            }
        }
        private DateTime mDateEnded;
        public DateTime DateEnded
        {
            get
            {
                return mDateEnded;
            }

            set
            {
                mDateEnded = value;
            }
        }

        private String mStaffFirstName;
        public string StaffFirstName
        {
            get
            {
                return mStaffFirstName;

            }
            set
            {
                mStaffFirstName = value;
            }
        }
        private Decimal mSalary;
        public decimal Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }

        private Int32 mStaffId;
        public Int32 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }
        private DateTime mDateStarted;
        public DateTime DateStarted
        {
            get
            {
                return mDateStarted;
            }

            set
            {
                mDateStarted = value;
            }
        }
        private String mNINumber;
        public string NINumber
        {
            get
            {
                return mNINumber;

            }
            set
            {
                mNINumber = value;
            }
        }
        private String mTaxCode;
        public string TaxCode
        {
            get
            {
                return mTaxCode;

            }
            set
            {
                mTaxCode = value;
            }
        }
        private Boolean mShift;
        private bool OK;

        public Boolean Shift
        {
            get
            {
                return mShift;

            }
            set
            {
                mShift = value;
            }
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 1;
            Found = AnStaff.Find(StaffId);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(Found);
        }

        private bool Find(int staffId)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestDateStartedFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 1;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.DateStarted != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateEndedFound()
        {
            clsStaff AnStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            Int32 StaffId = 4;
            DateTime DateEnded = Convert.ToDateTime("16/09/2019");
            Found = AnStaff.Find(StaffId);
            if (AnStaff.DateEnded != Convert.ToDateTime("01/12/2018"))
            {
                OK = false;
            }
        }
        [TestMethod]
        public void TestStaffFirstName()
        {
            clsStaff AnStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            Int32 StaffId = 4;
            String Name = Convert.ToString("Nabira");
            Found = AnStaff.Find(StaffId);
            if (AnStaff.StaffFirstName != Convert.ToString("Kim"))
            {
                OK = false;
            }
        }
        [TestMethod]
        public void TestStaffLastNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            Int32 StaffId = 4;
            String StaffLastName = Convert.ToString("Peter");
            Found = AnStaff.Find(StaffId);
            if (AnStaff.StaffLastName != Convert.ToString("Amir"))
            {
                OK = false;
            }
        }
        [TestMethod]
        public void TestContactNumberFound()
        {
            clsStaff AnStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            Int32 StaffId = 4;
            String ContactNumber = Convert.ToString("0765489");
            Found = AnStaff.Find(StaffId);
            if (AnStaff.ContactNumber != Convert.ToString("0827630"))
            {
                OK = false;
            }
        }
        [TestMethod]
        public void TestTaxCodeFound()
        {
            clsStaff AnStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            Int32 StaffId = 4;
            String TaxCode = Convert.ToString("0765489");
            Found = AnStaff.Find(StaffId);
            if (AnStaff.TaxCode != Convert.ToString("M98"))
            {
                OK = false;
            }
        }
        [TestMethod]
        public void TestNINumberFound()
        {
            clsStaff AnStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            Int32 StaffId = 4;
            String NINumber = Convert.ToString("0765489");
            Found = AnStaff.Find(StaffId);
            if (AnStaff.NINumber != Convert.ToString("8765434"))
            {
                OK = false;
            }
        }
        [TestMethod]
        public void TestShiftFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 4;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.Shift != true)
            {
                OK = false;
            }
        }


        [TestMethod]
        public void TestSalaryFound()
        {
            clsStaff AnStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            String Salary = Convert.ToString("124 College green");
            Int32 StaffId = 4;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.Salary != Convert.ToDecimal("1266.00"))
            {
                OK = false;
            }
        }

            internal string Valid(string staffLastName, string staffFirstName, string nINumber, string dateStarted, string taxCode, string contactNumber, string dateEnded)
            {
                throw new NotImplementedException();
            }
        }
    [TestMethod]
    public void ValidMethodOk()
    {
        clsStaff AnStaff = new clsStaff();
        String Error = "";
        Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
        Assert.AreEqual(Error, "");
        {
            OK = false;
        }
    }

        [TestMethod]
        public void StaffLastNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffLastName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "a";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "aa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(49, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(50, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(25, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffFirstNameExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void NINumberMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string NINumber = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NINumberMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string NINumber = "a";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NINumberMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string NINumber = "aa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void NINumberMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string NINumber = "aaaaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NINumberMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string NINumber = "aaaaaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NINumberMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string NINumber = "aaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NINumberMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string NINumber = "";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NINumberExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string NINumber = "";
            NINumber = NINumber.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NINumberExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            NINumber = NINumber.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateStartedExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateStarted = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateStartedMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateStarted = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateStartedMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateStarted = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateStartedMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateStarted = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateStartedExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateStarted = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateEndedExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateEnded = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateEndedMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateEnded = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateEndedMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateEnded = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateEndedMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateEnded = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateEndedExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateEnded = TestDate.ToString();
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateStartedInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string DateStarted = "this is not a date!";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateEndedInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string DateEnded = "this is not a date!";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = "a";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = "aa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = "aaaaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContactNumberMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = "aaaaaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContactNumberMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = "aaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = "";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }
      
        [TestMethod]
        public void TaxCodeMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = " ";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TaxCodeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = "a";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TaxCodeMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = "aa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void TaxCoderMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = "aaaaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TaxCodeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = "aaaaaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TaxCodeMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = "aaa";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TaxCodeMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = "";
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TaxCodeExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = "";
            TaxCode = TaxCode.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TaxCodeExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string TaxCode = "";
            TaxCode = TaxCode.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
            Assert.AreNotEqual(Error, "");

        }


        public string Valid(string StaffFirstName, string StaffLastName, string NINumber, string dateStarted, string dateEnded, string TaxCode, string ContactNumber)
        {
            {
                string Error = "";
                DateTime DateTemp;
                if (name.Length == 0)

                {

                    Error = Error + "The name may not be blank: ";
                }

                if (name.Length > 50)
                {
                    Error = Error + "The name must be less than 50 characters";
                }

                try
                {
                    DateTemp = Convert.ToDateTime(dateStarted);
                    if (DateTemp < DateTime.Now.Date)
                    {
                        Error = Error + "The date cannot be in the past";
                    }

                    if (DateTemp > DateTime.Now.Date)
                    {
                        Error = Error + "The date cannot be in the future";
                    }

                }

                catch
                {
                    Error = Error + "The date was not a valid date";
                }

                if (StaffLastName.Length == 0)

                {

                    Error = Error + "The StaffLastName may not be blank: ";
                }

                if (StaffLastName.Length > 50)
                {
                    Error = Error + "The StaffLastName must be less than 50 characters";
                }
                if (NINumber.Length == 0)

                {

                    Error = Error + "The NINumber may not be blank: ";
                }

                if (NINumber.Length > 50)
                {
                    Error = Error + "The NINumber must be less than 50 characters";
                }

                return Error;
            }

        }
    }

    //public DateTime DateTemp { get; private set; }

    public bool Find(int StaffId)
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@StaffId", StaffId);
        DB.Execute("sproc_tblStaff_FilterByStaffId");
        if (DB.Count == 1)
        {
            mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
            mDateStarted = Convert.ToDateTime(DB.DataTable.Rows[0]["DateStarted"]);
            mDateEnded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateEnded"]);
            mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
            mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
            mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
            mSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["Salary"]);
            mTaxCode = Convert.ToString(DB.DataTable.Rows[0]["TaxCode"]);
            mNINumber = Convert.ToString(DB.DataTable.Rows[0]["NINumber"]);
            mShift = Convert.ToBoolean(DB.DataTable.Rows[0]["Shift"]);
            return true;
        }
        else
        {
            return false;
        }

    }
}






















