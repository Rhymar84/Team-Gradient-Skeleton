<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersLogin.aspx.cs" Inherits="OrdersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h2 class="mb-4">Orders Login Page</h2>
        

            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblUserName" runat="server" CssClass="col-form-label fw-semibold" Text="UserName:"></asp:Label>
                </div>
                <div class="col-2">
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="col-form-control"></asp:TextBox>
                </div>
            </div>

            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblPassword" runat="server" CssClass="col-form-label fw-semibold" Text="Password:"></asp:Label>
                </div>
                <dib class="col-2">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="col-form-control" TextMode="Password"></asp:TextBox>
                </dib>
            </div>
        
        
            <div class="mb-3">
                <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
            </div>
        
            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" CssClass="btn btn-primary" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
