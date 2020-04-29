using System;
using HardwareClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


public partial class ACostumer : System.Web.UI.Page
{
    Int32 CostumerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        CostumerID = Convert.ToInt32(Session["CostumerID"]);
        if (IsPostBack == false)
        {
            DisplayCostumer();

            if (CostumerID != -1)
            {
                DisplayCostumer();
            }
        }
    }
    void DisplayCostumer()
    {
        Class_Library.clsCostumerCollection Costumers = new Class_Library.clsCostumerCollection();
        txtCostumerID.Text = ACostumer.CostumerID.ToString();
        txtName.Text = ACostumer.Name.ToString();
        txtCostumerAddress.Text = ACostumer.CostumerAddress.ToString();
        txtCostumerDOB.Text = ACostumer.CostumerDOB.ToString();
        txtEmail.Text = ACostumer.Email.ToString();
    }


    //this is the event handler for the cancel button
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");
    }
 
    protected void BtnOK_Click(object sender, EventArgs e)
    {
        if (CostumerID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the address book
        clsCostumerCollection AddressBook = new clsCostumerCollection();
        //validate the data on the web form
        String Error = AddressBook.ThisAddress.Valid(txtCostumerID Text, txtName Text, txtCostumerAddress Text, txtCostumerDOB Text, txtEmail Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            clsCostumerCollection AddressBook = new clsCostumerCollection();
            txtCostumerID.Text = ACostumer.CostumerID.ToString();
            txtName.Text = ACostumer.Name.ToString();
            txtCostumerAddress.Text = ACostumer.CostumerAddress.ToString();
            txtCostumerDOB.Text = ACostumer.CostumerDOB.ToString();
            txtEmail.Text = ACostumer.Email.ToString();

            //add the record
            AddressBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("CostumerList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayCostumer()
    {
        //create an instance of the address book
        clsCostumerCollection AddressBook = new clsCostumerCollection();
        //find the record to update
        AddressBook.ThisCostumer.Find(CostumerID);
        //display the data for this record
        clsCostumerCollection AddressBook = new clsCostumerCollection();
        txtCostumerID.Text = ACostumer.CostumerID.ToString();
        txtName.Text = ACostumer.Name.ToString();
        txtCostumerAddress.Text = ACostumer.CostumerAddress.ToString();
        txtCostumerDOB.Text = ACostumer.CostumerDOB.ToString();
        txtEmail.Text = ACostumer.Email.ToString();

    }
    protected void btnCan_Click(object sender, EventArgs e)
    {
        Response.Redirect("CostumerList.aspx");
    }
}
