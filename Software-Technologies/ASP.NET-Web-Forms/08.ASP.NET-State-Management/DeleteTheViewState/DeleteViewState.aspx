<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteViewState.aspx.cs" Inherits="DeleteTheViewState.DeleteViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.0.3.js"></script>
</head>
<body>
    <form id="FormMain" runat="server">
        <div>
            <asp:TextBox ID="TextBoxScript" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="SubmitScript" runat="server" OnClick="SubmitScriptButton_Click" Text="Submit" />
            <br />
            <button id="delete-viewstate">Delete ViewState</button>
            <br />
            <asp:Label ID="ScriptResult" runat="server"></asp:Label>
        </div>
    </form>

    <script>
        $(document).ready(
            $("#FormMain").on("click", "#delete-viewstate", function () {
                $("#__VIEWSTATE").val("");
            })
        );
    </script>
</body>
</html>
