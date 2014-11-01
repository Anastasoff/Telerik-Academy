using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Models
{
    public class ChatMessage
    {
        public ChatMessage(string userId, string content)
        {
            this.DatePosted = DateTime.Now;
            this.UserId = userId;
            this.Content = content;
        }

        public ChatMessage()
        {
        }

        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ChatUser User { get; set; }

        [Required]
        public string Content { get; set; }
        public DateTime DatePosted { get; private set; }
    }
}