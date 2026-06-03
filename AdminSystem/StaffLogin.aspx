<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Staff Login Page</p>
        <p>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 189px; top: 261px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 192px; top: 221px; position: absolute; margin-bottom: 9px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 85px; top: 223px; position: absolute; height: 25px" Text="UserName"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 389px; top: 238px; position: absolute; height: 24px" Text="{lblError}"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 84px; top: 262px; position: absolute; width: 78px; height: 24px" Text="Password"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click1" style="z-index: 1; left: 99px; top: 311px; position: absolute" Text="Login" />
            <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; left: 219px; top: 312px; position: absolute" Text="Cancel" OnClick="BtnCancel_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
