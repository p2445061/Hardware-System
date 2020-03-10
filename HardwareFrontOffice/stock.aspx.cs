
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
        protected void Page_Load(object sender, EventArgs e)
        {
            clsStock stock = new clsStock();
            stock = (clsStock)Session["stock"];
            Response.Write(stock.PartNo);
           

    }
   

    protected void btnOK_Click(object sender, EventArgs e)
        {
            clsStock stock = new clsStock();
            stock.PartNo = Convert.ToInt32(this.txtPartNo.Text);
      
        stock.SupplierId = Convert.ToInt32(this.txtSupplier.Text);
        stock.PartDescription = txtPartDescription.Text;
        stock.Price = Convert.ToInt32(this.txtPrice.Text);
        stock.DateAdded = Convert.ToDateTime(txtDate.Text);
        stock.Quantity = Convert.ToInt32(this.txtQuantity.Text);


        Session["stock"] = stock;

            Response.Redirect("stock.aspx");
         }





    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnNo_CheckedChanged(object sender, EventArgs e)
    {

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
            txtSupplier.Text = stock.SupplierId.ToString();
            txtPrice.Text = stock.Price.ToString();
            txtDate.Text = stock.DateAdded.ToString();
            txtQuantity.Text = stock.Quantity.ToString();




        }
    }

   
}
