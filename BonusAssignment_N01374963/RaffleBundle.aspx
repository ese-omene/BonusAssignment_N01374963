<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RaffleBundle.aspx.cs" Inherits="BonusAssignment_N01374963.RaffleBundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>How many tickets would you like?</h2>
          <asp:TextBox runat="server" ID="ticket_numbers"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server"  
                controltovalidate="ticket_numbers" 
                errormessage="please enter number of tickets"></asp:RequiredFieldValidator>
        <asp:CustomValidator runat="server" 
            Controltovalidate ="ticket_numbers"
            ErrorMessage="Please enter a VALID number"></asp:CustomValidator>
            </section>
        <section>
            <div id="ticket_summary" runat="server"></div>
            <div id="ticket_leftover" runat="server"></div>
            <div id="ticket_total" runat="server"></div>
            <asp:Button runat="server" text="submit" />
         </section>

    </form>
</body>
</html>
