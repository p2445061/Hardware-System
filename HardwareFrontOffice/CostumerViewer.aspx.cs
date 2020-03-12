using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class CostumerViewer : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCostumer;
        clsCostumer ACostumer = new clsCostumer();
        //get the data from the session object
        ACostumer = (clsCostumer)Session["ACostumer"];
        //display the house number for this entry
        Response.Write(ACostumer.CostumerID);

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress();
        clsCostumer ACostumer = new clsCostumer();
        //capture the address
        ACostumer.AddressNo = txtAddress.txt;
        //capture the name
        ACostumer.Name = txtName.txt;
        //capture the email
        ACostumer.Email = txtEmail.txt;
        //capture active
        ACostumer.Active = txtActive.txt;
        //store the adress in the session object
        Session["ACostumer"] = ACostumer;
        //capture the date of birth
        ACostumer.DateOfBirth = txtDateOfBirth.txt;
        //capture the id
        ACostumer.CostumerID = txtCostumerID.txt;


        //redirect to the viwer page
        Response.Write("AddressViewer.aspx");
    }
}