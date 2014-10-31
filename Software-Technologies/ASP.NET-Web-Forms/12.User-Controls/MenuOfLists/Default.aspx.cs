namespace MenuOfLists
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;

    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var items = new List<MenuOption>()
            {
                new MenuOption("Telerik Academy", "http://telerikacademy.com/"),
                new MenuOption("Telerik Academy Forums", "http://forums.academy.telerik.com/")
            };

            this.LinkMenuItems.MenuItems = items;
            this.LinkMenuItems.DataBind();
        }
    }
}