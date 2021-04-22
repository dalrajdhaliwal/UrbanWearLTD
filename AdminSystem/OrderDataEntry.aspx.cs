using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsOrder
        clsOrder AOrder = new clsOrder();

        string ProductDescription = txtProductDescription.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string ItemColour = txtItemColour.Text;
        string OrderDate = txtOrderDate.Text;
        string OrderID = txtOrderID.Text;
        string CustomerNo = txtCustomerNo.Text;
        string ItemPrice = txtItemPrice.Text;
        string Error = "";
        Error = AOrder.Valid(OrderID, CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);
        if (Error == "")
        {
            //AOrder.OrderID = OrderID;
            //AOrder.CustomerNo = CustomerNo;
            AOrder.CustomerAddress = CustomerAddress;
            AOrder.ProductDescription = ProductDescription;
            //AOrder.OrderDate = OrderDate;
            AOrder.ItemColour = ItemColour;
            //AOrder.ItemPrice = ItemPrice;
        }


        Session["AOrder"] = AOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx"); 
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AOrder.Find(OrderID);
        if (Found == true)
        {
            //txtOrderID.Text = AOrder.OrderID;
            txtCustomerAddress.Text = AOrder.CustomerAddress;
            txtProductDescription.Text = AOrder.ProductDescription;
            //txtOrderDate.Text = AOrder.OrderDate;
           // txtOrderID.Text = AOrder.OrderID;
            //txtOrderID.Text = AOrder.OrderID;
        }
         
    }
}