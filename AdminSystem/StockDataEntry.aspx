<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Stock Item</h2>

        <asp:Label ID="lblItemNo" runat="server" Text="Item No:"></asp:Label>
        <asp:TextBox ID="txtItemNo" runat="server" Enabled="false"></asp:TextBox><br /><br />

        <asp:Label ID="lblModelName" runat="server" Text="Model Name:"></asp:Label>
        <asp:TextBox ID="txtModelName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvModelName" ControlToValidate="txtModelName" 
            ErrorMessage="Model Name is required" Display="Dynamic" ForeColor="Red" runat="server" />
        <br /><br />

        <asp:Label ID="lblPrice" runat="server" Text="Price:"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPrice" ControlToValidate="txtPrice" 
            ErrorMessage="Price is required" Display="Dynamic" ForeColor="Red" runat="server" />
        <asp:RegularExpressionValidator ID="revPrice" ControlToValidate="txtPrice"
            ValidationExpression="^\d+(\.\d{1,2})?$" ErrorMessage="Invalid price (e.g., 9.99)" 
            Display="Dynamic" ForeColor="Red" runat="server" />
        <br /><br />

        <asp:Label ID="lblQuantity" runat="server" Text="Quantity:"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvQuantity" ControlToValidate="txtQuantity" 
            ErrorMessage="Quantity is required" Display="Dynamic" ForeColor="Red" runat="server" />
        <asp:RangeValidator ID="rvQuantity" ControlToValidate="txtQuantity" Type="Integer"
            MinimumValue="0" MaximumValue="999999" ErrorMessage="Quantity must be 0 or greater" 
            Display="Dynamic" ForeColor="Red" runat="server" />
        <br /><br />

        <asp:Label ID="lblInStock" runat="server" Text="In Stock:"></asp:Label>
        <asp:CheckBox ID="chkInStock" runat="server" />
        <br /><br />

        <asp:Label ID="lblLastRestocked" runat="server" Text="Last Restocked:"></asp:Label>
        <asp:TextBox ID="txtLastDateRestocked" runat="server" TextMode="Date"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDate" ControlToValidate="txtLastDateRestocked" 
            ErrorMessage="Date is required" Display="Dynamic" ForeColor="Red" runat="server" />
        <br /><br />

        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="false" />

        <br /><br />
        <asp:Label ID="lbError" runat="server" ForeColor="Red"></asp:Label>

        <asp:ValidationSummary ID="vsSummary" runat="server" ForeColor="Red" HeaderText="Please fix the following errors:" />
    </form>
</body>
</html>