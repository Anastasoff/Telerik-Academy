<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="NewsSystem.Admin.Categories" %>

<asp:Content ID="CategoriesContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="ListViewCategories" runat="server"
        ItemType="NewsSystem.Models.Category"
        SelectMethod="ListViewCategories_GetData"
        DataKeyNames="Id"
        DeleteMethod="ListViewCategories_DeleteItem"
        UpdateMethod="ListViewCategories_UpdateItem">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton Text="Sort by Name" runat="server"
                    CommandName="Sort" CommandArgument="Name" CssClass="btn btn-default" />
            </div>

            <asp:PlaceHolder ID="ItemPlaceHolder" runat="server" />

            <div class="row">
                <span>
                    <asp:DataPager ID="DataPagerCategories" runat="server"
                        PagedControlID="ListViewCategories" PageSize="5">
                        <Fields>
                            <asp:NumericPagerField />
                        </Fields>
                    </asp:DataPager>
                </span>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="row">
                <div class="col-md-3"><%#: Item.Name %></div>
                <asp:LinkButton runat="server" Text="Edit" CommandName="Edit" CssClass="btn btn-info" />
                <asp:LinkButton runat="server" Text="Delete" CommandName="Delete" CssClass="btn btn-danger" />
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox ID="TextBoxEditName" runat="server" Text="<%#: BindItem.Name %>" />
                </div>
                <asp:LinkButton Text="Save" CommandName="Update" runat="server" CssClass="btn btn-info" />
                <asp:LinkButton Text="Cancel" CommandName="Cancel" runat="server" CssClass="btn btn-danger" />
            </div>
        </EditItemTemplate>
    </asp:ListView>
</asp:Content>
