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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCostumer ACostumer = new clsCostumer();
        Int32 HouseNo;
        Boolean Found = false;
        HouseNo = Convert.ToInt32(txtHouseNo.Text);

        Found = ACostumer.Find(HouseNo);

        if(Found== true)
        {
            txtHouseNo.Text = ACostumer.HouseNo;
            txtStreet.Text = ACostumer.Street;
            txtTown.Text = ACostumer.Town;
            txtPostCode.Text = ACostumer.PostCode;
            txtCountry.Text = ACostumer.CountyNo.ToString();
            txtDateOfBirth.
            //txtName.Text = ACostumer.Name.ToString();
           // lblDateAdded.Text = ACostumer.DateAdded.ToString();
            //txtEmail.Text = ACostumer



        }


    }

    protected void txtName_TextChanged(object sender, EventArgs e)
    {

    }
}
