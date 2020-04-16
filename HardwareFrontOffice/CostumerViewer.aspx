<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CostumerViewer.aspx.cs" Inherits="CostumerViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="height: 257px">
            CostumerID 
            <asp:TextBox ID="txtCostumerID" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
            Name
            <asp:TextBox ID="txtName" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
            Address
            <asp:TextBox ID="txtCostumerAddress" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
            Date Of Birth
            <asp:TextBox ID="txtCostumerDOB" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
            Email
            <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="height: 26px" />
            </p>
    </form>
</body>
</html>
