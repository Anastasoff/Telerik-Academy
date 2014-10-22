<%@ Page Title="Personal Info" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="PersonalInfo.aspx.cs" Inherits="UserProfile.Pages.User.PersonalInfo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2><%: Title %></h2>
        <br />
        <p>
            <span>Username:</span> <strong>User</strong>
            <br />
            <span>Age:</span> <strong>0</strong>
        </p>
    </div>

</asp:Content>
