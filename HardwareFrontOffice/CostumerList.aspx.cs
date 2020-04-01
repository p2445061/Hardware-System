using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;


public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayCostumer()
    {
        clsCostumerCollection ACostumer = new clsCostumerCollection();

        lstCostumerList.DataSource = Costumer.CostumerList;

        lstCostumerList.DataValueField = "CostumerID";

        lstCostumerList = "Name";

        lstCostumerList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CostumerID"] = -1;
        Response.Redirect("Costumer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int CostumerID;
        if (lstCostumerList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstCostumerList.SelectedValue);
            Session["CostumerID"] = CostumerID;
            Response.Redirect("DeleteCostumer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int CostumerID;
        if (lstCostumerList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstCostumerList.SelectedValue);
            Session["CostumerID"] = CostumerID;
            Response.Redirect("Costumer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCostumerCollection CostumerList = new clsCostumerCollection();
        CostumerList.ReportByName(txtfilter.Text);
        lstCostumerList.DataSource = StaffList.StaffList;
        lstCostumerList.DataValueField = "CostumerID";
        lstCostumerList.DataValueField = "Name";
        lstCostumerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCostumerCollection CostumerList = new clsCostumerCollection();
        CostumerList.ReportByName("");
        txtfilter.Text = "";
        lstCostumerList.DataSource = CostumerList.CostumerList;
        lstCostumerList.DataValueField = "CostumerID";
        lstCostumerList.DataValueField = "Name";
        lstCostumerList.DataBind();
    }
}