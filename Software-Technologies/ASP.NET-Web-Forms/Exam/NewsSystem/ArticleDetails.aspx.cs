using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSystem.Models;

namespace NewsSystem
{
    public partial class ArticleDetails : System.Web.UI.Page
    {
        private NewsDbContext db;

        public ArticleDetails()
        {
            this.db = new NewsDbContext();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public NewsSystem.Models.Article FormViewArticles_GetItem([QueryString("id")]int? id)
        {
            if (id == null)
            {
                this.Response.Redirect("~/");
            }

            return this.db.Articles.FirstOrDefault(a => a.Id == id);
        }
    }
}