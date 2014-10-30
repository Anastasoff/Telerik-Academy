using NewsSystem.Models;
using System;
using System.Linq;

namespace NewsSystem.Admin
{
    public partial class InsertArticle : System.Web.UI.Page
    {
        private NewsDbContext db;

        public InsertArticle()
        {
            this.db = new Models.NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void FormViewIsertArticle_InsertItem()
        {
            var item = new NewsSystem.Models.Article();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here
            }
        }

        public IQueryable<Category> DropDownListInsertCategories_GetData()
        {
            return this.db.Categories.OrderBy(b => b.Name);
        }
    }
}