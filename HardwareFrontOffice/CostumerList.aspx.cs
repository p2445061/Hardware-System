using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;


public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayCostumer()
    {
        Class_Library.clsCostumerCollection ACostumer = new Class_Library.clsCostumerCollection();

        lstCostumers.DataSource = Coostumers.CostumerList;

        lstCostumesr.DataTextField = "CostumerNo";

        lstCostumers.DataBind();
    }

 
}


