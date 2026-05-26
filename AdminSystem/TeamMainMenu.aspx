<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 211px; top: 39px; position: absolute" Text="Gradient Tech Main Menu"></asp:Label>
        <asp:Button ID="btnCustomers" runat="server" OnClick="btnCustomers_Click" style="z-index: 1; left: 46px; top: 87px; position: absolute; right: 1098px" TabIndex="1" Text="Customers" width="95px" />
        <asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click" style="z-index: 1; left: 198px; top: 87px; position: absolute" TabIndex="2" Text="Orders" width="95px" />
        <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="z-index: 1; left: 362px; top: 87px; position: absolute" TabIndex="3" Text="Staff" width="95px" />
        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 517px; top: 87px; position: absolute" TabIndex="4" Text="Stock" width="95px" />
    </form>
</body>
</html>
