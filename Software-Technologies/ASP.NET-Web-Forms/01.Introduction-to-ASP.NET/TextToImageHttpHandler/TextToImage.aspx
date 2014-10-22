<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextToImage.aspx.cs" Inherits="TextToImageHttpHandler.TextToImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="TextToImage" runat="server">
        <div>
            <asp:TextBox ID="TextBoxContent" runat="server" value="This is some text." />
            <asp:Button ID="ButtonGenerate" Text="Generate" runat="server" OnClick="ButtonGenerate_Click" />
        </div>
    </form>
</body>
</html>
