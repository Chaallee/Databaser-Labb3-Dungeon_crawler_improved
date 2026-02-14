using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

using Labb02_Dungeon_crawler.GameState;

namespace Labb02_Dungeon_crawler.Database
{
    public class MongoContext
    {
        private readonly IMongoDatabase database;

        public MongoContext(string connectionString)
        {
            var client = new MongoClient(connectionString);
            database = client.GetDatabase("CharlieCarlegrund");
        }

        public IMongoCollection<GameState.GameState> GameStates =>
            database.GetCollection<GameState.GameState>("GameStates");

        public IMongoCollection<PlayerClass> PlayerClasses =>
            database.GetCollection<PlayerClass>("PlayerClasses");
    }
}