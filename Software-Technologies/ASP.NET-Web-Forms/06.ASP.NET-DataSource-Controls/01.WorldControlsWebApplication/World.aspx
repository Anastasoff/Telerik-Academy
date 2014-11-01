<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="World.aspx.cs" Inherits="_01.WorldControlsWebApplication.World" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="WorldForm" runat="server">
        <asp:EntityDataSource ID="EntityDataSourContinents" runat="server" 
            ConnectionString="name=WorldDBEntities" DefaultContainerName="WorldDBEntities" 
            EnableFlattening="False" EntitySetName="Continents">
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="EntityDataSourCountries" runat="server" 
            ConnectionString="name=WorldDBEntities" DefaultContainerName="WorldDBEntities" 
            EnableFlattening="False" EntitySetName="Countries" Include="Continent"
            Where="it.ContinentId=@ContId">
            <WhereParameters>
                <asp:ControlParameter Name="ContId" Type="Int32" ControlID="ListBoxContinent"/>
            </WhereParameters>
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="EntityDataSourceTowns" runat="server" 
            ConnectionString="name=WorldDBEntities" DefaultContainerName="WorldDBEntities" 
            EnableFlattening="False" EntitySetName="Towns" Include="Country"
            Where="it.CountryId=@CounId">
            <WhereParameters>
                <asp:ControlParameter Name="CounId" Type="Int32" ControlID="GridViewCountries" />
            </WhereParameters>
        </asp:EntityDataSource>
        <asp:ListBox ID="ListBoxContinent" runat="server" DataSourceID="EntityDataSourContinents" 
            DataTextField="Name" DataValueField="ContinentId" AutoPostBack="true" SelectionMode="Multiple">
        </asp:ListBox>
        
        <h3>Countries</h3>
        <asp:GridView ID="GridViewCountries" runat="server" AllowPaging="True" AllowSorting="True" 
            DataSourceID="EntityDataSourCountries" AutoGenerateColumns="False" DataKeyNames="CountryId">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"/>
            <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
            <asp:BoundField DataField="Population" HeaderText="Population" SortExpression="Population" />
            <asp:BoundField DataField="Continent.Name" HeaderText="Country's Continent" SortExpression="Continent.Name"/>
        </Columns>
        </asp:GridView>
                
        <asp:ListView ID="ListViewTowns" runat="server" ItemType="_01.WorldControlsWebApplication.Town" DataSourceID="EntityDataSourceTowns">
            <LayoutTemplate>
                <h3>Towns</h3>
                <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
            </LayoutTemplate>

            <ItemSeparatorTemplate>
                <hr />
            </ItemSeparatorTemplate>

            <ItemTemplate>    
                <span class="product-description">
                    <div><%#: Item.Country.Name%></div>
                    <div>Name: <%#: Item.Name %></div>
                    <div>Population: <%#: Item.Population %></div>
            </ItemTemplate>
        </asp:ListView>
        

    </form>
</body>
</html>
