using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        private List<clsOrder> mOrderList;

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;

            }
        }




        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }






        public clsOrder ThisOrder { get; set; }
    }
}