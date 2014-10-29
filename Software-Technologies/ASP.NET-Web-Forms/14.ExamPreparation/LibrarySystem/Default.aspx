<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LibrarySystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <header class="container">
        <h1 class="pull-left">Books</h1>
        <div class="pull-right">
            <asp:TextBox ID="TextBoxSearch" runat="server" />
            <asp:Button ID="ButtonSearch" runat="server" Text="Search" OnClick="ButtonSearch_Click" />
        </div>
    </header>

    <div class="jumbotron">
        <asp:ListView ID="ListViewBooks" runat="server"
            ItemType="LibrarySystem.Data.Models.Category">
            <ItemTemplate>
                <div>
                    <h2><%#: Item.Name %></h2>
                    <ul>
                        <asp:Repeater ID="RepeaterBooks" runat="server"
                            DataSource="<%# Item.Books %>"
                            ItemType="LibrarySystem.Data.Models.Book">
                            <ItemTemplate>
                                <li>
                                    <asp:HyperLink NavigateUrl='<%#: string.Format(@"~/BookDetails.aspx?id={0}", Item.Id) %>' runat="server"
                                        Text='<%#: string.Format(@"""{0}"" by {1}", Item.Title, Item.Author) %>' />
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
