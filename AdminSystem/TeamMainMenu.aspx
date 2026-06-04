<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gradient Tech Main Menu</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script type="text/javascript">
        function confirmExit() {
            if (confirm("Are you sure you want to exit?")) {
                window.open('', '_self').close();
            }
            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">

            <h2 class="mb-4 text-center">Gradient Tech Main Menu</h2>
            <hr />

            <div class="row justify-content-center mt-4">
                <div class="col-auto">
                    <asp:Button ID="btnCustomers" runat="server" OnClick="btnCustomers_Click"
                        Text="Customers" CssClass="btn btn-primary me-3" TabIndex="1" />
                    <asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click"
                        Text="Orders" CssClass="btn btn-primary me-3" TabIndex="2" />
                    <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click"
                        Text="Staff" CssClass="btn btn-primary me-3" TabIndex="3" />
                    <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click"
                        Text="Stock" CssClass="btn btn-primary me-3" TabIndex="4" />
                </div>
            </div>

            <div class="row justify-content-center mt-4">
                <div class="col-auto">
                    <asp:Button ID="btnExit" runat="server" Text="Exit"
                        CssClass="btn btn-danger" TabIndex="5"
                        OnClientClick="return confirmExit();" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>