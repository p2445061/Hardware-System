using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class ACostumer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCostumer
        clsCostumer ACostumer = new clsCostumer();
        //get the data from the session object
        ACostumer = (clsCostumer)Session["ACostumer"];
        //display the house number for this entry
        Response.Write(ACostumer.HouseNo);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //created a new instance of clsCostumer
        clsCostumer ACostumer = new clsCostumer();
        //capture the house no
        ACostumer.HouseNo = txtHouseNo.Text;
        //store the address in the session object
        Session["ACostumer"] = ACostumer;
        //redirect to the viewer page
        Response.Write("CostumerViewer.aspx");
    }
}
