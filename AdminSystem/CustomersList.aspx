<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">

            <h2 class="mb-4">Customer List</h2>

            <div class="mb-3">
                <asp:Button ID="btnMainMenu" runat="server" Text="← Main Menu"
                    OnClick="btnMainMenu_Click" CssClass="btn btn-outline-secondary btn-sm" />
            </div>

            <div class="mb-3">
                <asp:ListBox ID="lstCustomerList" runat="server" Height="250px" Width="100%"
                    OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" CssClass="form-select" />
            </div>

            <div class="mb-3">
                <asp:Button ID="btnAdd"    runat="server" OnClick="btnAdd_Click"    Text="Add"    CssClass="btn btn-success me-2" />
                <asp:Button ID="btnEdit"   runat="server" OnClick="btnEdit_Click1"  Text="Edit"   CssClass="btn btn-warning me-2" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="btn btn-danger" />
            </div>

            <hr />
            <div class="row mb-3 align-items-center">
                <div class="col-3">
                    <asp:Label ID="Label1" runat="server" Text="Filter by Name" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control" />
                </div>
                <div class="col-auto">
                    <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" CssClass="btn btn-primary me-2" />
                    <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter"  CssClass="btn btn-secondary" />
                </div>
            </div>

            <div class="row">
                <div class="col">
                    <asp:Label ID="lblError" runat="server" CssClass="text-danger" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>
</html>
