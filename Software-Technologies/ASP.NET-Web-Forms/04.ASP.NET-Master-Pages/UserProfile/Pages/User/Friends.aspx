<%@ Page Title="Friends" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Friends.aspx.cs" Inherits="UserProfile.Pages.User.Friends" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2><%: Title %></h2>
        <p>
            <strong><a href="#">User-1</a></strong>
            <br />
            <strong><a href="#">User-2</a></strong>
            <br />
            <strong><a href="#">User-3</a></strong>
        </p>
    </div>

</asp:Content>
