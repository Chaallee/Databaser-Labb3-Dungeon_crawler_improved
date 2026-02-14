using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dungeon_crawler_improved.Database
{
    public class PlayerClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public required string Name { get; set; }
    }
}