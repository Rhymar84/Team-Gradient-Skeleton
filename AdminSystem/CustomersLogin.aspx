<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersLogin.aspx.cs" Inherits="CustomersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtPassword" runat="server" height="21px" style="z-index: 1; left: 131px; top: 137px; position: absolute" TextMode="Password" width="158px"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" ForeColor="#3333FF" style="z-index: 1; left: 34px; top: 52px; position: absolute; width: 329px; height: 27px" Text="Address Book Login Page"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 42px; top: 93px; position: absolute" Text="UserName"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 132px; top: 90px; position: absolute; width: 158px; height: 21px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 42px; top: 139px; position: absolute; bottom: 431px" Text="Password"></asp:Label>
            <asp:Label ID="lblError" runat="server" ForeColor="#CC3300" style="z-index: 1; left: 327px; top: 142px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" height="26px" OnClick="btnLogin_Click" style="z-index: 1; left: 146px; top: 184px; position: absolute" Text="Login" width="60px" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" OnClick="Button1_Click" style="z-index: 1; top: 184px; position: absolute; left: 220px" Text="Cancel" />
        </p>
    </form>
</body>
</html>
