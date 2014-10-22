<%@ Page Title="Employees" Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesRepeater.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%# Page.Title %> - Repeater</title>
    <link href="Site.css" rel="stylesheet" />
</head>
<body>
    <form id="FormEmployees" runat="server">
        <div>
            <asp:Repeater ID="RepeaterEmployees" runat="server" ItemType="Northwind.Model.Employee">
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
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
