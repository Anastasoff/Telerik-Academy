<%@ Page Title="Articles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="NewsSystem.Admin.Articles" %>

<asp:Content ID="ArticlesContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView ID="ListViewArticles" runat="server"
        ItemType="NewsSystem.Models.Article"
        DataKeyNames="Id"
        SelectMethod="ListViewArticles_GetData"
        UpdateMethod="ListViewArticles_UpdateItem"
        DeleteMethod="ListViewArticles_DeleteItem">

        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton Text="Sort by Title" runat="server" ID="LinkButtonSortByTitle" CommandName="Sort" CommandArgument="Title" CssClass="col-md-2 btn btn-default" />
                <asp:LinkButton Text="Sort by Date" runat="server" ID="LinkButtonSortByDate" CommandName="Sort" CommandArgument="DateCreated" CssClass="col-md-2 btn btn-default" />
                <asp:LinkButton Text="Sort by Category" runat="server" ID="LinkButtonSortByCategory" CommandName="Sort" CommandArgument="" CssClass="col-md-2 btn btn-default" />
                <asp:LinkButton Text="Sort by Likes" runat="server" ID="LinkButtonSortByLikes" CommandName="Sort" CommandArgument="" CssClass="col-md-2 btn btn-default" />
            </div>

            <asp:PlaceHolder ID="ItemPlaceholder" runat="server" />

            <%--<a href="#" class="btn btn-info pull-right" onclick="(function (ev) { $('#panelInsertArticle').show(); $('#buttonShowInsertPanel').hide(); }())">Insert new Article</a>
            <div id="panelInsertArticle" style="display: none;">
                <div class="row">
                    <h3>Title: 
                        <asp:TextBox ID="TextBoxTitle" runat="server" Style="width: 300px;" />
                    </h3>
                    <p>
                        Category: 
                        <select id="DropDownListCategories">
                            <option value="5">Art</option>
                            <option value="1">Economy</option>
                            <option value="2">Education</option>
                            <option value="4">Science</option>
                            <option value="3">Sports</option>
                            <option value="6">Technology</option>
                            <option value="7">Weather</option>
                        </select>
                    </p>
                    <p>
                        Content: 
                        <asp:TextBox ID="TextBoxContent" runat="server" />
                    </p>
                    <div>
                        <asp:LinkButton runat="server" ID="LinkButtonInsert" CssClass="btn btn-success" Text="Insert" CommandName="Insert" />
                        <asp:LinkButton runat="server" ID="LinkButtonCancel" CssClass="btn btn-danger" Text="Cancel" CommandName="Cancel" PostBackUrl="~/Admin/Articles.aspx" />
                    </div>
                </div>
            </div>--%>

            <asp:LinkButton runat="server" ID="LinkButtonInsert" OnClick="LinkButtonInsert_Click" CssClass="btn btn-info pull-right" Text="Insert new Article"></asp:LinkButton>

            <div class="row">
                <span>
                    <asp:DataPager ID="DataPagerArticles" runat="server"
                        PagedControlID="ListViewArticles" PageSize="5">
                        <Fields>
                            <asp:NumericPagerField />
                        </Fields>
                    </asp:DataPager>
                </span>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="row">
                <h3><%#: Item.Title %>
                    <asp:LinkButton runat="server" Text="Edit" CommandName="Edit" CssClass="btn btn-info" />
                    <asp:LinkButton runat="server" Text="Delete" CommandName="Delete" CssClass="btn btn-danger" />
                </h3>
                <p>Category: <%#: Item.Category.Name %></p>
                <p><%#: Item.Content %></p>
                <p>Likes count: <%#: Item.Likes.Count %></p>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: <time><%#: Item.DateCreated %></time></i>
                </div>
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            <div class="row">
                <asp:TextBox ID="TextBoxEditTitle" runat="server" Text="<%#: BindItem.Title %>" />
                <asp:LinkButton Text="Save" CommandName="Update" runat="server" CssClass="btn btn-info" />
                <asp:LinkButton Text="Cancel" CommandName="Cancel" runat="server" CssClass="btn btn-danger" />
                <p>
                    Category: 
                    <asp:DropDownList runat="server" ID="DropDownListEditArticlesCategory"
                        DataTextField="Name" DataValueField="Id" ItemType="NewsSystem.Models.Category"
                        SelectedValue="<%#: BindItem.CategoryId %>" SelectMethod="DropDownListEditArticlesCategory_GetData">
                    </asp:DropDownList>
                </p>
                <p>
                    <asp:TextBox ID="TextBoxEditContent" runat="server" Text="<%#: BindItem.Content %>" />
                </p>
                <p>Likes count: <%#: Item.Likes.Count %></p>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: <time><%#: Item.DateCreated %></time></i>
                </div>
            </div>
        </EditItemTemplate>
        <InsertItemTemplate>
        </InsertItemTemplate>
    </asp:ListView>

</asp:Content>
