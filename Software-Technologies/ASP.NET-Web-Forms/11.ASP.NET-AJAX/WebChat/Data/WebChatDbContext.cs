namespace WebChat.Data
{
    using System.Data.Entity;

    public class WebChatDbContext : DbContext
    {
        public WebChatDbContext()
            : base("WebChatDb")
        {
        }

        public IDbSet<Message> Messages { get; set; }
    }
}