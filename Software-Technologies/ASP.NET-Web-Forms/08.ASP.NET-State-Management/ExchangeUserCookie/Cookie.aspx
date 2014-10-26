<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="ExchangeUserCookie.Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FormMain" runat="server">
        <div>
            <div>
                <label for="TextBoxUsername">Username:</label>
                <asp:TextBox ID="TextBoxUsername" runat="server" />
            </div>
            <div>
                <label for="TextBoxPassword">Password:</label>
                <asp:TextBox ID="TextBoxPassword" runat="server" />
            </div>
            <asp:Button Text="Login" runat="server" OnClick="Login_Click" ID="LoginButton" />
        </div>
    </form>
</body>
</html>
