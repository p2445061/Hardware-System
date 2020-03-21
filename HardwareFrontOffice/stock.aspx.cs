
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
            if (PartNo != -1)
            {
                DisplayStock();
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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();

        string PartDescription = txtPartDescription.Text;
        string Price = txtPrice.Text;
        string DateAdded = txtDate.Text;
        string Quantity = txtQuantity.Text;
        string Error = "";
        Error = stock.Valid(Quantity, PartDescription, Price, DateAdded);
        if (Error == "")
        {

            stock.PartDescription = txtPartDescription.Text;
            stock.Price = Convert.ToInt32(this.txtPrice.Text);
            stock.DateAdded = Convert.ToDateTime(txtDate.Text);
            stock.Quantity = Convert.ToInt32(this.txtQuantity.Text);
            stock.Available = ChkAvailable.Checked;

            clsStockCollection StockList = new clsStockCollection();

            if (PartNo == -1)
            {
                StockList.ThisStock = stock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(PartNo);
                StockList.ThisStock = stock;
                StockList.Update();
            }

            Response.Redirect("StockList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }


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
