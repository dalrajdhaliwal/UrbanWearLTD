<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductId" runat="server" Text="Product ID"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductId" runat="server" BorderColor="#0066FF"></asp:TextBox>
        
    &nbsp;<asp:Button ID="btnFind" runat="server" BackColor="#00CCFF" OnClick="btnFind_Click" Text="Find" />
        <br />
        <br />
        <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductName" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblProductDescription" runat="server" Text="Product Description"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductDescription" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrice" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblInStock" runat="server" Text="In Stock"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtInStock" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblLastRestockDate" runat="server" Text="Last Restock Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtLastRestockDate" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStockVariants" runat="server" Text="StockVariants"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStockVariants" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOK" runat="server" BackColor="#7BFF7B" Text="OK" OnClick="btnOK_Click" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" BackColor="#FF5B5B" Text="Cancel" OnClick="btnCancel_Click" />
        
    </form>
</body>
</html>