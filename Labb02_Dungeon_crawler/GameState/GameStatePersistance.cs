using Dungeon_crawler_improved.Elements;

namespace Dungeon_crawler_improved.GameState
{
    public static class GameStatePersistence
    {
        public static GameState Save(LevelData level)
        {
            return new GameState
            {
                Player = new PlayerState
                {
                    Name = level.Player.Name,
                    ClassName = level.Player.ClassName,
                    X = level.Player.X,
                    Y = level.Player.Y,
                    Health = level.Player.Health,
                    VisionRadius = level.Player.VisionRadius
                },
                Enemies = level.Elements
                    .OfType<Enemy>()
                    .Select(enemy => new EnemyState
                    {
                        EnemyType = enemy.GetType().Name,
                        X = enemy.X,
                        Y = enemy.Y,
                        Health = enemy.Health
                    }).ToList(),
                DiscoveredWalls = level.DiscoveredWalls
                    .Select(position => new WallState { X = position.X, Y = position.Y })
                    .ToList(),
                TurnCounter = level.TurnCounter
            };
        }

        public static LevelData Load(GameState state)
        {
            var level = new LevelData();
            level.Load("Levels/Level1.txt");

            var player = level.Player;
            player.Name = state.Player.Name;
            player.ClassName = state.Player.ClassName;
            player.X = state.Player.X;
            player.Y = state.Player.Y;
            player.Health = state.Player.Health;
            player.VisionRadius = state.Player.VisionRadius;

            foreach (var enemy in level.GetAllEnemies())
                level.MarkForRemoval(enemy);

            level.RemoveDeadEnemies();

            foreach (var enemyState in state.Enemies)
            {
                Enemy? enemy = enemyState.EnemyType switch
                {
                    "Rat" => new Rat(enemyState.X, enemyState.Y),
                    "Snake" => new Snake(enemyState.X, enemyState.Y),
                    _ => null
                };

                if (enemy != null)
                {
                    enemy.TakeDamage(enemy.Health - enemyState.Health);
                    level.AddElement(enemy);
                }
            }

            foreach (var wall in state.DiscoveredWalls)
                level.AddDiscoveredWall(new Position(wall.X, wall.Y));

            while (level.TurnCounter < state.TurnCounter)
                level.IncrementTurn();

            return level;
        }
    }
}