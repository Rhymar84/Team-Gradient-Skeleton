<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Stock Item Details</h2>

        <asp:Label ID="lblItemNo" runat="server" Text="Item No: " Font-Bold="true"></asp:Label>
        <asp:Label ID="lblItemNoValue" runat="server"></asp:Label><br />

        <asp:Label ID="lblModelName" runat="server" Text="Model Name: " Font-Bold="true"></asp:Label>
        <asp:Label ID="lblModelNameValue" runat="server"></asp:Label><br />

        <asp:Label ID="lblPrice" runat="server" Text="Price: " Font-Bold="true"></asp:Label>
        <asp:Label ID="lblPriceValue" runat="server"></asp:Label><br />

        <asp:Label ID="lblQuantity" runat="server" Text="Quantity: " Font-Bold="true"></asp:Label>
        <asp:Label ID="lblQuantityValue" runat="server"></asp:Label><br />

        <asp:Label ID="lblInStock" runat="server" Text="In Stock: " Font-Bold="true"></asp:Label>
        <asp:Label ID="lblInStockValue" runat="server"></asp:Label><br />

        <asp:Label ID="lblLastRestocked" runat="server" Text="Last Restocked: " Font-Bold="true"></asp:Label>
        <asp:Label ID="lblLastRestockedValue" runat="server"></asp:Label><br />

        <br />
        <asp:Button ID="btnBack" runat="server" Text="Back to List" OnClick="btnBack_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />

        <br /><br />
        <asp:Label ID="lbError" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>