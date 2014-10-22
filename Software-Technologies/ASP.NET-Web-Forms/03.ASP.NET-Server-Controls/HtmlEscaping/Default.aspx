<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HtmlEscaping.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTML Escaping</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelTextInput" runat="server" AssociatedControlID="TextBoxInputText" Text="Text" />
        <asp:TextBox ID="TextBoxInputText" runat="server" />
        <br />
        <asp:Button ID="ButtonShowText" runat="server" Text="Show Text" OnClick="ButtonShowText_Click"/>
        <hr />
        <asp:Label ID="LabelTextOutput" runat="server" />
        <br />
        <asp:TextBox ID="TextBoxTextOutput" runat="server" ReadOnly="true" />
        <br />
        <%: this.TextBoxInputText.Text %>
    </div>
    </form>
</body>
</html>
