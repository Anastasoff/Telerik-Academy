<%@ Page Title="Article Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="NewsSystem.ArticleDetails" %>

<asp:Content ID="ArticlesDetailsContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="FormViewArticles" runat="server"
        ItemType="NewsSystem.Models.Article"
        SelectMethod="FormViewArticles_GetItem">
        <ItemTemplate>
            <div>
                <div class="like-control col-md-1">
                    <div>Likes</div>
                    <div>
                        <a class="btn btn-default glyphicon glyphicon-chevron-up" href="#"></a>
                        <br />
                        <span class="like-value"><%#: Item.Likes.Count %></span>
                        <br />
                        <a class="btn btn-default glyphicon glyphicon-chevron-down" href="#"></a>
                    </div>
                </div>
            </div>
            <h2><%#: Item.Title %> <small>Category: <%#: Item.Category.Name %></small></h2>
            <p><%#: Item.Content %></p>
            <p>
                <span>Author: <%#: Item.Author.UserName %></span>
                <span class="pull-right"><time><%#: Item.DateCreated %></time></span>
            </p>
        </ItemTemplate>
    </asp:FormView>
    <div class="back-link">
        <a href="/">Back to news</a>
    </div>
</asp:Content>
