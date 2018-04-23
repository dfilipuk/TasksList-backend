using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApiDemo.Models
{
    public class MyTask
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("number")]
        public int Number { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("author")]
        public string Author { get; set; }

        [BsonElement("priority")]
        public string Priority { get; set; }
    }
}