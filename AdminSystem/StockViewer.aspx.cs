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
        clsStock AStock = new clsStock();
        AStock = (clsStock)Session["AStock"];
        Response.Write("ProductId: " + AStock.ProductId + "<br/>");
        Response.Write("ProductName: " + AStock.ProductName + "<br/>");
        Response.Write("ProductDescription: " + AStock.ProductDescription + "<br/>");
        Response.Write("Price: " + AStock.Price + "<br/>");
        Response.Write("InStock: " + AStock.InStock + "<br/>");
        Response.Write("LastRestockDate: " + AStock.LastRestockDate + "<br/>");
        Response.Write("StockVariants: " + AStock.StockVariants + "<br/>");
    }
}