using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayStaff();
            }
        }

        void DisplayStaff()
        {
            HardwareClasses.clsStaffCollection Staff = new HardwareClasses.clsStaffCollection();
            lstStaff.DataSource = Staff.StaffList;
            lstStaff.DataValueField = "";
            lstStaff.DataValueField = "";
            lstStaff.DataBind();
        }
    }
