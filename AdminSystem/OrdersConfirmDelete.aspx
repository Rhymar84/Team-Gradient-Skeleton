<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders Confirm Delete</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h2 class="mb-4">Confirm Delete</h2>

            <div class="row mb-4 align-items-center">
                <div class="col-auto">
                    <div class="alert alert-warning">
                        Are you sure you want to delete this record?
                    </div>
                </div>
            </div>

            <div class="row mb-4 align-items-center">
                <div class="col-auto">
                    <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" CssClass="btn btn-primary" TabIndex="1" Text="Yes" />
                    <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" CssClass="btn btn-secondary" TabIndex="2" Text="No" />
                </div>
            </div>
        </div>
        
    </form>
</body>
</html>
