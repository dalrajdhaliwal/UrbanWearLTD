using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);


        }


        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@ContactNumber", mThisStaff.ContactNumber);
            DB.AddParameter("@DateStarted", mThisStaff.DateStarted);
            DB.AddParameter("@DateEnded", mThisStaff.DateEnded);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@NINumber", mThisStaff.NINumber);
            DB.AddParameter("@TaxCode", mThisStaff.TaxCode);
            DB.AddParameter("@Shift", mThisStaff.Shift);



            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffFirstName", StaffFirstName);
            DB.Execute("sproc_tblStaff_FilterByName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();

            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();


                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AnStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.DateStarted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateStarted"]);
                AnStaff.DateEnded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateEnded"]);
                AnStaff.Salary = Convert.ToDecimal(DB.DataTable.Rows[Index]["Salary"]);

                mStaffList.Add(AnStaff);
                Index++;
            }


        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@DateStarted", mThisStaff.DateStarted);
            DB.AddParameter("@DateEnded", mThisStaff.DateEnded);
            DB.AddParameter("@Salary", mThisStaff.Salary);

            return DB.Execute("sproc_tblStaffManagement_Insert");
        }


    }


}
