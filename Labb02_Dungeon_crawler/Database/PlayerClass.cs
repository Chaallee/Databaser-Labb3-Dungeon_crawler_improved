using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Labb02_Dungeon_crawler.Database
{
    public class PlayerClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}