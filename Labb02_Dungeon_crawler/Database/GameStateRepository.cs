using MongoDB.Driver;
using Labb02_Dungeon_crawler.GameState;

namespace Labb02_Dungeon_crawler.Database
{
    public class GameStateRepository
    {
        private readonly IMongoCollection<GameState.GameState> collection;

        public GameStateRepository(MongoContext context)
        {
            collection = context.GameStates;
        }

        public void Save(GameState.GameState state)
        {
            collection.DeleteMany(_ => true);
            collection.InsertOne(state);
        }

        public GameState.GameState Load()
        {
            return collection.Find(_ => true).FirstOrDefault();
        }

        public bool Exists()
        {
            return collection.CountDocuments(_ => true) > 0;
        }

        public void Delete()
        {
            collection.DeleteMany(_ => true);
        }
    }
}