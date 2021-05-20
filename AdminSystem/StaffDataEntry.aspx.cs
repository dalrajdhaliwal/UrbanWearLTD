using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private object anStaff;

    public object TaxCode { get; private set; }
    public object StaffId { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AnStaff.StaffFirstName);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        string StaffFirstName = txtStaffFirstName.Text;
        string NINumber = txtNINumber.Text;
        string StaffLastName = txtStaffLastName.Text;
        string ContactNumber = txtContactNumber.Text;
        string DateStarted = txtDateStarted.Text;
        string DateEnded = txtDateEnded.Text;
        string Salary = txtSalary.Text;
        string Taxcode = txtTaxcode.Text;
        string Error = "";

        Error = AnStaff.Valid(StaffLastName, StaffFirstName, NINumber, DateStarted, TaxCode, ContactNumber, DateEnded);
        if (Error == "") 
        {
            AnStaff.StaffId = StaffId;
            AnStaff.StaffFirstName = StaffFirstName;
            AnStaff.StaffLastName = StaffLastName;
            AnStaff.ContactNumber = ContactNumber;
            AnStaff.NINumber = NINumber;
            AnStaff.Salary = Salary;
            AnStaff.Taxcode = TaxCode;
            AnStaff.DateStarted = Convert.ToDateTime(DateStarted);
            AnStaff.DateEnded = Convert.ToDateTime(DateEnded);
            Session["AnStaff"] = AnStaff;
            Response.Write("StaffViewer.aspx");
            clsStaffCollection StaffList = new clsStaffCollection();

            if (StaffId == -1)
            
                {
                    StaffList.ThisStaff = anStaff;
                    StaffList.Add();
                }
            else
            {
                    StaffList.ThisStaff.Find(StaffId);
                    StaffList.ThisStaff = anStaff;
                    StaffList.Update();
                }

                Response.Redirect("StaffViewer.aspx");
            }
            else
        {
            lblError.Text = Error;
        }
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
        public string ContactNumber { get; internal set; }
        public string Salary { get; internal set; }
        public string DateStarted { get; internal set; }
        public string DateEnded { get; internal set; }
        public string NINumber { get; internal set; }
        public string TaxCode { get; internal set; }
        public object Taxcode { get; internal set; }
        public object StaffId { get; internal set; }

        internal bool Find(int staffId)
        {
            throw new NotImplementedException();
        }

        internal string Valid(string StaffLastName, string StaffFirstName, string NINumber, string DateStarted, object TaxCode, string ContactNumber, string DateEnded)
        {
            throw new NotImplementedException();
        }
    }
    public class txtStaffId
    {
        public static string Text { get; internal set; }
    }
    public class txtStaffFirstName
    {
        public static string Text { get; internal set; }
    }
    public class txtContactNumber
    {
        public static string Text { get; internal set; }
    }
    public class txtSalary
    {
        public static string Text { get; internal set; }
    }
    public class txtDateStarted
    {
        public static string Text { get; internal set; }
    }
    public class txtDateEnded
    {
        public static string Text { get; internal set; }
    }
    public class txtNINumber
    {
        public static string Text { get; internal set; }
    }
    public class txtTaxcode
    {
        public static string Text { get; internal set; }
    }
    }

public class clsStaffCollection
{
    internal object ThisStaff;

    internal void Add()
    {
        throw new NotImplementedException();
    }

    internal void Update()
    {
        throw new NotImplementedException();
    }
}