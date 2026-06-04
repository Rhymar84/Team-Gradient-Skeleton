<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete Staff</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">

            <h2 class="mb-4">Confirm Delete</h2>

            <div class="mb-3">
                <p>Are you sure you want to delete this staff record?</p>
            </div>

            <div class="mb-3">
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="btn btn-danger" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="btn btn-secondary" />
            </div>

            <div class="mb-3">
                <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>