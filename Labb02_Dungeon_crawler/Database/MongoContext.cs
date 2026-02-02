using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Labb02_Dungeon_crawler.Database
{
    public class MongoContext
    {
        private const string DatabaseName = "CharlieCarlegrund";
        private readonly IMongoDatabase database;

        public MongoContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase(DatabaseName);

            EnsureCollectionsExist();
        }

        public IMongoCollection<BsonDocument> PlayerClasses =>
            database.GetCollection<BsonDocument>("playerClasses");

        public IMongoCollection<BsonDocument> SaveGames =>
            database.GetCollection<BsonDocument>("saveGames");

        private void EnsureCollectionsExist()
        {
            var existingCollections = database
                .ListCollectionNames()
                .ToList();

            if (!existingCollections.Contains("playerClasses"))
                database.CreateCollection("playerClasses");

            if (!existingCollections.Contains("saveGames"))
                database.CreateCollection("saveGames");
        }
    }
}