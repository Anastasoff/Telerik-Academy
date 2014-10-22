<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SumNumbers.aspx.cs" Inherits="SumNumbers.WebForms.SumNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sum numbers</title>
    <meta charset="utf-8" />
</head>
<body>
    <form id="sumNumbers" runat="server">
        <fieldset>
            <legend>Sumator</legend>
            <label for="tbFirstNumber">First number:</label>
            <asp:TextBox ID="tbFirstNumber" runat="server"></asp:TextBox>
            <span runat="server" id="firstNumberError"></span>
            <br />
            <label for="tbSecondNumber">Second number:</label>
            <asp:TextBox ID="tbSecondNumber" runat="server"></asp:TextBox>
            <span runat="server" id="secondNumberError"></span>
            <br />
            <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" />
            <br />
            <label for="TextBoxResult">Result:</label>
            <%--<asp:TextBox ID="TextBoxResult" ReadOnly="true" runat="server"></asp:TextBox>--%>
            <asp:Literal ID="Result" runat="server" />
        </fieldset>
    </form>
</body>
</html>
