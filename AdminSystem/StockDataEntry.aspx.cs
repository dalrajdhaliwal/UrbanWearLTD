using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            if (ProductId != -1)
            {
                DisplayStock();
            }
        }
    }
    private void DisplayStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(ProductId);
        //display data for the record
        txtProductId.Text = StockBook.ThisStock.ProductId.ToString();
        txtProductName.Text = StockBook.ThisStock.ProductName;
        txtProductDescription.Text = StockBook.ThisStock.ProductDescription;
        txtPrice.Text = StockBook.ThisStock.Price.ToString();
        txtInStock.Text = StockBook.ThisStock.InStock.ToString();
        txtLastRestockDate.Text = StockBook.ThisStock.LastRestockDate.ToString();
        txtStockVariants.Text = StockBook.ThisStock.StockVariants.ToString();
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 ProductId;
        Boolean Found = false;
        ProductId = Convert.ToInt32(txtProductId.Text);
        Found = AStock.Find(ProductId);
        if (Found == true)
        {
            txtProductId.Text = AStock.ProductId.ToString();
            txtProductName.Text = AStock.ProductName;
            txtProductDescription.Text = AStock.ProductDescription;
            txtPrice.Text = AStock.Price.ToString();
            txtInStock.Text = AStock.InStock.ToString();
            txtLastRestockDate.Text = AStock.LastRestockDate.ToString();
            txtStockVariants.Text = AStock.StockVariants.ToString();

        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        string ProductId = txtProductId.Text;
        string ProductName = txtProductName.Text;
        string ProductDescription = txtProductDescription.Text;
        string Price = txtPrice.Text;
        string InStock = txtInStock.Text;
        string LastRestockDate = txtLastRestockDate.Text;
        string StockVariants = txtStockVariants.Text;
        string Error = "";
        Error = AStock.Valid(ProductId, ProductDescription, InStock, LastRestockDate, Price, ProductName, StockVariants);
        if (Error == "")
        {
            AStock.ProductId = Convert.ToInt32(ProductId);
            AStock.ProductName = txtProductName.Text;
            AStock.ProductDescription = txtProductDescription.Text;
            AStock.Price = Convert.ToDecimal(Price);
            AStock.InStock = Convert.ToInt32(InStock);
            AStock.LastRestockDate = Convert.ToDateTime(txtLastRestockDate.Text);
            AStock.StockVariants = Convert.ToInt32(StockVariants);
            clsStockCollection StockList = new clsStockCollection();
            if (this.ProductId == -1)
            {
                StockList.ThisStock = AStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(Convert.ToInt32(ProductId));
                StockList.ThisStock = AStock;
                StockList.Update();
            }

            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}
