<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockDataEntry.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Item Entry</title>
    <style>
        .field-row { margin-bottom: 10px; }
        .field-label { display: inline-block; width: 140px; font-weight: bold; }
        .field-input { width: 200px; }
        .error { color: red; font-weight: bold; }
        .button-bar { margin-top: 20px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Stock</h2>

        <!-- ItemNo (primary key, read-only for editing) -->
        <div class="field-row">
            <span class="field-label">Item No:</span>
            <asp:TextBox ID="txtItemNo" runat="server" CssClass="field-input" Enabled="false" />
        </div>

        <!-- ModelName -->
        <div class="field-row">
            <span class="field-label">Model Name:</span>
                 <asp:TextBox ID="txtModelName" runat="server" CssClass="field-input" MaxLength="50" />
 &nbsp;            </div>

        <!-- Price (varchar) -->
        <div class="field-row">
            <span class="field-label">Price:</span>
            <asp:TextBox ID="txtPrice" runat="server" CssClass="field-input" MaxLength="10" />
                              </div>

        <!-- Quantity -->
        <div class="field-row">
            <span class="field-label">Quantity:</span>
            <asp:TextBox ID="txtQuantity" runat="server" CssClass="field-input" />
                              </div>

        <!-- InStock (checkbox) -->
        <div class="field-row">
            <span class="field-label">In Stock:</span>
                   <asp:CheckBox ID="chkInStock" runat="server" />
        </div>

        <!-- LastDateRestocked -->
        <div class="field-row">
            <span class="field-label">Last Restocked:</span>
            <asp:TextBox ID="txtLastDateRestocked" runat="server" CssClass="field-input" TextMode="Date" />
                   </div>

        <!-- Buttons -->
        <div class="button-bar">
            <asp:Button ID="btnOK" Text="OK" runat="server" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CausesValidation="false" />
        </div>

        <!-- Error Label -->
        <div class="field-row">
            <asp:Label ID="lbError" runat="server" CssClass="error" EnableViewState="false" />
        </div>

        <!-- Summary of all validation errors -->
           </form>
</body>
</html>