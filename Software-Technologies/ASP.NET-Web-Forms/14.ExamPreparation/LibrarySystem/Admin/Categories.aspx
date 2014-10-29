<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="LibrarySystem.Admin.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="container">
            <asp:ListView ID="ListViewCategories" runat="server"
                ItemType="LibrarySystem.Data.Models.Category"
                DataKeyNames="Id"
                SelectMethod="ListViewCategories_GetData"
                DeleteMethod="ListViewCategories_DeleteItem"
                UpdateMethod="ListViewCategories_UpdateItem"
                InsertMethod="ListViewCategories_InsertItem"
                InsertItemPosition="LastItem">
                <LayoutTemplate>
                    <table class="table table-striped table-hover">
                        <thead>
                            <tr>
                                <th>
                                    <asp:LinkButton Text="Category" runat="server"
                                        CommandName="Sort" CommandArgument="Category" />
                                </th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <td colspan="2">
                                    <asp:DataPager ID="DataPagerCategories" runat="server"
                                        PagedControlID="ListViewCategories" PageSize="5">
                                        <Fields>
                                            <asp:NumericPagerField />
                                        </Fields>
                                    </asp:DataPager>
                                </td>
                            </tr>
                        </tfoot>
                        <tbody>
                            <asp:PlaceHolder ID="ItemPlaceholder" runat="server" />
                        </tbody>
                    </table>
                </LayoutTemplate>

                <ItemTemplate>
                    <tr>
                        <td><%#: Item.Name %></td>
                        <td>
                            <asp:Button Text="Edit" CommandName="Edit" runat="server" />
                            <asp:Button Text="Delete" CommandName="Delete" runat="server" />
                        </td>
                    </tr>
                </ItemTemplate>

                <EditItemTemplate>
                    <tr>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                        </td>
                        <td>
                            <asp:Button Text="Save" CommandName="Update" runat="server" />
                            <asp:Button Text="Cancel" CommandName="Cancel" runat="server" />
                        </td>
                    </tr>
                </EditItemTemplate>

                <InsertItemTemplate>
                    <tr>
                        <td>
                            <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                        </td>
                        <td>
                            <asp:Button ID="ButtonInsert" Text="Save" CommandName="Insert" runat="server" />
                            <asp:Button ID="ButtonCancel" Text="Cancel" CommandName="Cancel" runat="server" />
                        </td>
                    </tr>
                </InsertItemTemplate>
            </asp:ListView>
        </div>

        <div class="container">
            <h2>Insert category</h2>
            <asp:TextBox ID="TextBoxCategoryName" runat="server"></asp:TextBox>
            <asp:LinkButton ID="LinkButtonAddNewCategory" runat="server"
                Text="Add new category" CssClass="btn btn-default bnt-lg"
                OnCommand="LinkButtonAddNewCategory_Command" />
        </div>
    </div>
    <br />
    <a href="/">Back to home page</a>
</asp:Content>
