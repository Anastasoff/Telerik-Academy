<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewsSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>News</h1>

    <h2>Most popular articles</h2>
    <asp:ListView ID="ListViewPopularArticles" runat="server"
        ItemType="NewsSystem.Models.Article"
        SelectMethod="ListViewPopularArticles_GetData"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <h3>
                <asp:HyperLink runat="server"
                    NavigateUrl='<%# string.Format("~/ArticleDetails.aspx?id={0}", Item.Id) %>'
                    Text='<%# Item.Title %>' />
                <small><%#: Item.Category.Name %></small>
            </h3>
            <p><%#: Item.Content %></p>
            <p><%#: Item.Likes.Count %></p>
            <div>
                <i>by <%#: Item.Author.UserName %></i>
                <i>created on: <time><%#: Item.DateCreated %></time></i>
            </div>
        </ItemTemplate>
    </asp:ListView>

    <h2>All categories</h2>
    <asp:ListView runat="server" ID="ListViewCategories"
        ItemType="NewsSystem.Models.Category"
        SelectMethod="ListViewCategories_GetData"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="ItemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>

        <ItemTemplate>
            <div class="col-md-4">
                <h3><%#: Item.Name %></h3>
                <asp:ListView runat="server" ID="ListViewArticles"
                    ItemType="NewsSystem.Models.Article"
                    DataSource="<%# Item.Articles %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="ItemPlaceHolder" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:HyperLink runat="server"
                                NavigateUrl='<%# string.Format("~/ArticleDetails.aspx?id={0}", Item.Id) %>'
                                Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Author.UserName) %>' />
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No articles.
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
