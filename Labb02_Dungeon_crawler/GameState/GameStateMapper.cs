using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb02_Dungeon_crawler.GameState
{
    public static class GameStateMapper
    {
        public static GameState MapFromLevel(LevelData level)
        {
            var state = new GameState
            {
                Player = MapPlayer(level.Player),
                Enemies = MapEnemies(level),
                DiscoveredWalls = MapWalls(level),
                TurnCounter = level.TurnCounter
            };

            return state;
        }

        private static PlayerState MapPlayer(Player player)
        {
 
        }

        private static List<EnemyState> MapEnemies(LevelData level)
        {

        }

        private static List<WallState> MapWalls(LevelData level)
        {

        }

        private static DiceState MapDice(Dice dice)
        {

        }
    }
}