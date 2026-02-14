using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Dungeon_crawler_improved.GameState
{
    public class GameState
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public required PlayerState Player { get; set; }
        public required List<EnemyState> Enemies { get; set; }
        public required List<WallState> DiscoveredWalls { get; set; }
        public int TurnCounter { get; set; }
    }
}