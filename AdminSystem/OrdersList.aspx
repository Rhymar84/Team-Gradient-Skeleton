<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 330px; width: 323px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 25px; top: 372px; position: absolute" Text="Add" TabIndex="2" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 102px; top: 372px; position: absolute" Text="Edit" TabIndex="3" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 184px; top: 372px; position: absolute" TabIndex="3" Text="Delete" />
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 510px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 25px; top: 425px; position: absolute" Text="Enter an Address:"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 164px; top: 424px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 23px; top: 464px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 150px; top: 464px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>
