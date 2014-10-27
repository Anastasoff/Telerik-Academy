<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebChat.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FormMain" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManagerWebChat" runat="server"></asp:ScriptManager>

            <asp:ListView ID="ListViewMessages" runat="server"
                DataKeyNames="Id" ItemType="WebChat.Data.Message">
                <LayoutTemplate>
                    <asp:UpdatePanel ID="UpdatePanelTimer" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger EventName="Tick" ControlID="ChatRefreshTimer" />
                        </Triggers>
                        <ContentTemplate>
                            <div id="itemPlaceHolder" runat="server"></div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </LayoutTemplate>
                <ItemTemplate>
                    <div>
                        <p>
                            <span><%#: Item.Content %></span>
                            <br />
                            by <strong><%#: Item.Username %></strong> on <em><time><%#: Item.Created %></time></em>
                        </p>
                    </div>
                </ItemTemplate>
            </asp:ListView>

            <div>
                <strong>Username:</strong>
                <asp:TextBox ID="TextBoxUsername" runat="server" />
                <br />
                <textarea id="TextAreaNewMessage" runat="server" rows="3" cols="50" placeholder="Enter your message..." />
                <br />
                <asp:Button ID="ButtonSendMessage" runat="server" Text="Send Message" OnClick="ButtonSendMessage_Click" />
            </div>

            <asp:Timer ID="ChatRefreshTimer" runat="server" Interval="500" />
        </div>
    </form>
</body>
</html>
