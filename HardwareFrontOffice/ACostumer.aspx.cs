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
        Response.Write(ACostumer.CostumerID);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress();
        clsCostumer ACostumer = new clsCostumer();
        //capture the address
        ACostumer.AddressNo = Convert.ToInt32(txtAddress.Text);
        //capture the name
        ACostumer.Name = txtName.Text;
        //capture the email
        ACostumer.Email = txtEmail.Text;
        //capture active
        ACostumer.Active = Active.Checked;
        //store the adress in the session object
        Session["ACostumer"] = ACostumer;
        //capture the date of birth
        ACostumer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        //capture the id
        ACostumer.CostumerID = txtCostumerId.Text;


        //redirect to the viwer page
        Response.Write("AddressViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCostumer ACostumer = new clsCostumer();
        Int32 CostumerID;
        Boolean Found = false;
        CostumerID = Convert.ToInt32(txtCostumerId.Text);

        Found = ACostumer.Find(CostumerID);

        if(Found== true)
        {
           
            Active.Checked = ACostumer.Active;
            txtDateOfBirth.Text = "" + ACostumer.DateOfBirth;
            txtEmail.Text = ACostumer.Email.ToString();
            txtAddress.Text = ACostumer.ToString();
            txtName.Text = ACostumer.ToString();
            



        }


    }

    

    
}
