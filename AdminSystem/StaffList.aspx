<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">

            <h2 class="mb-4">Staff List</h2>

            <div class="mb-3">
                <asp:ListBox ID="lstStaffList" runat="server" Height="227px" Width="406px" CssClass="form-control"></asp:ListBox>
            </div>

            <div class="mb-3">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="btn btn-primary" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" CssClass="btn btn-secondary" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="btn btn-danger" />
            </div>

            <div class="mb-3">
                <asp:Label ID="lblEnteraStaffName" runat="server" Text="Enter a Staff Name" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" CssClass="btn btn-primary" />
                <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" CssClass="btn btn-secondary" />
            </div>

            <div class="mb-3">
                <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>