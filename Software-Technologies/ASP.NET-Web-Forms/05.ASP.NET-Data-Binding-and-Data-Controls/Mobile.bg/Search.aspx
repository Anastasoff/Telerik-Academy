<%@ Page Title="Search" Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Mobile.bg.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%# Page.Title %> - Mobile.bg</title>
</head>
<body>
    <form id="FormSearch" runat="server">
        <div>
            <fieldset>
                <legend>Search</legend>
                <asp:Label ID="LabelManufacturer" Text="Manufacturer" runat="server" />
                <asp:DropDownList ID="DropDownManufacturer" DataTextField="Name" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownManufacturer_SelectedIndexChanged" />
                <br />
                <asp:Label ID="LabelModel" Text="Model" runat="server" />
                <asp:DropDownList ID="DropDownModel" runat="server" />
                <br />
                <asp:Label ID="LabelEngine" Text="Engine" runat="server" />
                <asp:RadioButtonList ID="RadioButtonEngine" runat="server" />
                <br />
                <asp:Label ID="LabelExtras" Text="Extras" runat="server" />
                <asp:CheckBoxList ID="CheckBoxExtras" runat="server" />
                <br />
                <asp:Button ID="ButtonSearch" Text="Search" runat="server" OnClick="ButtonSearch_Click" />
                <hr />
                <asp:Literal ID="LiteralResult" runat="server" />
            </fieldset>
        </div>
    </form>
</body>
</html>
