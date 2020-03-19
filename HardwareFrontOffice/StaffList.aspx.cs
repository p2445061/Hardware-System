using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ID"] = -1;
        Response.Redirect("staff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int ID;
        if (lstStaffList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["ID"] = ID;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}