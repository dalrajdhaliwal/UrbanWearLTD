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
        Response.Write(AOrder.ProductDescription);
        Response.Write(AOrder.CustomerAddress);
        Response.Write(AOrder.OrderID);
        Response.Write(AOrder.CustomerNo);
        Response.Write(AOrder.ItemPrice);
        Response.Write(AOrder.ItemColour);
        Response.Write(AOrder.OrderDate);
        
    }
}