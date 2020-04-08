<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACostumer.aspx.cs" Inherits="ACostumer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 317px">
    <form id="form1" runat="server">
        CostumerID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCostumerID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Height="27px" OnClick="btnFind_Click" Text="Find" Width="60px" />
        <br />
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtName" runat="server" style="height: 22px"></asp:TextBox>
        <br />
        Date Of Birth&nbsp; &nbsp;
        <asp:TextBox ID="txtCostumerDOB" runat="server"></asp:TextBox>
        <br />
        Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCostumerAddress" runat="server"></asp:TextBox>
        <br />
        Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="Active" runat="server" />
        <br />
        <br />
    </form>
</body>
</html>
