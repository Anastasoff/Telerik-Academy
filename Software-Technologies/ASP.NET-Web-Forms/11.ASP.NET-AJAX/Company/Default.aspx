<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Company.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FromMain" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManagerCompany" runat="server">
            </asp:ScriptManager>

            <h3>Employees</h3>
            <asp:UpdatePanel ID="UpdatePanelEmployees" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridViewEmployees" runat="server"
                        SelectMethod="GridViewEmployees_GetData"
                        ItemType="Company.Data.Employee" AutoGenerateSelectButton="True"
                        DataKeyNames="EmployeeID"
                        OnSelectedIndexChanged="GridViewEmployees_SelectedIndexChanged"
                        AllowPaging="True" PageSize="5" AllowSorting="True" BackColor="#CCCCCC" Width="280px">
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <asp:UpdateProgress ID="UpdateProgressAnimation" runat="server">
                <ProgressTemplate>
                    <asp:Image ImageUrl="~/Images/loading-animation.gif" runat="server" Height="100" Width="100" AlternateText="Loading..." />
                </ProgressTemplate>
            </asp:UpdateProgress>

            <asp:UpdatePanel ID="UpdatePanelOrders" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridViewOrders" runat="server" AutoGenerateColumns="true" BackColor="#CCCCCC"></asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
