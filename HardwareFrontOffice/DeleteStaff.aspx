<%@ Page Language="C#" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(ID);
        StaffList.Delete();
        Responce.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Responce.Redirect("StaffList.aspx");
    }
</script>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">  
        Are you sure you want to delete this record?<br />
        <br />
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
&nbsp;<asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
