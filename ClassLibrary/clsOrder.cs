using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        public string ProductDescription { get; set; }
        public bool Item { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public int Customer { get; set; }
        public int OrderId { get; set; }
        public decimal Price { get; set; }
        public char Colour { get; set; }

        public string Valid(string Pdescription)
        {
            if (Pdescription.Length < 1)
            {
                return "Product Description cannot be blank";
            }
            else if (Pdescription.Length > 50)
            {
                return "Product Description cannot exceed 50 chars";
            }
            else
            {
                return "";
            }
        }
    }
}