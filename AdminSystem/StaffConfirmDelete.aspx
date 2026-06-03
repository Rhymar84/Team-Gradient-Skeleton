<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete Staff</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>Confirm Delete</h2>
            <p>Are you sure you want to delete this staff record?</p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            &nbsp;
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
            <br /><br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>