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
    public partial class Books : System.Web.UI.Page
    {
        private LibrarySystemDbContext db;

        public Books()
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
        public IQueryable<LibrarySystem.Data.Models.Book> GridViewBooks_GetData()
        {
            return this.db.Books.OrderBy(b => b.Id);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_UpdateItem(int id)
        {
            var item = this.db.Books.Find(id);
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();
                this.db.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_DeleteItem(int id)
        {
            Book item = this.db.Books.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            this.db.Books.Remove(item);
            this.db.SaveChanges();
        }

        protected void LinkButtonInsert_Click(object sender, EventArgs e)
        {
            this.btnWrapper.Visible = false;

            var fv = this.UpdatePanelInsertBook.FindControl("FormViewInsertBook") as FormView;
            fv.Visible = true;
        }

        public void FormViewInsertBook_InsertItem()
        {
            var item = new LibrarySystem.Data.Models.Book();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here
                this.db.Books.Add(item);
                this.db.SaveChanges();
            }
        }

        public IQueryable<Category> DropDownListCategoriesCreate_GetData()
        {
            return this.db.Categories.OrderBy(b => b.Name);
        }
    }
}