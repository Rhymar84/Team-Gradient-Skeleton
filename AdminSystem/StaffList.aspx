<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>Staff List</h2>
            <asp:ListBox ID="lstStaffList" runat="server" Height="227px" Width="406px"></asp:ListBox>
            <br /><br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            &nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            &nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br /><br />
            <asp:Label ID="lblEnteraStaffName" runat="server" Text="Enter a Staff Name"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtFilter" runat="server" Height="22px" Width="128px"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" Width="79px" />
            &nbsp;
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" Width="82px" />
            <br /><br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>