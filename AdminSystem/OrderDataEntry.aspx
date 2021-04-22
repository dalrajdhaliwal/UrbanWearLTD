<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 539px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="121px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="margin-left: 15px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        <br />
        <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number" width="121px"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductDescription" runat="server" Text="Product Description"></asp:Label>
        <asp:TextBox ID="txtProductDescription" runat="server" style="margin-left: 8px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address" width="121px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="margin-left: 15px" ></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="121px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="margin-left: 15px" ></asp:TextBox>
        <br />
        <asp:Label ID="lblItemPrice" runat="server" Text="Item Price" width="121px"></asp:Label>
        <asp:TextBox ID="txtItemPrice" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:Label ID="lblItemColour" runat="server" Text="Item Colour" width="121px"></asp:Label>
        <asp:TextBox ID="txtItemColour" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click"/>&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
