<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete Customer</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">

            <h2 class="mb-4">Confirm Delete</h2>

            <div class="row mb-4 align-items-center">
                <div class="col">
                    <div class="alert alert-warning">
                        Are you sure you want to delete this customer record? This cannot be undone.
                    </div>
                </div>
            </div>

            <div class="row mb-3">
                <div class="col">
                    <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="btn btn-danger me-2" />
                    <asp:Button ID="btnNo"  runat="server" OnClick="btnNo_Click"  Text="No" CssClass="btn btn-primary" />
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