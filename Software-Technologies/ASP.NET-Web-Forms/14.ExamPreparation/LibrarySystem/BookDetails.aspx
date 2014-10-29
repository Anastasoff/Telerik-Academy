<%@ Page Title="Book Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="LibrarySystem.BookDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="ListViewBook" runat="server"
        SelectMethod="ListViewBook_GetData" ItemType="LibrarySystem.Data.Models.Book">
        <ItemTemplate>
            <h1><%#: Item.Title %></h1>
            <ul class="list-group">
                <li class="list-group-item"><%#: Item.Author %></li>
                <li class="list-group-item"><%#: Item.ISBN %></li>
                <li class="list-group-item">Web site: <a href="<%#: Item.WebSite %>"><%#: Item.WebSite %></a></li>
                <li class="list-group-item"><%#: Item.Description %></li>
            </ul>
        </ItemTemplate>
    </asp:ListView>
    <br />
    <a href="/">Back to home page</a>
</asp:Content>
