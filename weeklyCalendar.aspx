<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weeklyCalendar.aspx.cs" Inherits="Assignment2_N01318294_ServerControls.weeklyCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Weekly Calender of october</h1>
        </div>
        <div>
            <h2>Please Select the days on which you work</h2>
            <asp:CheckBoxList runat="server" ID="workdays">
                <asp:ListItem Value="Monday">Monday</asp:ListItem>
                <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="Friday">Friday</asp:ListItem>
                <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div runat="server" id="weekly_summary"></div>
        <div>
            <asp:Button runat="server" Text="Submit"/>
        </div>
    </form>
</body>
</html>
