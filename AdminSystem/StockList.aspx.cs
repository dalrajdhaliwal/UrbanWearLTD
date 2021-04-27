using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
            DisplayStocks();
    }

    void DisplayStocks()
    {
        clsStockCollection AStock = new clsStockCollection();
        lstStock.DataSource = AStock.StockList;
        lstStock.DataValueField = "ProductId";
        lstStock.DataTextField = "ProductName";
        lstStock.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Session["ProductId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edit
        Int32 ProductId;
        //if a record is found
        if (lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductId = Convert.ToInt32(lstStock.SelectedValue);
            Session["ProductId"] = ProductId;
            Response.Redirect("StockDataEntry.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductId;
        if (lstStock.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstStock.SelectedValue);
            Session["ProductId"] = ProductId;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.FilterByProductName(txtFilter.Text);
        lstStock.DataSource = Stocks.StockList;
        lstStock.DataValueField = "ProductId";
        lstStock.DataTextField = "ProductName";
        lstStock.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.FilterByProductName("");
        txtFilter.Text = "";
        lstStock.DataSource = Stocks.StockList;
        lstStock.DataValueField = "ProductId";
        lstStock.DataTextField = "ProductName";
        lstStock.DataBind();
    }
}