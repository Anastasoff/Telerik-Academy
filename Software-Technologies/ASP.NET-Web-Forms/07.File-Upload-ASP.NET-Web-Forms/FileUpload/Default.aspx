<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FileUpload.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>File Upload</title>
</head>
<body>
    <form id="FormFileUpload" runat="server">
        <div>
            <asp:FileUpload ID="FileUploadArchive" runat="server" />
            <asp:Button ID="ButtonUpload" OnClick="ButtonUpload_Click" Text="Upload" runat="server" />
            <br />
            <asp:Label runat="server" Text="Upload status: " />
            <asp:Label ID="LabelStatus" runat="server" />
        </div>
    </form>
</body>
</html>
