<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the Customer Management Entry Page
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 429px; top: 72px; position: absolute; width: 55px" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 77px; position: absolute" Text="Customer ID" height="21px"></asp:Label>
        </p>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 118px; position: absolute" Text="Customer Name" height="21px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 193px; top: 110px; position: absolute; width: 198px; height: 22px"></asp:TextBox>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 10px; top: 159px; position: absolute; height: 21px; width: 119px" Text="Customer Email"></asp:Label>
        <p>
            <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 193px; top: 153px; position: absolute; width: 198px; height: 22px; bottom: 487px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerPhoneNo" runat="server" style="z-index: 1; left: 10px; top: 198px; position: absolute" Text="Customer Phone No" height="21px"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerPhoneNo" runat="server" style="z-index: 1; left: 193px; top: 194px; position: absolute; width: 198px; height: 22px; bottom: 446px"></asp:TextBox>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 10px; top: 239px; position: absolute" Text="Customer Address" height="21px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 193px; top: 235px; position: absolute; width: 198px; height: 22px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerDateRegistered" runat="server" style="z-index: 1; left: 13px; top: 280px; position: absolute; height: 21px; width: 164px" Text="Customer Date Registered"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerDateRegistered" runat="server" style="z-index: 1; left: 192px; top: 275px; position: absolute; width: 198px; height: 22px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkCustomerIsVerified" runat="server" style="z-index: 1; left: 190px; top: 322px; position: absolute" Text="Verified" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 347px; position: absolute; height: 1px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 180px; top: 386px; position: absolute; height: 28px; width: 61px" Text="Cancel" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 82px; top: 387px; position: absolute; height: 28px; width: 61px" Text="OK" />
        </p>
        <p>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 195px; top: 71px; position: absolute; height: 22px; width: 198px; bottom: 569px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
