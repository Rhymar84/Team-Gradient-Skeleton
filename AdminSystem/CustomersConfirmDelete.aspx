<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 166px; top: 124px; position: absolute; height: 23px; width: 268px" Text="Are you sure you want to delete this record?"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 191px; top: 162px; position: absolute; width: 74px; height: 23px; bottom: 396px" Text="Yes" />
        </p>
        <p>
            <asp:Button ID="btnNo" runat="server" height="23px" OnClick="btnNo_Click" style="z-index: 1; left: 326px; top: 162px; position: absolute" Text="No" width="74px" />
        </p>
    </form>
</body>
</html>
