using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();
        AOrder = (clsOrder)Session["AOrder"];
        Response.Write("Order ID: " + AOrder.OrderID + "<br/>");
        Response.Write("Customer Number: " + AOrder.CustomerNo + "<br/>");
        Response.Write("Customer Address: " + AOrder.CustomerAddress + "<br/>");
        Response.Write("Item Colour: " + AOrder.ItemColour + "<br/>");
        Response.Write("ItemPrice: " + AOrder.ItemPrice + "<br/>");
        Response.Write("OrderDate: " + AOrder.OrderDate + "<br/>");
        Response.Write("ProductDescription: " + AOrder.ProductDescription + "<br/>");
    }
}