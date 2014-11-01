<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="World.aspx.cs" Inherits="_02.WorldEditableWebApplication.World" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/style.css" rel="stylesheet" />
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
            Where="it.ContinentId=@ContId" EnableDelete="True" EnableInsert="True" EnableUpdate="True">
            <WhereParameters>
                <asp:ControlParameter Name="ContId" Type="Int32" ControlID="ListBoxContinent"/>
            </WhereParameters>
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="EntityDataSourceTowns" runat="server" 
            ConnectionString="name=WorldDBEntities" DefaultContainerName="WorldDBEntities" 
            EnableFlattening="False" EntitySetName="Towns" Include="Country"
            Where="it.CountryId=@CounId" EnableDelete="True" EnableInsert="True" EnableUpdate="True">
            <WhereParameters>
                <asp:ControlParameter Name="CounId" Type="Int32" ControlID="GridViewCountries" />
            </WhereParameters>
        </asp:EntityDataSource>

        <h3>Countinents</h3>
        <asp:ListBox ID="ListBoxContinent" runat="server" DataSourceID="EntityDataSourContinents" 
            DataTextField="Name" DataValueField="ContinentId" AutoPostBack="true" SelectionMode="Multiple" 
            OnDataBound="ListBoxContinent_SelectedIndexChanged" OnSelectedIndexChanged="ListBoxContinent_SelectedIndexChanged">
        </asp:ListBox>
        <asp:TextBox ID="TextBoxContinentName" runat="server" />  
        <asp:Button ID="ButtonAddContinent" Text="Add" runat="server" OnClick="ButtonAddContinent_Click"/>
        <asp:Button ID="ButtonRemoveContinent" Text="Remove" runat="server" OnClick="ButtonRemoveContinent_Click"/>

        
        <h3>Countries</h3>
        <asp:GridView ID="GridViewCountries" runat="server" AllowPaging="True" AllowSorting="True" PageSize="5" 
            DataSourceID="EntityDataSourCountries" AutoGenerateColumns="False" DataKeyNames="CountryId" 
            ItemType="_02.WorldEditableWebApplication.Country" ShowFooter="false">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:ImageButton ID="ButtonDisplayAddCountry" CommandName="Insert" ImageUrl="~/images/add.png" 
                        Width="24px" Height="24px" AlternateText="Add" runat="server" OnClick="ButtonDisplayAddCountry_Click" />
                    <th>
                        <asp:LinkButton runat="server" ID="SortByNameCountry" CommandName="Sort" Text="Country Name" CommandArgument="Name" />
                    </th>
                     <th>
                        <asp:LinkButton runat="server" ID="SortByLanguigeCountry" CommandName="Sort" Text="Country Language" CommandArgument="Language.Name" />
                    </th>
                    <th>
                        <asp:LinkButton runat="server" ID="SortByPopulationCountry" CommandName="Sort" Text="Country Population" CommandArgument="Population" />
                    </th>
                    <th>
                        <asp:LinkButton runat="server" ID="SortByContinentNameCountry" CommandName="Sort" Text="Country's Continent" CommandArgument="Continent.Name" />
                    </th>
                    <th>
                        <asp:Label runat="server" ID="LabelFlag" Text="Flag" />
                    </th>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:ImageButton ID="ButtonEditCountry" CommandName="Edit" ImageUrl="~/images/edit.png" Width="24px" Height="24" AlternateText="Edit" runat="server" />
                    <asp:ImageButton ID="ButtonDeleteCountry" CommandName="Delete" ImageUrl="~/images/delete.png"  Width="24px" Height="24px" AlternateText="Delete" runat="server" />
                    <asp:ImageButton ID="ButtonSelectCountry" CommandName="Select" ImageUrl="~/images/select.png"  Width="24px" Height="24px" AlternateText="Select" runat="server" />
                    <td>
                         <%#:Item.Name %>
                    </td>
                    <td>
                         <%#:Item.Language %>
                    </td>
                    <td>
                         <%#:Item.Population %>
                    </td>
                    <td>
                         <%#:Item.Continent.Name %>
                    </td>
                    <td>
                         <asp:Image ID="FlagImage" runat="server"  Width="36px" ImageUrl='<%# GetImage(Item.Flag) %>' />
                    </td>
            <%--<asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="CountryId" HeaderText="CountryId" SortExpression="CountryId" ReadOnly="True"/>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
            <asp:BoundField DataField="Population" HeaderText="Population" SortExpression="Population"/>
            <asp:BoundField DataField="Continent.Name" HeaderText="Country's Continent" SortExpression="Continent.Name" />--%>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:ImageButton ID="ButtonUpdateCountry" CommandName="Update" ImageUrl="~/images/update.png" Width="24px" Height="24px" AlternateText="Update" runat="server" />
                    <asp:ImageButton ID="ButtonCancelCountry" CommandName="Cancel" ImageUrl="~/images/delete.png"  Width="24px" Height="24px" AlternateText="Cancel" runat="server" />
                    <td>
                        <asp:TextBox ID="TextBoxCountryName" runat="server" Text="<%#:BindItem.Name %>" />
                    </td>
                    <td>
                         <asp:TextBox ID="TextBoxCountryLanguage" runat="server" Text="<%#:BindItem.Language %>" />
                    </td>
                    <td>
                         <asp:TextBox ID="TextBoxCountryPopulation" runat="server" Text="<%#:BindItem.Population %>" />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListContinent" runat="server" DataSourceID="EntityDataSourContinents" 
                            DataTextField="Name" DataValueField="ContinentId" SelectedValue="<%#:BindItem.ContinentId %>">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Image ID="FlagImage" runat="server" Width="36px" ImageUrl='<%#:GetImage(Item.Flag) %>' />
                        <asp:FileUpload ID="ChangeFlagPicture" runat="server" />
                        <asp:Label ID="LabelChangeFlagPictureValidate" Text="" runat="server" />
                        <asp:RegularExpressionValidator ID="uplValidator" runat="server" ControlToValidate="ChangeFlagPicture"
                             ErrorMessage="InvalidFile! .png, .jpeg, .tiff, .gif & .bmp formats are allowed." ForeColor="Red"
                             ValidationExpression="(.+\.([Pp][Nn][Gg])|.+\.([Jj][Pp][Ee][Gg])|.+\.([Tt][Ii][Ff][Ff])|.+\.([Gg][Ii][Ff])|.+\.([Bb][Mm][Pp]))"
                             SetFocusOnError="true">
                        </asp:RegularExpressionValidator>
                        <asp:ImageButton ID="ImageButtonChangeFlag" ImageUrl="~/images/add.png" Width="24px" Height="24px" AlternateText="Add" runat="server" OnClick="ImageButtonChangeFlag_Click" />
                    </td>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:ImageButton ID="ButtonAddCountry" CommandName="Insert" ImageUrl="~/images/add.png" 
                        Width="24px" Height="24px" AlternateText="Add" runat="server" OnClick="ButtonAddCountry_Click" />
                    <td>
                        <asp:TextBox ID="CountryNameInsert" runat="server" Text="<%#: BindItem.Name %>"
                            OnPreRender="CountryNameInsert_PreRender" AutoPostBack="true">
                        </asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="CountryLanguageInsert" runat="server" Text="<%#: BindItem.Language %>"
                            OnPreRender="CountryLanguageInsert_PreRender" AutoPostBack="true">
                        </asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="CountryPopulationInsert" runat="server" Text="<%#: BindItem.Population %>"
                            OnPreRender="CountryPopulationInsert_PreRender" AutoPostBack="true">
                        </asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListContinentInsert" runat="server" DataSourceID="EntityDataSourContinents" 
                            DataTextField="Name" DataValueField="ContinentId" SelectedValue="<%#:BindItem.ContinentId %>"
                            OnPreRender="DropDownListContinentInsert_PreRender" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:FileUpload ID="AddFlagPicture" runat="server"/>
                        <asp:Label ID="LabelAddFlagPictureValidate" Text="" runat="server" />
                        <%--<asp:RegularExpressionValidator ID="uplValidator" runat="server" ControlToValidate="AddFlagPicture"
                            ErrorMessage="InvalidFile! .png, .jpeg, .tiff, .gif & .bmp formats are allowed." ForeColor="Red"
                             ValidationExpression="(.+\.([Pp][Nn][Gg])|.+\.([Jj][Pp][Ee][Gg])|.+\.([Tt][Ii][Ff][Ff])|.+\.([Gg][Ii][Ff])|.+\.([Bb][Mm][Pp]))"
                             SetFocusOnError="true">
                        </asp:RegularExpressionValidator>--%>
                    </td>
                </FooterTemplate>                
            </asp:TemplateField>
        </Columns>
            <EditRowStyle BackColor="#c0c2c2" />
            <HeaderStyle BackColor="#88b9d2" />
            <FooterStyle BackColor="#94d9dc" />
            <PagerStyle BackColor="#535353" ForeColor="White"/>
            <SelectedRowStyle BackColor="#e1e1e1" />
        </asp:GridView>
                
        <asp:ListView ID="ListViewTowns" runat="server" ItemType="_02.WorldEditableWebApplication.Town" 
            DataKeyNames="TownId" DataSourceID="EntityDataSourceTowns" OnItemCanceling="ListViewTowns_ItemCanceling">
            <LayoutTemplate>
                <h3>Towns </h3>                
                <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                <div class="pagerLine">
                    <asp:ImageButton ID="ButtonInsertTown" ImageUrl="~/images/add.png" 
                        Width="24px" Height="24px" AlternateText="Add" runat="server" OnClick="ButtonInsertTown_Click" />
                        
                    <asp:DataPager ID="DataPagerCustomers" runat="server" PageSize="5">
                        <Fields>
                            <asp:NextPreviousPagerField ShowFirstPageButton="True"
                                ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            <asp:NumericPagerField />
                            <asp:NextPreviousPagerField ShowLastPageButton="True"
                                ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        </Fields>
                    </asp:DataPager>
                </div>
                <%--<table>
                    <thead>
                        <tr>
                            <th>
                                <asp:LinkButton runat="server" ID="SortByNameButton" CommandName="Sort" Text="Name" CommandArgument="Name" /></th>
                            <th>
                                <asp:LinkButton runat="server" ID="SortByPopulation" CommandName="Sort" Text="Population" CommandArgument="Population" /></th>
                            <th>
                                <asp:LinkButton runat="server" ID="SortByCountry" CommandName="Sort" Text="Country" CommandArgument="Country.Name" /></th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                    </tbody>
                    <tfoot>
                        <td class="pagerLine" colspan="3">
                            <asp:Button ID="ButtonInsertTown" Text="Insert" runat="server"
                                OnClick="ButtonInsertTown_Click" />
                            |
                    <asp:DataPager ID="DataPagerCustomers" runat="server" PageSize="5">
                        <Fields>
                            <asp:NextPreviousPagerField ShowFirstPageButton="True"
                                ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            <asp:NumericPagerField />
                            <asp:NextPreviousPagerField ShowLastPageButton="True"
                                ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        </Fields>
                    </asp:DataPager>
                        </td>
                    </tfoot>
                </table>--%>
            </LayoutTemplate>

            <%--<ItemSeparatorTemplate>
                <hr />
            </ItemSeparatorTemplate>--%>
            
            <EmptyDataTemplate>
                <div>No data was returned.</div>
            </EmptyDataTemplate>

            <ItemTemplate> 
                <div class="townContainer">
                    <div>
                        <asp:ImageButton ID="ButtonEditTown" CommandName="Edit" ImageUrl="~/images/edit.png" Width="24px" Height="24" AlternateText="Edit" runat="server" />
                        <asp:ImageButton ID="ButtonDeleteTown" CommandName="Delete" ImageUrl="~/images/delete.png"  Width="24px" Height="24px" AlternateText="Delete" runat="server" />
                    </div>
                    <div>Name: <%#: Item.Name %></div>
                    <div>Population: <%#: Item.Population %></div>
                </div>
            </ItemTemplate>

            <EditItemTemplate>
                <div class="townContainer">
                    <div>
                        <asp:ImageButton ID="ButtonUpdateTown" CommandName="Update" ImageUrl="~/images/update.png" Width="24px" Height="24px" AlternateText="Update" runat="server" />
                        <asp:ImageButton ID="ButtonCancelTown" CommandName="Cancel" ImageUrl="~/images/delete.png"  Width="24px" Height="24px" AlternateText="Cancel" runat="server" />
                    </div>
                    <div>Name:
                             <asp:TextBox ID="TextBoxTownName" runat="server" Text='<%# BindItem.Name %>' />
                    </div>
                    <div>Population:
                             <asp:TextBox ID="TextBoxTonwPopulation" runat="server" Text='<%# BindItem.Population %>' />
                    </div>
                </div>
            </EditItemTemplate>
            <InsertItemTemplate>
                <div>
                    <div class="townContainer">
                        <span>
                            <asp:ImageButton ID="ButtonAddTown" CommandName="Insert" ImageUrl="~/images/add.png" Width="24px" Height="24px" AlternateText="Add" runat="server" />
                            <asp:ImageButton ID="ButtonCancelTown" CommandName="Cancel" ImageUrl="~/images/delete.png"  Width="24px" Height="24px" AlternateText="Cancel" runat="server" />
                        </span>
                        <span>Name:
                                 <asp:TextBox ID="TextBoxTownName" runat="server" Text='<%# BindItem.Name %>' />
                        </span>
                        <span>Population:
                                 <asp:TextBox ID="TextBoxTonwPopulation" runat="server" Text='<%# BindItem.Population %>' />
                        </span>
                        <asp:DropDownList ID="DropDownListCountryInsert" runat="server" DataSourceID="EntityDataSourCountries" 
                                DataTextField="Name" DataValueField="CountryId" SelectedValue="<%#:BindItem.CountryId %>" OnPreRender="DropDownListCountryInsert_PreRender">
                        </asp:DropDownList>
                    </div>
                </div>
            </InsertItemTemplate>
        </asp:ListView>
        

    </form>
</body>
</html>
