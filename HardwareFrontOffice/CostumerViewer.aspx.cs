using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;



    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCostumer;
        clsCostumer ACostumer = new clsCostumer();
        //get the data from the session object
        ACostumer = (clsCostumer)Session["ACostumer"];
        //display the house number for this entry
        Response.Write(ACostumer.HouseNo);

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress();
        //capture the house no
        ACostumer.HouseNo = txtHouseNo.Text;
        //capture the street 
        ACostumer.Street = txtStreet.Text;
        //capture the town
        ACostumer.Town = txtTown.Text;
        //capture the post code
        ACostumer.PostCode = txtPostCode.Text;
        //capture the country
        ACostumer.Country = txtCountry.txt;
        //capture date added
        ACostumer.DateAdded = Convert.ToDateTime(testDateAdded.Text);
         //capture the name
       ACostumer.Name = txtName.txt;
      //capture the email
      ACostumer.Email = txtEmail.txt;
       //store the adress in the session object
         Session["ACostumer"] = ACostumer;
        //capture the date of birth
        ACostumer.DateOfBirth = txtDateOfBirth.txt;
   

        //redirect to the viwer page
        Response.Write("AddressViewer.aspx");
    }
