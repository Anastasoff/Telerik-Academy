<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbers.aspx.cs" Inherits="RandomNumbersHtmlControls.RandomNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Numbers - HTML Controls</title>
</head>
<body>
    <form id="formRandomNumbers" runat="server">
        <div>
            <label for="TextBoxFromNumber">From:</label>
            <input type="number" id="TextBoxFromNumber" runat="server" />
            <label for="TextBoxToNumber">To:</label>
            <input type="number" id="TextBoxToNumber" runat="server" />
            <br />
            <input type="button" id="ButtonGenerate" runat="server" onserverclick="ButtonGenerate_ServerClick" value="Generate" />
            <hr />
            <input type="text" id="LabelResult" runat="server" readonly="true" />
        </div>
    </form>
</body>
</html>
