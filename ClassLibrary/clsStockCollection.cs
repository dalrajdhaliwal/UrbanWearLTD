using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStaff> mStockList = new List<clsStaff>();
        clsStaff mThisStock = new clsStaff();


        public List<clsStaff> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;

            }
        }

        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStocks_SelectAll");
            PopulateArray(DB);
        }


        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //later
            }
        }





        public clsStaff ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }



        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mStockList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AStock = new clsStaff();
                AStock.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AStock.StaffFirstName = Convert.ToInt32(DB.DataTable.Rows[Index]["InStock"]);
                AStock.StockVariants = Convert.ToInt32(DB.DataTable.Rows[Index]["StockVariants"]);
                AStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AStock.LastRestockDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastRestockDate"]);
                AStock.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                mStockList.Add(AStock);
                Index++;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@InStock", mThisStock.StaffFirstName);
            DB.AddParameter("@StockVariants", mThisStock.StockVariants);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("@LastRestockDate", mThisStock.LastRestockDate);
            return DB.Execute("sproc_tblStocks_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", mThisStock.StaffId);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@InStock", mThisStock.StaffFirstName);
            DB.AddParameter("@StockVariants", mThisStock.StockVariants);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("@LastRestockDate", mThisStock.LastRestockDate);

            DB.Execute("sproc_tblStocks_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", mThisStock.StaffId);
            DB.Execute("sproc_tblStocks_Delete");
        }

        public void FilterByProductName(string ProductName)
        {
            //Filters the records based on a full or partial ProductName
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ProductId parameter to the database
            DB.AddParameter("@ProductName", ProductName);
            //execute the stored procedure
            DB.Execute("sproc_tblStocks_FilterByProductName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}