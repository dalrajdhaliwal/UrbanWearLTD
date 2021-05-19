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
        [TestMethod]
        public void Shift()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean TestData = true;

            AnStaff.Active = TestData;

            Assert.AreEqual(AnStaff.Active, TestData);
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
    }
}
//public DateTime DateTemp { get; private set; }

public bool Find(int staffId)
{
    clsDataConnection DB = new clsDataConnection();
    DB.AddParameter("@StaffId", staffId);
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
        return true;
        mTaxCode = Convert.ToString(DB.DataTable.Rows[0]["TaxCode"]);
        mNINumber = Convert.ToString(DB.DataTable.Rows[0]["NINumber"]);
        mShift = Convert.ToBoolean(DB.DataTable.Rows[0]["Shift"]);

    }
    else
    {
        return false;
    }

}

public string Valid(string StaffFirstName, string StaffLastName, string NINumber, string dateStarted, string dateEnded,string TaxCode, string ContactNumber)
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











