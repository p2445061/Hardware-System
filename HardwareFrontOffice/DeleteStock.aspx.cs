using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
{
    Int32 PartNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        PartNo = Convert.ToInt32(Session["PartNo"]);
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection AddressBook = new clsStockCollection();
        AddressBook.ThisStock.Find(PartNo);
        AddressBook.Delete();
        Response.Redirect("StockList.aspx");
    }

}