using Chat.Data;
using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chat.Infrastructure;
using System.Diagnostics;
using System.Web.Security;

namespace Chat.Messages
{
    public partial class Chat : System.Web.UI.Page
    {
        private ChatDbContext db = new ChatDbContext();
        private IUserIdProvider id = new AspNetUserIdProvider();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public bool IsAdmin() 
        {
            var isinrole = HttpContext.Current.User.IsInRole("Administrator");
            if (isinrole)
            {
                this.LatestMessages.FindControl("thDeleteButton").Visible = true;
            }

            return isinrole;
        }

        public bool IsModerator()
        {
            var isinrole = HttpContext.Current.User.IsInRole("Moderator") || 
                           HttpContext.Current.User.IsInRole("Administrator") ;
           
            if (isinrole)
            {
                this.LatestMessages.FindControl("thEditButton").Visible = true;
            }

            return isinrole;
        }


        public IQueryable LatestMessages_GetData()
        {
            
            var messages = this.db.ChatMessages.OrderByDescending(x => x.DatePosted).Take(20);
            return messages;
        }

        protected void PostNewMessage_Click(object sender, EventArgs e)
        {
            var guid = this.id.GetUserId();
            string content = this.NewChatMessage.Text;
            ChatMessage newMsg = new ChatMessage(guid, content);

            this.db.ChatMessages.Add(newMsg);
            this.db.SaveChanges();
            Response.Redirect("~/Messages/Chat");
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void LatestMessages_DeleteItem(int id)
        {
            var msg = this.db.ChatMessages.Find(id);
            this.db.ChatMessages.Remove(msg);
            this.db.SaveChanges();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void LatestMessages_UpdateItem(int id)
        {
            ChatMessage item = null;
            item = this.db.ChatMessages.Find(id);
            
            if (item == null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                db.SaveChanges();
            }
        }
    }
}