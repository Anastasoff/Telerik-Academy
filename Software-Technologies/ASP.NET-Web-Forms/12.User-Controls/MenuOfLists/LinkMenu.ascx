<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LinkMenu.ascx.cs" Inherits="MenuOfLists.LinkMenu" %>

<asp:DataList ID="DataListBox" runat="server">
    <ItemTemplate>
        <asp:HyperLink ID="HyperLinkItem" runat="server"
            NavigateUrl='<%#: Eval("Url") %>'
            Text=' <%#:Eval("Name") %>'
            ForeColor='<%#Eval("FontColor") %>' />
    </ItemTemplate>
</asp:DataList>
