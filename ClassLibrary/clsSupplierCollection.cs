using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();


        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;

            }
        }

        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
        }


        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //later
            }
        }





        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }



        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();
                ASupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.CompanyName = Convert.ToString(DB.DataTable.Rows[Index]["CompanyName"]);
                ASupplier.Product = Convert.ToString(DB.DataTable.Rows[Index]["Product"]);
                ASupplier.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                ASupplier.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ASupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ASupplier.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                mSupplierList.Add(ASupplier);
                Index++;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CompanyName", mThisSupplier.CompanyName);
            DB.AddParameter("@Product", mThisSupplier.Product);
            DB.AddParameter("@PhoneNumber", mThisSupplier.PhoneNumber);
            DB.AddParameter("@EmailAddress", mThisSupplier.EmailAddress);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@PostCode", mThisSupplier.PostCode);
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@CompanyName", mThisSupplier.CompanyName);
            DB.AddParameter("@Product", mThisSupplier.Product);
            DB.AddParameter("@PhoneNumber", mThisSupplier.PhoneNumber);
            DB.AddParameter("@EmailAddress", mThisSupplier.EmailAddress);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@PostCode", mThisSupplier.PostCode);

            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void FilterByCompanyName(string CompanyName)
        {
            //Filters the records based on a full or partial Company Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the SupplierID parameter to the database
            DB.AddParameter("@CompanyName", CompanyName);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterByCompanyName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
