<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ticketraffle.aspx.cs" Inherits="Assignment2_N01318294_ServerControls.ticketraffle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Ticket Raffle</h1>
        </div>
        <div>
            <h2>Please enter number of tickets</h2>
            <asp:TextBox runat="server" ID="ticketNumber"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter number of tickets." ControlToValidate="ticketNumber"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="ticketNumber" ErrorMessage="Value must be a whole number" />
        </div>
        <div>
            <asp:Button runat="server" Text="Submit"/>
        </div>

        <div runat="server" id="ticketSummary"></div>
        
    </form>
</body>
</html>
