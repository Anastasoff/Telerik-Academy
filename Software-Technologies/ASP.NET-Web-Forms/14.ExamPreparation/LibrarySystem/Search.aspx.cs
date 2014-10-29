using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibrarySystem.Data;
using System.Web.ModelBinding;

namespace LibrarySystem
{
    public partial class Search : System.Web.UI.Page
    {
        private LibrarySystemDbContext db;

        public Search()
        {
            this.db = new LibrarySystemDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<LibrarySystem.Data.Models.Book> RepeaterBooks_GetData([QueryString("q")]string query)
        {

            if (string.IsNullOrWhiteSpace(query))
            {
                return this.db.Books.ToList();
            }
            else
            {
                var keyword = query.ToLower();
                return this.db.Books
                    .Where(b => b.Title.ToLower().Contains(keyword) || b.Author.ToLower().Contains(keyword))
                    .OrderBy(b => b.Title)
                    .ToList();
            }
        }
    }
}