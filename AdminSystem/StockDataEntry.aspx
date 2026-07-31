<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Stock Item</h2>

        <asp:Label ID="lblItemNo" runat="server" style="position: absolute; left: 10px; top: 72px;" Text="Item No:"></asp:Label>
        <asp:TextBox ID="txtItemNo" runat="server" style="position: absolute; left: 110px; top: 70px; width: 150px;" Enabled="false"></asp:TextBox>

        <asp:Label ID="lblModelName" runat="server" style="position: absolute; left: 10px; top: 120px;" Text="Model Name:"></asp:Label>
        <asp:TextBox ID="txtModelName" runat="server" style="position: absolute; left: 110px; top: 118px; width: 150px;"></asp:TextBox>

        <asp:Label ID="lblPrice" runat="server" style="position: absolute; left: 10px; top: 168px;" Text="Price:"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="position: absolute; left: 110px; top: 166px; width: 150px;"></asp:TextBox>

        <asp:Label ID="lblQuantity" runat="server" style="position: absolute; left: 10px; top: 216px;" Text="Quantity:"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="position: absolute; left: 110px; top: 214px; width: 150px;"></asp:TextBox>

        <asp:Label ID="lblInStock" runat="server" style="position: absolute; left: 10px; top: 264px;" Text="In Stock:"></asp:Label>
        <asp:CheckBox ID="chkInStock" runat="server" style="position: absolute; left: 110px; top: 264px;" />

        <asp:Label ID="lblLastRestocked" runat="server" style="position: absolute; left: 10px; top: 312px;" Text="Last Restocked:"></asp:Label>
        <asp:TextBox ID="txtLastDateRestocked" runat="server" TextMode="Date" style="position: absolute; left: 110px; top: 310px; width: 150px;"></asp:TextBox>

        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" style="position: absolute; left: 27px; top: 370px; width: 43px;" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" style="position: absolute; left: 102px; top: 370px; width: 75px;" />

        <asp:Label ID="lbError" runat="server" style="position: absolute; left: 10px; top: 420px; color: red;"></asp:Label>
    </form>
</body>
</html>