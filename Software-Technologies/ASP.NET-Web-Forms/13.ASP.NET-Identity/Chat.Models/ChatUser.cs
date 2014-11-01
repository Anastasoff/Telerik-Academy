using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Chat.Models
{
    public class ChatUser : IdentityUser
    {
        private ICollection<ChatMessage> messages;

        public ChatUser()
        {
            this.messages = new HashSet<ChatMessage>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<ChatMessage> Messages 
        { 
            get 
            {
                // TODO : return
                return new HashSet<ChatMessage>(messages);
            }
            set
            {
                this.messages = value;
            }
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ChatUser> manager)
        {
            return Task.FromResult(this.GenerateUserIdentity(manager));
        }

        public ClaimsIdentity GenerateUserIdentity(UserManager<ChatUser> manager)
        {
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}