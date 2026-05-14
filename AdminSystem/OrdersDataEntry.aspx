<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; top: 33px; position: absolute; left: 379px" TabIndex="10" Text="Find" />
        </div>
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 11px; top: 36px; position: absolute; " Text="Order No." width="123px"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 163px; top: 35px; position: absolute" TabIndex="1"></asp:TextBox>
        <p style="height: 19px">
            &nbsp;</p>
        <p style="height: 19px">
            <asp:Label ID="lblDateOrdered" runat="server" style="z-index: 1; left: 11px; top: 75px; position: absolute; height: 18px; width: 123px" Text="Date Ordered"></asp:Label>
        </p>
        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 11px; top: 148px; position: absolute" Text="Order Status" width="123px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtDeliveryInstructions" runat="server" style="z-index: 1; left: 163px; top: 182px; position: absolute" TabIndex="5"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblDeliveryInstructions" runat="server" style="z-index: 1; left: 11px; top: 183px; position: absolute" Text="Delivery Instructions"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblSubTotal" runat="server" style="z-index: 1; left: 11px; top: 262px; position: absolute" Text="Subtotal" width="123px"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkExpressShipping" runat="server" style="z-index: 1; left: 165px; top: 223px; position: absolute" TabIndex="6" Text="Express Shipping" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 319px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblShippingAddress" runat="server" style="z-index: 1; left: 11px; top: 112px; position: absolute" Text="Shipping Address" width="123px"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 39px; top: 355px; position: absolute" TabIndex="8" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 117px; top: 355px; position: absolute" TabIndex="9" Text="Cancel" />
        </p>
        <asp:TextBox ID="txtDateOrdered" runat="server" style="z-index: 1; left: 163px; top: 73px; position: absolute" TabIndex="2"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtShippingAddress" runat="server" style="z-index: 1; left: 163px; top: 111px; position: absolute" TabIndex="3"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 163px; top: 147px; position: absolute" TabIndex="4"></asp:TextBox>
        <asp:TextBox ID="txtSubtotal" runat="server" style="z-index: 1; left: 163px; top: 261px; position: absolute" TabIndex="7"></asp:TextBox>
    </form>
</body>
</html>
