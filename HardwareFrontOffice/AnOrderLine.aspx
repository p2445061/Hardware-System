<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnOrderLine.aspx.cs" Inherits="HardwareFrontOffice.AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PartNo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="PartNo" runat="server" Height="19px" Width="119px"></asp:TextBox>
            <br />
            OrderID&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="OrderID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
