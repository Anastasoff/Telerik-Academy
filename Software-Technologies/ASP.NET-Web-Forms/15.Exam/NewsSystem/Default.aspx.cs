namespace NewsSystem
{
    using NewsSystem.Models;
    using System;
    using System.Linq;
    using System.Web.UI;

    public partial class _Default : Page
    {
        private NewsDbContext db;

        public _Default()
        {
            this.db = new NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

            }
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Category> ListViewCategories_GetData()
        {
            return this.db.Categories;
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Article> ListViewPopularArticles_GetData()
        {
            return this.db.Articles.OrderBy(a => a.Id).Take(3);
        }
    }
}