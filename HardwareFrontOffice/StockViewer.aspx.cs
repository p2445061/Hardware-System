using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();

        stock = (clsStock)Session["stock"];
        Response.Write(stock.PartNo);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();

        stock.PartNo = txtPartNo.Text;
        stock.SupplierId = Convert.ToInt32(this.txtSupplier.Text);
        stock.PartDescription = txtPartDescription.Text;
        stock.Price = Convert.ToInt32(this.txtPrice.Text);
        stock.DateAdded = Convert.ToDateTime(txtDate.Text);
        stock.Quantity = Convert.ToInt32(this.txtQuantity.Text);



    }
}