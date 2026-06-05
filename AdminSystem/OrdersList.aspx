<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders List</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h2 class="mb-4">Customer List</h2>

            <div class="row mb-3">
                <div class="col-auto">
                    <asp:ListBox ID="lstOrderList" runat="server" Height="250px" Width="100%"></asp:ListBox>
                </div>
                <div class="col-auto">
                    <asp:Label ID="lblLogin" runat="server" CssClass="col-form-label"></asp:Label>
                </div>
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>

            <div class="row mb-3">
                <div class="col-auto">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" CssClass="btn btn-success" Text="Add" TabIndex="2" />
                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" CssClass="btn btn-warning" Text="Edit" TabIndex="3" />
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" CssClass="btn btn-danger" TabIndex="3" Text="Delete" />
                </div>
            </div>

            <div class="row mb-3">
                <div class="col-auto">
                    <asp:Label ID="lblFilter" runat="server" CssClass="col-form-label fw-semibold" Text="Enter an Address:"></asp:Label>
                </div>
                <div class="col-auto">
                    <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row mb-3">
                <div class="col-auto">
                    <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" CssClass="btn btn-primary" Text="Apply Filter" />
                    <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" CssClass="btn btn-secondary" Text="Clear Filter" />
                </div>
            </div>
        </div>

        
        <p>
        
        </p>
        
        
        
        <p>
            
        </p>
    </form>
</body>
</html>
