<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageLifeCycle.aspx.cs" Inherits="PageLifeCycle.PageLifeCycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page Life Cycle</title>
</head>
<body>
    <form id="formPageLifeCycle" runat="server">
        <div>
            <asp:Button
                ID="ButtonOK"
                runat="server"
                OnClick="ButtonOK_Click"
                OnDisposed="ButtonOK_Disposed"
                OnInit="ButtonOK_Init"
                OnLoad="ButtonOK_Load"
                OnPreRender="ButtonOK_PreRender"
                OnUnload="ButtonOK_Unload"
                Text="Execute" />
        </div>
    </form>
</body>
</html>
