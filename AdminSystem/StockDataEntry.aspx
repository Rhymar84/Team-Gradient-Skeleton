<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute" Text="Stock ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtItemNo" runat="server" style="z-index: 1; left: 110px; top: 71px; position: absolute; width: 150px"></asp:TextBox>
        </p>
        <asp:Label ID="lblModelName" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Model Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 109px; top: 129px; position: absolute; width: 150px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 186px; position: absolute" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 110px; top: 184px; position: absolute; width: 150px; right: 215px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 10px; top: 224px; position: absolute" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 110px; top: 224px; position: absolute; width: 150px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 10px; top: 262px; position: absolute" Text="In Stock"></asp:Label>
            <asp:CheckBox ID="txtStock" runat="server" style="z-index: 1; left: 115px; top: 262px; position: absolute; width: 145px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 300px; position: absolute" Text="lblError"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 27px; top: 338px; position: absolute; width: 43px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 102px; top: 338px; position: absolute; width: 75px" Text="Cancel" />
            <br />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
