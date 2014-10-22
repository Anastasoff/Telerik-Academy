<%@ Page Title="Employees" Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesGridView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%# Page.Title %> - GridView</title>
</head>
<body>
    <form id="FromEmployees" runat="server">
        <div>
            <asp:GridView ID="GridViewEmployees" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:HyperLinkField Text="Details" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Details.aspx?id={0}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
