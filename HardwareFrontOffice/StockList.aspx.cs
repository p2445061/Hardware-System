using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }
    void DisplayStock()
    {
        HardwareClasses.clsStockCollection stock = new HardwareClasses.clsStockCollection();
        lstStockList.DataSource = stock.StockList;
        lstStockList.DataValueField = "PartNo";
        lstStockList.DataTextField = "PostCode";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PartNo"] = -1;
        Response.Redirect("stock.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 PartNo;
        
        if (lstStockList.SelectedIndex != -1)
        {
            PartNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["PartNo"] = PartNo;
            Response.Redirect("DeleteStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 PartNo;

        if (lstStockList.SelectedIndex != -1)
        {
            PartNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["PartNo"] = PartNo;
            Response.Redirect("stock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection stock = new clsStockCollection();
        stock.ReoprtByPartDescription(txtFilter.Text);
        lstStockList.DataSource = stock.StockList;
        lstStockList.DataValueField = "PartNo";
        lstStockList.DataTextField = "PartDescription";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection stock = new clsStockCollection();
        stock.ReoprtByPartDescription("");
        txtFilter.Text = "";
        lstStockList.DataSource = stock.StockList;
        lstStockList.DataValueField = "PartNo";
        lstStockList.DataTextField = "PartDescription";
        lstStockList.DataBind();
    }
}