using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff anStaff = new clsStaff();
        anStaff = (clsStaff)Session["anStaff"];
        Response.Write(anStaff.StaffId);
        Response.Write("<br>");
        Response.Write(anStaff.StaffFirstName);
        Response.Write(anStaff.StaffLastName);
        Response.Write(anStaff.ContactNumber);
        Response.Write(anStaff.Salary);
        Response.Write(anStaff.DateStarted);
        Response.Write(anStaff.DateEnded);
        Response.Write(anStaff.TaxCode);
        Response.Write(anStaff.Shift);
    }
}