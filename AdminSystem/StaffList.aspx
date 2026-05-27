<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 1px; top: 6px; position: absolute; height: 227px; width: 406px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 172px; top: 299px; position: absolute" Text="Delete" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblEnteraStaffName" runat="server" Text="Enter a Staff Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffName0" runat="server" style="z-index: 1; left: 127px; top: 228px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStaffName1" runat="server" style="z-index: 1; left: 127px; top: 228px; position: absolute" height="22px" width="128px"></asp:TextBox>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="22px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
