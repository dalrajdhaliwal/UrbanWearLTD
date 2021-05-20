using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
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

        internal bool Find(int staffId)
        {
            throw new NotImplementedException();
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

        internal string Valid(string staffLastName, string staffFirstName, string nINumber, string dateStarted, string taxCode, string contactNumber, string dateEnded)
        {
            throw new NotImplementedException();
        }
    }
}



        
    
