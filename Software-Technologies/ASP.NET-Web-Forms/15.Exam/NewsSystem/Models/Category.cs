using System.Collections.Generic;
namespace NewsSystem.Models
{
    public class Category
    {
        private ICollection<Article> articles;
        public Category()
        {
            this.articles = new HashSet<Article>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Article> Articles
        {
            get
            {
                return this.articles;
            }

            set
            {
                this.articles = value;
            }
        }
    }
}