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
            DisplayOrders();
    }

    void DisplayOrders()
    {
        clsOrderCollection AOrder = new clsOrderCollection();
        lstOrder.DataSource = AOrder.OrderList;
        lstOrder.DataValueField = "OrderID";
        lstOrder.DataTextField = "CustomerAddress";
        lstOrder.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edit
        Int32 OrderID;
        //if a record is found
        if (lstOrder.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderDataEntry.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrder.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.FilterByCustomerAddress(txtFilter.Text);
        lstOrder.DataSource = Orders.OrderList;
        lstOrder.DataValueField = "OrderID";
        lstOrder.DataTextField = "CustomerAddress";
        lstOrder.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.FilterByCustomerAddress("");
        txtFilter.Text = "";
        lstOrder.DataSource = Orders.OrderList;
        lstOrder.DataValueField = "OrderID";
        lstOrder.DataTextField = "CustomerAddress";
        lstOrder.DataBind();
    }
}