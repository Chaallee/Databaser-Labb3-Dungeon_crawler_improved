using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Labb02_Dungeon_crawler.GameState
{
    public class GameState
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public PlayerState Player { get; set; }
        public List<EnemyState> Enemies { get; set; }
        public List<WallState> DiscoveredWalls { get; set; }
        public int TurnCounter { get; set; }
    }
}