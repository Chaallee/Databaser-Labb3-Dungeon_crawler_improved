using Dungeon_crawler_improved;
using Dungeon_crawler_improved.Database;
using Dungeon_crawler_improved.GameState;
using MongoDB.Driver;
using System;
using System.Linq;

public class Program
{
    public static readonly Random GlobalRandom = new Random();
    private const string ConnectionString = "mongodb://localhost:27017";

    static void Main()
    {
        Console.CursorVisible = false;

        var context = new MongoContext(ConnectionString);
        var repository = new GameStateRepository(context);

        DatabaseSeeder.SeedPlayerClasses(context);

        ShowMainMenu(context, repository);
    }

    static ConsoleColor GetClassColor(string className)
    {
        return className switch
        {
            "Warrior" => ConsoleColor.Red,
            "Wizard" => ConsoleColor.Blue,
            "Rogue" => ConsoleColor.Green,
            _ => ConsoleColor.White
        };
    }

    static void ShowMainMenu(MongoContext context, GameStateRepository repository)
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("=== DUNGEON CRAWLER ===\n");
            Console.ResetColor();
            Console.Write("Select option by pressing one of the following keys:\n");
            Console.WriteLine("\n1. New Game");
            Console.WriteLine("2. Continue Game");
            Console.WriteLine("3. Delete Saved Game");
            Console.WriteLine("4. Exit");

            var key = Console.ReadKey(true);

            switch (key.KeyChar)
            {
                case '1':
                    StartNewGame(context, repository);
                    break;
                case '2':
                    ContinueGame(repository);
                    break;
                case '3':
                    DeleteSavedGame(repository);
                    break;
                case '4':
                    return;
            }
        }
    }

    static void StartNewGame(MongoContext context, GameStateRepository repository)
    {
        Console.Clear();

        Console.Write("Enter your name: ");
        Console.CursorVisible = true;
        string? playerName = Console.ReadLine();
        Console.CursorVisible = false;

        var classes = context.PlayerClasses.Find(_ => true).ToList();
        Console.WriteLine("\nChoose your class:");

        for (int i = 0; i < classes.Count; i++)
        {
            Console.ForegroundColor = GetClassColor(classes[i].Name);
            Console.WriteLine($"{i + 1}. {classes[i].Name}");
            Console.ResetColor();
        }

        Console.Write("\nSelect class (1-3): ");

        int classIndex = -1;
        while (classIndex == -1)
        {
            var classKey = Console.ReadKey(true);
            classIndex = classKey.KeyChar switch
            {
                '1' => 0,
                '2' => 1,
                '3' => 2,
                _ => -1
            };
        }
        Console.WriteLine();

        string className = classes[classIndex].Name;

        var level = new LevelData();
        level.Load("Levels/Level1.txt");
        var player = level.Player;
        player.Name = playerName ?? "Unknown";
        player.ClassName = className;

        Console.Clear();
        Console.Write("Welcome, ");
        Console.ForegroundColor = GetClassColor(className);
        Console.Write(player.Name);
        Console.Write(" the ");
        Console.Write(className);
        Console.ResetColor();
        Console.WriteLine("!");

        Console.WriteLine("\nControls: WASD or Arrow Keys to move, Spacebar to stand still, ESC to save and exit");
        Console.WriteLine("\nPress any key to start...");
        Console.ReadKey(true);

        var loop = new GameLoop(level, player, repository);
        loop.Run();
    }

    static void ContinueGame(GameStateRepository repository)
    {
        if (!repository.Exists())
        {
            Console.WriteLine("\nNo saved game found!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            return;
        }

        var state = repository.Load();
        if (state == null)
        {
            Console.WriteLine("\nFailed to load saved game!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            return;
        }

        var level = GameStatePersistence.Load(state);
        var player = level.Player;

        Console.Clear();
        Console.Write("Welcome back, ");
        Console.ForegroundColor = GetClassColor(player.ClassName);
        Console.Write(player.Name);
        Console.Write(" the ");
        Console.Write(player.ClassName);
        Console.ResetColor();
        Console.WriteLine("!");

        Console.WriteLine($"Turn: {level.TurnCounter}, Health: {player.Health}");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        var context = new MongoContext(ConnectionString);
        var repository2 = new GameStateRepository(context);
        var loop = new GameLoop(level, player, repository2);
        loop.Run();
    }

    static void DeleteSavedGame(GameStateRepository repository)
    {
        if (!repository.Exists())
        {
            Console.WriteLine("\nNo saved game to delete!");
        }
        else
        {
            repository.Delete();
            Console.WriteLine("\nSaved game deleted!");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}