using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSystem.Models;
using System.Web.ModelBinding;

namespace NewsSystem.Admin
{
    public partial class Articles : System.Web.UI.Page
    {
        private NewsDbContext db;

        public Articles()
        {
            this.db = new NewsDbContext();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSystem.Models.Article> ListViewArticles_GetData()
        {
            return this.db.Articles.OrderBy(a => a.Id);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_UpdateItem(int id)
        {
            var item = this.db.Articles.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.db.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_DeleteItem(int id)
        {
            var item = this.db.Articles.Find(id);
            this.db.Articles.Remove(item);
            this.db.SaveChanges();
        }

        public IQueryable<Category> DropDownListInsertCategories_GetData()
        {
            return this.db.Categories.OrderBy(b => b.Name);
        }

        public IQueryable<Category> DropDownListEditArticlesCategory_GetData()
        {
            return this.db.Categories.OrderBy(b => b.Name);
        }

        protected void LinkButtonInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/InsertArticle");
        }

    }
}