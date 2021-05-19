﻿using System;
using System.Linq;


namespace Testing6
{
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
        public void TestStaffLastName()
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





















