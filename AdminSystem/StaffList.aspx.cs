using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaffs();
        }
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaffs();
        }
    }

    void DisplayStaffs()
    {
        ClassLibrary.clsStaffCollection Staffs = new ClassLibrary.clsStaffCollection();
        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffFirstName1";

        lstStaffList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("AnStaffDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;

        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedIndex);
            Session["StaffId"] = StaffId;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffId.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";

        }


    }
    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByName(txtFilter.Text);
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffFirstName";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByName("");
        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffFirstName";
        lstStaffList.DataBind();
    }
}

public class txtFilter
{
    public static object Text { get; internal set; }
}

public class lstStaffList
{
    public static List<clsStaff> DataSource { get; internal set; }
    public static string DataValueField { get; internal set; }
    public static string DataTextField { get; internal set; }
    public static int SelectedIndex { get; internal set; }
    public static object SelectedValue { get; internal set; }

    internal static void DataBind()
    {
        throw new NotImplementedException();
    }
}