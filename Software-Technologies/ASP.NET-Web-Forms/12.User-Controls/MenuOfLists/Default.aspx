<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MenuOfLists.Default" %>

<%@ Register TagPrefix="controll" TagName="LinkMenu" Src="~/LinkMenu.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu of links</title>
</head>
<body>
    <form id="MainContent" runat="server">
        <div>
            <controll:LinkMenu ID="LinkMenuItems" runat="server" FontFamily="Consolas" />
        </div>
    </form>
</body>
</html>
