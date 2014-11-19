namespace ForumSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using ForumSystem.Data.Common.Models;

    public class Vote : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public int UpVotes { get; set; }

        public int DownVotes { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public bool IsDeleted { get; set; }

        public System.DateTime? DeletedOn { get; set; }
    }
}