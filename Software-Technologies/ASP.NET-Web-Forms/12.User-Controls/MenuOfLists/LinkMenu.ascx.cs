namespace MenuOfLists
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Web.UI;

    public partial class LinkMenu : UserControl
    {
        public IEnumerable<MenuOption> MenuItems
        {
            get
            {
                return (IEnumerable<MenuOption>)this.DataListBox.DataSource;
            }

            set
            {
                this.DataListBox.DataSource = value;
            }
        }

        public Color FontColor
        {
            get
            {
                return this.DataListBox.ForeColor;
            }

            set
            {
                this.DataListBox.ForeColor = value;
            }
        }

        public string FontFamily
        {
            get
            {
                return this.DataListBox.Font.ToString();
            }

            set
            {
                this.DataListBox.Style.Add("font-family", value);
            }
        }

        public override void DataBind()
        {
            this.DataListBox.DataBind();

            base.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            foreach (var item in this.MenuItems)
            {
                item.FontColor = this.FontColor;
            }

            this.DataBind();
        }
    }
}