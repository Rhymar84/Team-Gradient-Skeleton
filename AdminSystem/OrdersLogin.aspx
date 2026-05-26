<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersLogin.aspx.cs" Inherits="OrdersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Orders Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 50px; top: 143px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 50px; top: 184px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 144px; top: 142px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 144px; top: 183px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 364px; top: 169px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 144px; top: 241px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 216px; top: 242px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
