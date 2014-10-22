<%@ Page Title="Employees" Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesListView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%# Page.Title %> - ListView</title>
    <link href="Site.css" rel="stylesheet" />
</head>
<body>
    <form id="FromEmployees" runat="server">
        <div>
            <asp:ListView ID="ListViewEmployees" ItemType="Northwind.Model.Employee" runat="server">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>First Name</td>
                            <td><%#: Item.FirstName %></td>
                        </tr>
                        <tr>
                            <td>Last Name</td>
                            <td><%#: Item.LastName %></td>
                        </tr>
                        <tr>
                            <td>Title</td>
                            <td><%#: Item.Title %></td>
                        </tr>
                        <tr>
                            <td>Address</td>
                            <td><%#: Item.Address %></td>
                        </tr>
                        <tr>
                            <td>City</td>
                            <td><%#: Item.City %></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
