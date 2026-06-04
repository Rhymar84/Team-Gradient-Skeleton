<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">

            <h2 class="mb-4">Staff Login Page</h2>

            <div class="mb-3">
                <asp:Label ID="lblUserName" runat="server" Text="Username" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
            </div>

            <div class="mb-3">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click1" Text="Login" CssClass="btn btn-primary" />
                <asp:Button ID="BtnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" CssClass="btn btn-secondary" />
            </div>

        </div>
    </form>
</body>
</html>