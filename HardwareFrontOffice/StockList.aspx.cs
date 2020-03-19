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
}