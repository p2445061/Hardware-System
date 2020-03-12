<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stock.aspx.cs" Inherits="stock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PartNo
            <asp:TextBox ID="txtPartNo" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            SupplierId
            <asp:TextBox ID="txtSupplier" runat="server" OnTextChanged="btnOK_Click"></asp:TextBox>
            <br />
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
&nbsp;Available
            <asp:CheckBox ID="btnYes" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Yes" />
            <asp:CheckBox ID="btnNo" runat="server" OnCheckedChanged="btnNo_CheckedChanged" Text="No" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="height: 26px" />
            <br />
        </div>
    </form>
</body>
</html>
