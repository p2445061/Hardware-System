using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CostumerViewer : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        clsCostumer ACostumer = new clsCostumer();

        ACostumer = (clsCostumer)Session["ACostumer"];

        Response.Write(ACostumer.CostumerID);

    }

   
}