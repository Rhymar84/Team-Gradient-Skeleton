<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders Data Entry</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h2 class="mb-4">Orders Data Entry</h2>

            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblOrderNo" runat="server" Text="Order No." CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-2">
                    <asp:TextBox ID="txtOrderNo" runat="server" CssClass="form-control" />
                </div>
                <div class="col-2">
                    <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn btn-primary" />
                </div>
            </div>
            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblDateOrdered" runat="server" CssClass="col-form-label fw-semibold" Text="Date Ordered"></asp:Label>
                </div>
                <div class="col-2">
                    <asp:TextBox ID="txtDateOrdered" runat="server" CssClass="form-control" TabIndex="2" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblShippingAddress" runat="server" CssClass="col-form-label fw-semibold" Text="Shipping Address"></asp:Label>
                </div>
                <div class="col-2">
                    <asp:TextBox ID="txtShippingAddress" runat="server" CssClass="form-control" TabIndex="3"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblOrderStatus" runat="server" CssClass="col-form-label fw-semibold" Text="Order Status"></asp:Label>
                </div>
                <div class="col-2">
                    <asp:TextBox ID="txtOrderStatus" runat="server" CssClass="form-control" TabIndex="4"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblDeliveryInstructions" runat="server" CssClass="col-form-label fw-semibold" Text="Delivery Instructions"></asp:Label>
                </div>
                <div class="col-2">
                    <asp:TextBox ID="txtDeliveryInstructions" runat="server" CssClass="form-control" TabIndex="5"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblExpressShipping" runat="server" CssClass="col-form-label fw-semibold" Text="Express Shipping"></asp:Label>
                </div>
                <div class="col-2">
                    <asp:CheckBox ID="chkExpressShipping" runat="server" CssClass="form-check-input" TabIndex="6" />
                </div>
            </div>
            <div class="row mb-3 align-items-center">
                <div class="col-2">
                    <asp:Label ID="lblSubTotal" runat="server" CssClass="col-form-label fw-semibold" Text="Subtotal"></asp:Label>
                </div>
                <div class="col-2">
                    <asp:TextBox ID="txtSubtotal" runat="server" CssClass="form-control" TabIndex="7"></asp:TextBox>
                </div>
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>

            <div class="row">
                <div class="col-3">
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" CssClass="btn btn-primary" TabIndex="8" Text="OK" />
                    <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" TabIndex="9" Text="Cancel" OnClick="btnCancel_Click" />
                </div>
            </div>
            
        </div>
    </form>
</body>
</html>
