using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses

namespace HardwareFrontOffice
{
    public partial class AnOrderLine : System.Web.UI.Page
    {
        private clsOrderLine anOrderLine;
        private object txtPartNo;

        internal clsOrderLine GetAnOrderLine()
        {
            return anOrderLine;
        }

        private void SetAnOrderLine(clsOrderLine value)
        {
            anOrderLine = value;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of clsOrderLine
            clsOrderLine AnOrdrLine = new clsOrderLine();
            //get the data from te session object
            SetAnOrderLine((clsOrderLine)Session["AnOrderLine"]);
            //display the house number for this entry
            Response.Write(GetAnOrderLine().PartNo);
            Response.Write(GetAnOrderLine().OrderID);
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsOrderLine
            clsOrderLine AnOrderLine = new clsOrderLine();
            //capture the Part no
            AnOrderLine.PartNo = txtPartNo.Text;
            //store the address in the session object
            Session["AnOrderLine"] = AnOrderLine;
            //redirect to the viewer page
            Response.Redirect("AddressViewer.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}