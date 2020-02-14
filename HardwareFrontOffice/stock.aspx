<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stock.aspx.cs" Inherits="HardwareFrontOffice.stock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PartNo
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="50"></asp:TextBox>
            <br />
            SupplierId <br />
            Part Description
            <br />
            Price
            <br />
            Date Added
            <br />
            Quantity
            <br />
&nbsp;
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
            <br />
        </div>
    </form>
</body>
</html>
