<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            height: 166px;
            width: 276px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">   
        Unbound<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Height="26px" OnClick="btnAdd_Click_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <p>
            Enter a post code <asp:TextBox ID="txt" runat="server" Width="134px"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnApply" runat="server" Text="Apply" Height="26px" OnClick="Button1_Click" />
        &nbsp;
        <asp:Button ID="btnClear" runat="server" Text="Clear" Height="26px" OnClick="Button1_Click" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
