<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="LibrarySystem.Search" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Repeater ID="RepeaterBooks" runat="server"
            ItemType="LibrarySystem.Data.Models.Book"
            SelectMethod="RepeaterBooks_GetData">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li>
                    <asp:HyperLink NavigateUrl='<%#: string.Format(@"~/BookDetails.aspx?id={0}", Item.Id) %>' runat="server"
                        Text='<%#: string.Format(@"""{0}"" by {1}", Item.Title, Item.Author) %>' />
                    (Category) <span><%#: Item.Category.Name %></span>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    <br />
    <a href="/">Back to home page</a>
</asp:Content>
