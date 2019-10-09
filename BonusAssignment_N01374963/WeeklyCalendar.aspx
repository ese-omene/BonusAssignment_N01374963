<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeeklyCalendar.aspx.cs" Inherits="BonusAssignment_N01374963.WeeklyCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <p> Please choose the days that you work</p>
            <asp:CheckBoxList runat="server" ID="work_days">
                <asp:ListItem Value="monday">Monday</asp:ListItem>
                <asp:ListItem Value="tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="friday">Friday</asp:ListItem>
                <asp:ListItem Value="saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
            </div>
            <div>
            <section>
                <p>Days in October</p>
                <div id="october" runat="server"></div>
            </section>
               <section>
            <input type="submit" value="submit" />
        </section>
            </div>
    </form>
</body>
</html>
