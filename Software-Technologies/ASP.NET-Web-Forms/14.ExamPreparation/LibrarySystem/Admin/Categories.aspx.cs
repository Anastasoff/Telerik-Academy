using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibrarySystem.Data;
using LibrarySystem.Data.Models;

namespace LibrarySystem.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        private LibrarySystemDbContext db;

        public Categories()
        {
            this.db = new LibrarySystemDbContext();
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
        public IQueryable<LibrarySystem.Data.Models.Category> ListViewCategories_GetData()
        {
            return this.db.Categories.OrderBy(c => c.Id);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_DeleteItem(int id)
        {
            var item = this.db.Categories.Find(id);
            this.db.Categories.Remove(item);
            this.db.SaveChanges();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_UpdateItem(int id)
        {
            var item = this.db.Categories.Find(id);
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

        public void ListViewCategories_InsertItem()
        {
            var item = new Category();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.db.Categories.Add(item);
                this.db.SaveChanges();
            }
        }

        protected void LinkButtonAddNewCategory_Command(object sender, CommandEventArgs e)
        {
            var categoryName = this.TextBoxCategoryName.Text;
            var newCategory = new Category()
            {
                Name = categoryName
            };

            this.db.Categories.Add(newCategory);
            this.db.SaveChanges();
            this.Response.Redirect(@"~/Admin/Categories.aspx");
        }
    }
}