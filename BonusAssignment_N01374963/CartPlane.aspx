<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartPlane.aspx.cs" Inherits="BonusAssignment_N01374963.CartPlane" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Cartisen Plane</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> Cartisen Plane Quad Determiner</h1>
        <section>
            <h2>Please Enter your X value</h2>
            <asp:TextBox runat="server" ID="x_value"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="x_value" ErrorMessage="please enter a valid integer"></asp:RequiredFieldValidator>
        </section>
        <section>
            <h2>Please Enter your Y value</h2>
            <asp:TextBox runat="server" ID="y_value"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="y_value" ErrorMessage="please enter a valid integer"></asp:RequiredFieldValidator>
        </section>
        <section>
        <div runat="server" id="quad_summary"> </div>
            <asp:Button runat="server" Text="Submit" />
            </section>
    </form>
</body>
</html>
