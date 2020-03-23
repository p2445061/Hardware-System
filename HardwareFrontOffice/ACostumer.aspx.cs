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
        CostumerID = Convert.ToInt32(Session["ID"]);
        if (IsPostBack == false)
        {
            if (CostumerID != -1)
            {
                
            }
        }
    }
    void DisplayCostumer ()
    {
        clsCostumer ACostumer= new clsCostumer();
        txtCostumerID.Text = ACostumer.CostumerID();
        txtName.Text = ACostumer.Name.ToString();
        txtCostumerAddress.Text = ACostumer.CostumerAddress.ToString();
        txtCostumerDOB.Text = ACostumer.CostumerDOB.ToString();
        txtEmail.Text = ACostumer.Email.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
       
        clsCostumer ACostumer = new clsCostumer();
       
        ACostumer.CostumerAddress = Convert.ToInt32(txtCostumerAddress.Text);
   
        ACostumer.Name = txtName.Text;
        
        ACostumer.Email = txtEmail.Text;
        
        ACostumer.Active = Active.Checked;
        
        Session["ACostumer"] = ACostumer;
        
        ACostumer.CostumerDOB = Convert.ToDateTime(txtCostumerDOB.Text);
        
        ACostumer.CostumerID = txtCostumerID.Text;


        //redirect to the viwer page
        //Response.Write("CostumerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCostumer ACostumer = new clsCostumer();
        Int32 CostumerID;
        Boolean Found = false;
        CostumerID = Convert.ToInt32(txtCostumerID.Text);

        Found = ACostumer.Find(CostumerID);

        if(Found== true)
        {
           
            Active.Checked = ACostumer.Active;
            txtCostumerDOB.Text = "" + ACostumer.DateOfBirth;
            txtEmail.Text = ACostumer.Email.ToString();
            txtCostumerAddress.Text = ACostumer.ToString();
            txtName.Text = ACostumer.ToString();
            txtCostumerID = ACostumer.ToString();
            



        }


    }

    

    
}
