<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="coordinate.aspx.cs" Inherits="Assignment2_N01318294_ServerControls.coordinate1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Check Coordinates</h1>
        </div>
        <div>
            <h2>Please Enter x coordinate</h2>
            <asp:TextBox runat="server" id="x_value"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter value." ControlToValidate="x_value"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="x_value" ErrorMessage="Value must be a whole number" />
        </div>
        <div>
            <h2>Please Enter x coordinate</h2>
            <asp:TextBox runat="server" id="y_value"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter value." ControlToValidate="x_value"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="y_value" ErrorMessage="Value must be a whole number" />
        </div>
        <div runat="server" id="quadrantInfo"></div>
        <div>
            <asp:Button runat="server" Text="Submit"/>
        </div>
    </form>
</body>
</html>
