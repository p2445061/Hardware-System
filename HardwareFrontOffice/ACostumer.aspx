<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACostumer.aspx.cs" Inherits="ACostumer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        House No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtHouseNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Height="27px" OnClick="Button2_Click" Text="Find" Width="60px" />
        <br />
        Street&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
        <br />
        Town&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
        <br />
        Post Code&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
        <br />
        Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
        <br />
        Date Added&nbsp;&nbsp;&nbsp; <asp:TextBox ID="lblDateAdded" runat="server" EnableTheming="False"></asp:TextBox>
        <br />
        Date Of Birth&nbsp;
        <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        <br />
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged"></asp:TextBox>
        <br />
        Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        Active&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtActive" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
    </form>
</body>
</html>
