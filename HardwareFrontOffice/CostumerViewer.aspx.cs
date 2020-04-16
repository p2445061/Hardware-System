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

    protected void btnOK_Click(object sender, EventArgs e)
    {
       clsCostumer ACostumer = new clsCostumer();


        ACostumer.Name = txtName.Text;
        ACostumer.CostumerID = Convert.ToInt32(this.txtCostumerID.Text);
        ACostumer.CostumerAddress = txtCostumerAddress.Text;
        ACostumer.Email = txtEmail.Text;
        ACostumer.Name = txtName.Text;

    }
}