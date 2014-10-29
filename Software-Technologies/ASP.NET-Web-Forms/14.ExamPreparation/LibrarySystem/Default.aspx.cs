namespace LibrarySystem
{
    using LibrarySystem.Data;
    using System;
    using System.Linq;
    using System.Web.UI;

    public partial class _Default : Page
    {
        private LibrarySystemDbContext db;

        public _Default()
        {
            this.db = new LibrarySystemDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var categories = db.Categories.ToList();
                this.ListViewBooks.DataSource = categories;
                this.ListViewBooks.DataBind();
            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string keyword = this.TextBoxSearch.Text;
            this.Response.Redirect("~/Search.aspx?q=" + keyword);
        }
    }
}