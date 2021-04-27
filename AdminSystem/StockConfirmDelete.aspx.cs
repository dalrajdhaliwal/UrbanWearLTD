using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class StockConfirmDelete : System.Web.UI.Page
{
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(ProductId);
        StockBook.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}