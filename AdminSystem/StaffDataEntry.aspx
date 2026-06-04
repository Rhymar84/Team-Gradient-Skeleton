<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">

            <h2 class="mb-4">Staff Data Entry</h2>

            <div class="mb-3">
                <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtStaffID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn btn-primary" />
            </div>

            <div class="mb-3">
                <asp:Label ID="lblStaffName" runat="server" Text="Staff Name" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtStaffName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtStaffRole" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblStaffAddress" runat="server" Text="Staff Address" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtStaffAddress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblStaffPhoneNo" runat="server" Text="Staff Phone No" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtStaffPhoneNo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblDateofHire" runat="server" Text="Staff Date of Hire" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtStaffDateofHire" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3 form-check">
                <asp:CheckBox ID="chkStaffClockIn" runat="server" CssClass="form-check-input" />
                <asp:Label runat="server" Text="Staff Clock In" CssClass="form-check-label"></asp:Label>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
            </div>

            <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" />

        </div>
    </form>
</body>
</html>