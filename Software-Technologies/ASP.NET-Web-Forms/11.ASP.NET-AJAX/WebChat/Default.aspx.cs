namespace WebChat
{
    using System;
    using System.Linq;
    using WebChat.Data;

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            var currentUser = this.ViewState["username"];
            if (currentUser != null)
            {
                this.TextBoxUsername.Text = currentUser.ToString();
            }

            var db = new WebChatDbContext();

            var messages = db.Messages.OrderBy(m => m.Created).Take(100).ToList();

            this.ListViewMessages.DataSource = messages;
            this.ListViewMessages.DataBind();
        }

        protected void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            string msgText = this.TextAreaNewMessage.InnerText;
            string username = this.TextBoxUsername.Text;
            this.ViewState["username"] = username;

            var db = new WebChatDbContext();

            var message = new Message()
            {
                Username = username,
                Content = msgText,
                Created = DateTime.Now
            };

            db.Messages.Add(message);
            db.SaveChanges();
            this.ListViewMessages.DataBind();
            this.TextBoxUsername.Text = username;
            this.TextAreaNewMessage.InnerText = string.Empty;
        }
    }
}