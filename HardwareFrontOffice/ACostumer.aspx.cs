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
    int CostumerID;



    protected void Page_Load(object sender, EventArgs e)
    {
        CostumerID = Convert.ToInt32(Session["CostumerID"]);
        if (IsPostBack == false)
        {
            if (CostumerID != -1)
            {
                //
            }
        }
    }
    void DisplayCostumer()
    {
        clsCostumer ACostumer = new clsCostumer();
        txtCostumerID.Text = ACostumer.CostumerID.ToString();
        txtName.Text = ACostumer.Name.ToString();
        txtCostumerAddress.Text = ACostumer.CostumerAddress.ToString();
        txtCostumerDOB.Text = ACostumer.CostumerDOB.ToString();
        txtEmail.Text = ACostumer.Email.ToString();
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsCostumer ACostumer = new clsCostumer();
        string CostumerID = txtCostumerID.Text;
        string Name = txtName.Text;
        string CostumerAddress = txtCostumerAddress.Text;
        string CostumerDOB = txtCostumerDOB.Text;
        string Email = txtEmail.Text;

        string Error = "";
        Error = ACostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email);
        if (Error == "")
        {

            ACostumer.CostumerID = Convert.ToInt32(ID);
            ACostumer.Name = Name;
            ACostumer.CostumerAddress = CostumerAddress;
            ACostumer.CostumerDOB = Convert.ToDateTime(CostumerDOB);
            ACostumer.Email = Email;

            clsCostumerCollection CostumerList = new clsCostumerCollection();

            if (Convert.ToInt32(CostumerID) == -1)
            {
                CostumerList.ThisCostumer = ACostumer;
                CostumerList.Add();
            }
            else
            {
                CostumerList.ThisCostumer.Find(Convert.ToInt32(CostumerID));
                CostumerList.ThisCostumer = ACostumer;
                CostumerList.Update();
            }
            Response.Redirect("CostumerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCostumer ACostumer = new clsCostumer();
        Int32 CostumerID;
        Boolean Found = false;
        CostumerID = Convert.ToInt32(txtCostumerID.Text);

        Found = ACostumer.Find(CostumerID);

        if (Found == true)
        {

            Active.Checked = ACostumer.Active;
            txtCostumerDOB.Text = "" + ACostumer.CostumerDOB;
            txtEmail.Text = ACostumer.Email.ToString();
            txtCostumerAddress.Text = ACostumer.ToString();
            txtName.Text = ACostumer.ToString();
            txtCostumerID.Text = ACostumer.ToString();

        }

    }

    protected void btnCan_Click(object sender, EventArgs e)
    {
        Response.Redirect("CostumerList.aspx");
    }
}
