<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="StockConfirmDelete" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml%22%3E
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this Stock?</div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click1" />
    </form>
</body>
</html>