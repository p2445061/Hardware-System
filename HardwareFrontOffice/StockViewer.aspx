<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="StockViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Part Description 
            <asp:TextBox ID="txtPartDescription" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
            Price
            <asp:TextBox ID="txtPrice" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
            Date Added
            <asp:TextBox ID="txtDate" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
            Quantity
            <asp:TextBox ID="txtQuantity" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
&nbsp;
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="height: 26px" />
        </div>
    </form>
</body>
</html>
