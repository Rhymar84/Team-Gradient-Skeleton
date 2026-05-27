<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="This is Staff Viewer Page">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 127px; top: 4px; position: absolute; bottom: 610px;" height="22px" width="128px" ></asp:TextBox>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 9px; top: 23px; position: absolute" Text="StaffID" height="19px" width="99px"></asp:Label>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 7px; top: 298px; position: absolute; height: 25px"></asp:Label>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 292px; top: 18px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <p>
            <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 9px; top: 57px; position: absolute" Text="StaffAddress" height="19px" width="99px"></asp:Label>
            <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 127px; top: 40px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 9px; top: 96px; position: absolute" Text="StaffRole" height="19px" width="99px"></asp:Label>
        </p>
        <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 127px; top: 81px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtStaffPhoneNo" runat="server" style="z-index: 1; left: 121px; top: 135px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtStaffDateofHire" runat="server" style="z-index: 1; left: 121px; top: 184px; position: absolute" height="22px" width="128px"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 30px; top: 331px; position: absolute; width: 31px;" Text="Ok" OnClick="btnOk_Click" />
        </p>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 9px; top: 227px; position: absolute; height: 29px;" Text="StaffName" width="99px"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 127px; top: 228px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 99px; top: 333px; position: absolute; height: 21px" Text="Cancel" />
        <asp:Label ID="lblStaffPhoneNo" runat="server" style="z-index: 1; left: 9px; top: 144px; position: absolute" Text="StaffPhoneNo" height="19px" width="99px"></asp:Label>
        <p>
            <asp:Label ID="lblDateofHire" runat="server" style="z-index: 1; left: 9px; top: 183px; position: absolute" Text="StaffDateOfHire" height="19px" width="99px"></asp:Label>
        </p>
        <asp:CheckBox ID="chkStaffClockIn" runat="server" style="z-index: 1; left: 130px; top: 267px; position: absolute" Text="StaffClockIn" />
    </form>
</body>
</html>
