using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 mSupplierID;
        public Int32 SupplierID
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }
        }

        private string mCompanyName;     
        public string CompanyName
        {
            get
            {
                return mCompanyName;
            }
            set
            {
                mCompanyName = value;
            }            
        }

        private string mPhoneNumber;
        public string PhoneNumber {
            get
            {
                return mPhoneNumber;
            } 
            set
            {
                mPhoneNumber = value;
            } 
        }

        private string mProduct;
        public string Product
        {
            get
            {
                return mProduct;
            }   
            set
            {
                mProduct = value;
            }   
        }

        private string mEmailAddress;
        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }   
            set
            {
                mEmailAddress = value;
            }
        }

       
        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }   
            set
            {
                mAddress = value;
            }
        }

        private string mPostCode;
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }


          public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mCompanyName = Convert.ToString(DB.DataTable.Rows[0]["CompanyName"]);
                mProduct = Convert.ToString(DB.DataTable.Rows[0]["Product"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                return true;
            }
            
            else
            {
                return false;
            }
        }

        public string Valid(string supplierId, string companyName, string product, string phoneNumber, string emailAddress, string address, string postCode)
        {
            String Error = "";
            int SupplierIDTemp;

            if (companyName.Length < 1)
            {
                Error = Error + "Company name cannot be blank: ";
            }
            if (companyName.Length > 50)
            {
                Error = Error + "Company Name cannot exceed 100 chars: ";
            }
            if (product.Length < 1)
            {
                Error = Error + "Product cannot be blank: ";
            }
            if (product.Length > 35)
            {
                Error = Error + "Product cannot exceed 50 chars: ";
            }
            if (phoneNumber.Length < 11)
            {
                Error = Error + "PhoneNumber cannot be less than 11 chars: ";
            }
            if (phoneNumber.Length > 11)
            {
                Error = Error + "PhoneNumber cannot exceed 11 chars: ";
            }
            if (emailAddress.Length < 1)
            {
                Error = Error + "Email Address cannot be blank: ";
            }
            if (emailAddress.Length > 65)
            {
                Error = Error + "Email Address cannot exceed 65 chars: ";
            }
            if (address.Length < 10)
            {
                Error = Error + "Address cannot be less than 10 chars: ";
            }
            if (address.Length > 80)
            {
                Error = Error + "Address cannot exceed 80 chars: ";
            }
            if (postCode.Length < 6)
            {
                Error = Error + "PostCode cannot be less than 6 chars: ";
            }
            if (postCode.Length > 8)
            {
                Error = Error + "PostCode cannot exceed 8 chars: ";
            }
            try
            {
                SupplierIDTemp = Convert.ToInt32(supplierId);
                if (SupplierIDTemp < 1)
                {
                    Error = Error + "Product Id cannot be 0: ";
                }
                if (SupplierIDTemp > 50)
                {
                    Error = Error + "Product Id cannot be more than 50: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for ProductId: ";
            }

            return Error;
        }
    }
}
