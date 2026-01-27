using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
namespace Labb02_Dungeon_crawler.Database
{
    public class MongoContext
    {
        public MongoContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("CharlieCarlegrund");

            var collection = database.GetCollection<BsonDocument>("test");

            var document = new BsonDocument
            {
                { "test123", "MongoDB test" }
            };

            collection.InsertOne(document);

            var result = collection.Find(new BsonDocument()).FirstOrDefault();


            Console.WriteLine("test resultat:");
            Console.WriteLine(result?.ToString());
        }
    }
}