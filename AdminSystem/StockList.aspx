<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Stock List</h2>

        <asp:Label ID="lbError" runat="server" ForeColor="Red"></asp:Label>

        <asp:GridView ID="gvStock" runat="server" AutoGenerateColumns="False" 
            OnRowCommand="gvStock_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
            <Columns>
                <asp:BoundField DataField="ItemNo" HeaderText="Item No" />
                <asp:BoundField DataField="ModelName" HeaderText="Model Name" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:CheckBoxField DataField="InStock" HeaderText="In Stock" />
                <asp:BoundField DataField="LastDateRestocked" HeaderText="Last Restocked" DataFormatString="{0:d}" />
                <asp:ButtonField Text="View" CommandName="View" ButtonType="Button" />
                <asp:ButtonField Text="Edit" CommandName="Edit" ButtonType="Button" />
            </Columns>
        </asp:GridView>

        <br />
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Stock" OnClick="btnAddNew_Click" />
    </form>
</body>
</html>