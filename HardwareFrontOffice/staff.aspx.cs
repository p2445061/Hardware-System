using System;
using System.Collections.Generic;
//using System.Linq;
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
        string ID = txtID.Text;
        string Name = txtName.Text;
        string Address = txtAddress.Text;
        string DOB = txtDOB.Text;
        string Manager = "" + StaffManager.Checked;

        string Error = "";
        Error = staff.Valid(ID, Name, Address, DOB, Manager);
        if (Error == "")
        {
            staff.ID = Convert.ToInt32(txtID.Text);
            staff.Name = txtName.Text;
            staff.Address = txtAddress.Text;
            staff.DOB = Convert.ToDateTime(txtDOB.Text);
            staff.Manager = StaffManager.Checked;
            clsStaffCollecton StaffList = new clsStaffCollecton();
            StaffList.ThisStaff = staff;
            StaffList.Add();
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();
        int ID;
        Boolean Found = false;
        ID = Convert.ToInt32(txtID.Text);
        Found = staff.Find(ID);
        if (Found)
        {
            txtID.Text = "" + staff.ID;
            txtAddress.Text = staff.Address;
            txtDOB.Text = "" + staff.DOB;
            StaffManager.Checked = staff.Manager;
        }
    }
}
