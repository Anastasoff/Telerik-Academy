<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWebForms.aspx.cs" Inherits="HelloWebForms.HelloWebForms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello Web Forms</title>
</head>
<body>
    <form id="formHelloWebForms" runat="server">
        <div>
            <asp:Label ID="LabelName" Text="Name" runat="server" />
            <asp:TextBox ID="TextBoxName" runat="server" />
            <br />
            <asp:Button ID="ButtonGreeting" runat="server" Text="Greeting" OnClick="ButtonGreeting_Click" />
            <hr />
            <asp:Literal ID="LiteralGreeting" runat="server" />
        </div>
    </form>
</body>
</html>
