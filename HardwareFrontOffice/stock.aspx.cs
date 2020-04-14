
using System;
using HardwareClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class stock : System.Web.UI.Page
{
    Int32 PartNo;


    protected void Page_Load(object sender, EventArgs e)
    {
        PartNo = Convert.ToInt32(Session["PartNo"]);
        if (IsPostBack == false)
        {
            DisplayStock();

            if (PartNo != -1)
            {
                DisplayParts();
            }
        }



    }



    private void DisplayStock()
    {
        clsStockCollection AddressBook = new clsStockCollection();
        AddressBook.ThisStock.Find(PartNo);

        txtPartNo.Text = AddressBook.ThisStock.PartNo.ToString();
        txtPartDescription.Text = AddressBook.ThisStock.PartDescription;
        txtQuantity.Text = AddressBook.ThisStock.Quantity.ToString();
        txtPrice.Text = AddressBook.ThisStock.Price.ToString();
        txtDate.Text = AddressBook.ThisStock.DateAdded.ToString();
        ChkAvailable.Checked = AddressBook.ThisStock.Available;

    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (PartNo == -1)
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

    private void Add()
    {
        clsStockCollection AddressBook = new clsStockCollection();
        //validate the data on the web form
        String Error = AddressBook.ThisStock.Valid(txtPartDescription.Text, txtPrice.Text, txtQuantity.Text, txtDate.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            AddressBook.ThisStock.PartDescription = txtPartDescription.Text;
            AddressBook.ThisStock.Price = Convert.ToInt32(txtPrice.Text);
            AddressBook.ThisStock.Quantity = Convert.ToInt32(txtQuantity.Text);
            AddressBook.ThisStock.DateAdded = Convert.ToDateTime(txtDate.Text);
            AddressBook.ThisStock.Available = ChkAvailable.Checked;

            //add the record
            AddressBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("DefaultStock.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    private void Update()
    {
        HardwareClasses.clsStockCollection AddressBook = new HardwareClasses.clsStockCollection();
        String Error = AddressBook.ThisStock.Valid(txtPrice.Text, txtPartDescription.Text, txtQuantity.Text, txtDate.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            AddressBook.ThisStock.Find(PartNo);
            //get the data entered by the user
            AddressBook.ThisStock.PartDescription = txtPartDescription.Text;
            AddressBook.ThisStock.Price = Convert.ToInt32(txtPrice.Text);
            AddressBook.ThisStock.Quantity = Convert.ToInt32(txtQuantity.Text);

            AddressBook.ThisStock.DateAdded = Convert.ToDateTime(txtDate.Text);
            AddressBook.ThisStock.Available = ChkAvailable.Checked;

            //update the record
            AddressBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("DefaultStock.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    private void DisplayParts()
    {
        clsStockCollection AddressBook = new clsStockCollection();
        //find the record to update
        AddressBook.ThisStock.Find(PartNo);
        //display the data for this record
        txtPartDescription.Text = AddressBook.ThisStock.PartDescription;
        AddressBook.ThisStock.Price = Convert.ToInt32(txtPrice.Text);
        txtDate.Text = AddressBook.ThisStock.DateAdded.ToString();
        AddressBook.ThisStock.Quantity = Convert.ToInt32(txtQuantity.Text);
        ChkAvailable.Checked = AddressBook.ThisStock.Available;
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();

        Int32 PartNo;

        Boolean Found = false;

        PartNo = Convert.ToInt32(txtPartNo.Text);

        if (Found == true)
        {
            txtPartDescription.Text = stock.PartDescription;
            txtPrice.Text = stock.Price.ToString();
            txtDate.Text = stock.DateAdded.ToString();
            txtQuantity.Text = stock.Quantity.ToString();

        }
    }

    
}
   
   
    






   


