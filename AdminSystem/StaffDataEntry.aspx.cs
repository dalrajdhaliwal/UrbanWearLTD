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
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AnStaff.StaffFirstName);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsStaff AnStaff = new clsStaff();

        Response.Redirect("StaffViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        {
            clsStaff AnStaff = new clsStaff();
            Int32 StaffId;
            Boolean Found = false;
            StaffId = Convert.ToInt32(txtStaffId.Text);
            Found = AnStaff.Find(StaffId);
            if (Found == true)
            {
                txtStaffFirstName.Text = AnStaff.StaffFirstName;
                txtStaffLastName.Text = AnStaff.StaffLastName;
                txtContactNumber.Text = AnStaff.ContactNumber;
                txtSalary.Text = AnStaff.Salary.ToString();
                txtDateStarted.Text = AnStaff.DateStarted.ToString();
                txtDateEnded.Text = AnStaff.DateEnded.ToString();
                txtNINumber.Text = AnStaff.NINumber.ToString();
                txtTaxcode.Text = AnStaff.Taxcode.ToString();

            }

        }
    }
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public string StaffFirstName { get; internal set; }
        public string StaffLastName { get; internal set; }
        public object ContactNumber { get; internal set; }
        public object Salary { get; internal set; }
        public object DateStarted { get; internal set; }
        public object DateEnded { get; internal set; }
        public object NINumber { get; internal set; }
        public object Taxcode { get; internal set; }

        internal bool Find(int staffId)
        {
            throw new NotImplementedException();
        }
    }
    public class txtStaffId
    {
        public static object Text { get; internal set; }
    }
    public class txtStaffFirstName
    {
        public static string Text { get; internal set; }
    }
    public class txtContactNumber
    {
        public static object Text { get; internal set; }
    }
    public class txtSalary
    {
        public static object Text { get; internal set; }
    }
    public class txtDateStarted
    {
        public static object Text { get; internal set; }
    }
    public class txtDateEnded
    {
        public static object Text { get; internal set; }
    }
    public class txtNINumber
    {
        public static object Text { get; internal set; }
    }
    public class txtTaxcode
    {
        public static object Text { get; internal set; }
    }
}