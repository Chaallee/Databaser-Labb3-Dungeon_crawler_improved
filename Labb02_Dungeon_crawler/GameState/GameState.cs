using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb02_Dungeon_crawler.GameState
{
    public class GameState
    {
        public PlayerState Player { get; set; }
        public List<EnemyState> Enemies { get; set; }
        public List<WallState> DiscoveredWalls { get; set; }
        public int TurnCounter { get; set; }
    }
}
