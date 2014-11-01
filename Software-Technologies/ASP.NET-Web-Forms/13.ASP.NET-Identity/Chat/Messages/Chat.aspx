<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="Chat.Messages.Chat" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView
        runat="server"
        DataKeyNames="Id"
        ID="LatestMessages"
        UpdateMethod="LatestMessages_UpdateItem"
        DeleteMethod="LatestMessages_DeleteItem"
        SelectMethod="LatestMessages_GetData"
        
        ItemType="Chat.Models.ChatMessage">
        <LayoutTemplate>
            <table id="ListViewChat" runat="server" class="table">
                <tr runat="server">
                    <th runat="server">Username</th>
                    <th runat="server">Message</th>
                    <th runat="server">DatePosted</th>
                    <th runat="server" id="thEditButton" visible="false">Edit</th>
                    <th runat="server" id="thDeleteButton" visible="false">Delete</th>
                </tr>
                <tr runat="server" id="itemPlaceholder" />
            </table>
        </LayoutTemplate>
        <EmptyDataTemplate>
            There aren't any messages to show
        </EmptyDataTemplate>
        <ItemTemplate>
            <tr>
                <td class="col-md-2"><%# Item.User.FirstName + " "+ Item.User.LastName%></td>
                <td class="col-md-8"><%# Item.Content %></td>
                <td class="col-md-2"><%# Item.DatePosted %></td>
                
                <% if (IsAdmin())
                   {
                %>
                <td class="col-md-2">
                    <asp:Button Text="Delete" runat="server" ID="btnDelete" CommandName="Delete"/>
                </td>
                <%
                   }%>
                
                <% if (IsModerator())
                   {
                %>
                <td class="col-md-2">
                    <asp:Button Text="Edit" runat="server" ID="btnEdit" CommandName="Edit" CausesValidation="false"/>
                </td>
                <%
                   }%>    
            </tr>
        </ItemTemplate>
        <EditItemTemplate>
            <tr>
                <td class="col-md-2"><%# Item.User.FirstName + " "+ Item.User.LastName%></td>
                <td class="col-md-8">
                    <asp:TextBox runat="server" ID="EditTextBox" Text="<%# BindItem.Content %>"/>
                </td>
                <td class="col-md-2"><%# Item.DatePosted %></td>
                <td>
                    <asp:Button Text="Update" runat="server" CommandName="Update" CausesValidation="false" />
                </td>
                <td>
                    <asp:Button Text="Cancel" runat="server" CommandName="Cancel" />
                </td>
        </EditItemTemplate>
    </asp:ListView>
    <hr />
    <div>
        <asp:TextBox runat="server" ID="NewChatMessage" AutoPostBack="false" />
        <asp:Button ID="PostNewMessage" Text="Post Message" runat="server" 
            OnClick="PostNewMessage_Click" />
    </div>
    <asp:RequiredFieldValidator 
        runat="server" 
        ControlToValidate="NewChatMessage" 
        CssClass="text-danger" 
        ErrorMessage="Why on earth would you want to post an empty chat message?" />
</asp:Content>
