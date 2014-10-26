<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SesionObjectContent.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FormMain" runat="server">
        <div>
            <asp:TextBox runat="server" ID="TextBoxInput" />
            <asp:Label runat="server" ID="LabelOutput" />
            <div>
                <asp:Button ID="ButtonAddLoad" runat="server" Text="Post Back" OnClick="ButtonAddLoad_Click" />
            </div>
        </div>
    </form>
</body>
</html>
