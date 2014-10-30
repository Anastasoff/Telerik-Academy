<%@ Page Title="Insert Article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertArticle.aspx.cs" Inherits="NewsSystem.Admin.InsertArticle" %>

<asp:Content ID="InsertArticleContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView runat="server" ID="FormViewIsertArticle" DefaultMode="Insert" ItemType="NewsSystem.Models.Article"
        InsertMethod="FormViewIsertArticle_InsertItem" Visible="true">
        <InsertItemTemplate>
            <div class="row">
                <h3>Title: 
                        <asp:TextBox ID="TextBoxTitle" runat="server" Style="width: 300px;" />
                </h3>
                <p>
                    Category: 
                    <asp:DropDownList runat="server" ID="DropDownListInsertCategories"
                        DataTextField="Name" DataValueField="Id" ItemType="NewsSystem.Models.Category"
                        SelectedValue="<%#: BindItem.CategoryId %>" SelectMethod="DropDownListInsertCategories_GetData">
                    </asp:DropDownList>
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
        </InsertItemTemplate>
    </asp:FormView>

    <div class="back-link">
        <a href="/Admin/Articles.aspx">Back to articles</a>
    </div>
</asp:Content>
