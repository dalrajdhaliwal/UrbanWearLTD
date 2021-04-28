using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
    }

    private void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        //display data for the record
        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtCustomerNo.Text = OrderBook.ThisOrder.CustomerNo.ToString();
        txtCustomerAddress.Text = OrderBook.ThisOrder.CustomerAddress;
        txtItemColour.Text = OrderBook.ThisOrder.ItemColour;
        txtItemPrice.Text = OrderBook.ThisOrder.ItemPrice.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        txtProductDescription.Text = OrderBook.ThisOrder.ProductDescription;
        txtStaffID.Text = OrderBook.ThisOrder.StaffID.ToString();
        chkAvailability.Checked = OrderBook.ThisOrder.Availability;
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
        string StaffID = txtStaffID.Text;
        string Error = "";

        Error = AOrder.Valid(OrderID, CustomerNo, CustomerAddress, OrderDate, ItemPrice, ItemColour, ProductDescription, StaffID);

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
            AOrder.StaffID = Convert.ToInt32(StaffID);
            clsOrderCollection OrderList = new clsOrderCollection();
            if (this.OrderID== -1)
            {
                OrderList.ThisOrder = AOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(Convert.ToInt32(OrderID));
                OrderList.ThisOrder = AOrder;
                OrderList.Update();

            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display error message
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
            txtStaffID.Text = AOrder.StaffID.ToString();
            chkAvailability.Checked = AOrder.Availability;



        }


    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}