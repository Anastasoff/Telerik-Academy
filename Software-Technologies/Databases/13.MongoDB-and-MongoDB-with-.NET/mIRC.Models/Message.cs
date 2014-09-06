namespace mIRC.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    using System;

    public class Message
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string MessageID { get; set; }

        public int MyProperty { get; set; }

        public string Content { get; set; }

        public DateTime SentDate { get; set; }
    }
}