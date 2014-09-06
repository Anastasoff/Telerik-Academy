namespace mIRC.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    using System;

    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserID { get; set; }

        public string Name { get; set; }

        public DateTime LastLogin { get; set; }
    }
}