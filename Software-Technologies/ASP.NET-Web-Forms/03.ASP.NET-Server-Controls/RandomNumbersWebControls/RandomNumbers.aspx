<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbers.aspx.cs" Inherits="RandomNumbersWebControls.RandomNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Numbers - Web Controls</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelFromNumber" Text="From" runat="server" />
            <asp:TextBox ID="TextBoxFromNumber" runat="server" />
            <asp:Label ID="LabelToNumber" Text="To" runat="server" />
            <asp:TextBox ID="TextBoxToNumber" runat="server" />
            <br />
            <asp:Button Text="Generate" runat="server" ID="ButtonGenerate" OnClick="ButtonGenerate_Click" />
            <hr />
            <asp:TextBox ID="TextBoxResult" runat="server" ReadOnly="true" />
        </div>
    </form>
</body>
</html>
