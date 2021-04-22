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
        clsOrder AOrder = new clsOrder();
        string OrderID = txtOrderID.Text;
        string CustomerNo = txtCustomerNo.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string ItemColour = txtItemColour.Text;
        string ItemPrice = txtItemPrice.Text;
        string OrderDate = txtOrderDate.Text;
        string ProductDescription = txtProductDescription.Text;
        string Error = "";

        Error = AOrder.Valid(OrderID, CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription);

        if (Error == "")

        {
            AOrder.OrderID = Convert.ToInt32(OrderID);
            AOrder.CustomerNo = Convert.ToInt32(CustomerNo);
            AOrder.CustomerAddress = txtCustomerAddress.Text;
            AOrder.ItemColour = txtItemColour.Text;
            AOrder.ItemPrice = Convert.ToDecimal(ItemPrice);
            AOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AOrder.ProductDescription = txtProductDescription.Text;
            AOrder.Availability = chkAvailability.Checked;
            Session["AOrder"] = AOrder;
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
            txtOrderID.Text = AOrder.OrderID.ToString();
            txtCustomerNo.Text = AOrder.CustomerNo.ToString();
            txtCustomerAddress.Text = AOrder.CustomerAddress;
            txtItemColour.Text = AOrder.ItemColour;
            txtItemPrice.Text = AOrder.ItemPrice.ToString();
            txtOrderDate.Text = AOrder.OrderDate.ToString();
            txtProductDescription.Text = AOrder.ProductDescription;
            chkAvailability.Checked = AOrder.Availability;



        }

    }
}