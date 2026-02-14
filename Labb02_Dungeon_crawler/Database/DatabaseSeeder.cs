using MongoDB.Driver;

namespace Labb02_Dungeon_crawler.Database
{
    public static class DatabaseSeeder
    {
        public static void SeedPlayerClasses(MongoContext context)
        {
            if (context.PlayerClasses.CountDocuments(_ => true) > 0)
                return;

            var classes = new[]
            {
                new PlayerClass { Name = "Warrior" },
                new PlayerClass { Name = "Wizard" },
                new PlayerClass { Name = "Rogue" }
            };

            context.PlayerClasses.InsertMany(classes);
        }
    }
}