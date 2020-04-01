using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class DeleteCostumer : System.Web.UI.Page
{

    Int32 CostumerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        CostumerID = Convert.ToInt32(Session["CostumerID"]);
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCostumerCollection CostumerList = new clsCostumerCollection();
        CostumerList.ThisCostumer.Find(CostumerID);
        CostumerList.Delete();
        Response.Redirect("CostumerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CostumerList.aspx");
    }
}