using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;


    public partial class staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        clsStaff staff = new clsStaff();
        staff = (clsStaff)Session["staff"];
        Response.Write(staff.Name);
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
        clsStaff staff = new clsStaff();
        staff.Name = txtName.Text;
        staff.Address = txtAddress.Text;
        staff.DOB = Convert.ToDateTime(txtDOB.Text);
        staff.Manager = StaffManager.Bit;
        Session["staff"] = staff;
        Response.Redirect("StaffViewer.aspx");
        }

    }
