<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="355px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="421px"></asp:ListBox>
        </div>
        <p style="width: 33px">
            <asp:Button ID="btnAdd" runat="server" Height="26px" OnClick="btnAdd_Click" Text="Add" Width="66px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click1" style="z-index: 1; left: 104px; top: 389px; position: absolute; width: 66px; height: 26px" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 202px; top: 389px; position: absolute" Text="Delete" width="66px" />
        </p>
        <p style="width: 115px">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnClearFilter" runat="server" height="26px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 198px; top: 506px; position: absolute" Text="Clear Filter" width="77px" />
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 470px; position: absolute" Text="Enter a Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 111px; top: 468px; position: absolute; height: 21px; width: 184px"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 84px; top: 506px; position: absolute; width: 77px" Text="Apply Filter" />
    </form>
</body>
</html>
