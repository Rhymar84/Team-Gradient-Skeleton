<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersLogin.aspx.cs" Inherits="CustomersLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Management Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">

            <h2 class="mb-4">Customer Management Login</h2>
            <div class="row mb-3 align-items-center">
                <div class="col-3">
                    <asp:Label ID="Label2" runat="server" Text="Username" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="row mb-3 align-items-center">
                <div class="col-3">
                    <asp:Label ID="Label3" runat="server" Text="Password" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" />
                </div>
            </div>
            <div class="row mb-3">
                <div class="col-offset-3 col">
                    <asp:Label ID="lblError" runat="server" CssClass="text-danger" />
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Button ID="btnLogin"  runat="server" Text="Login"  OnClick="btnLogin_Click"  CssClass="btn btn-primary me-2" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button1_Click"   CssClass="btn btn-danger" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>