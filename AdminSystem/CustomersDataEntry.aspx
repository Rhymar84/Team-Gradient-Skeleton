<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">

            <h2 class="mb-4">Customer Data Entry</h2>

            <div class="row mb-3 align-items-center">
                <div class="col-4">
                    <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtCustomerID" runat="server" CssClass="form-control" />
                </div>
                <div class="col-auto">
                    <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn btn-primary" />
                </div>
            </div>

            <div class="row mb-3 align-items-center">
                <div class="col-4">
                    <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtCustomerName" runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row mb-3 align-items-center">
                <div class="col-4">
                    <asp:Label ID="lblCustomerEmail" runat="server" Text="Customer Email" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtCustomerEmail" runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row mb-3 align-items-center">
                <div class="col-4">
                    <asp:Label ID="lblCustomerPhoneNo" runat="server" Text="Customer Phone No" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtCustomerPhoneNo" runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row mb-3 align-items-center">
                <div class="col-4">
                    <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtCustomerAddress" runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row mb-3 align-items-center">
                <div class="col-4">
                    <asp:Label ID="lblCustomerDateRegistered" runat="server" Text="Date Registered" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-4">
                    <asp:TextBox ID="txtCustomerDateRegistered" runat="server" CssClass="form-control"
                        OnTextChanged="txtCustomerDateRegistered_TextChanged" />
                </div>
            </div>

            <div class="row mb-3 align-items-center">
                <div class="col-4">
                    <asp:Label runat="server" Text="Verified" CssClass="col-form-label fw-semibold" />
                </div>
                <div class="col-auto">
                    <asp:CheckBox ID="chkCustomerIsVerified" runat="server" CssClass="form-check-input mt-2" />
                </div>
            </div>

            <div class="row mb-3">
                <div class="col">
                    <asp:Label ID="lblError" runat="server" CssClass="text-danger" />
                </div>
            </div>

            <div class="row">
                <div class="col">
                    <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" CssClass="btn btn-success me-2" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-danger me-2"
                        OnClientClick="return confirm('Are you sure you want to cancel? Any unsaved changes will be lost.');"
                        OnClick="btnCancel_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CssClass="btn btn-warning"
                        OnClientClick="return confirm('Are you sure you want to clear all fields?');" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>