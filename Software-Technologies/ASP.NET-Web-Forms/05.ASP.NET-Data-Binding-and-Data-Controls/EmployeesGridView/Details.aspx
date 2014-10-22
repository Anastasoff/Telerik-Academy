<%@ Page Title="Details" Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="EmployeesGridView.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%# Page.Title %> - GridView</title>
</head>
<body>
    <form id="FormDetails" runat="server">
        <div>
            <asp:DetailsView ID="DetailsViewEmployee" runat="server" />
            <br />
            <asp:Button ID="ButtonBack" PostBackUrl="~/Employees.aspx" runat="server" Text="Back" />
        </div>
    </form>
</body>
</html>
