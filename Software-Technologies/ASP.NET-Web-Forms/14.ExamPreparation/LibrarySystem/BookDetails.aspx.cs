namespace LibrarySystem
{
    using LibrarySystem.Data;
    using LibrarySystem.Data.Models;
    using System;
    using System.Linq;
    using System.Web.ModelBinding;

    public partial class BookDetails : System.Web.UI.Page
    {
        private LibrarySystemDbContext db;

        public BookDetails()
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
        public IQueryable<Book> ListViewBook_GetData([QueryString("id")]int? id)
        {
            if (id == null)
            {
                this.Response.Redirect("~/");
            }

            var book = db.Books.Where(b => b.Id == id);
            return book;
        }
    }
}