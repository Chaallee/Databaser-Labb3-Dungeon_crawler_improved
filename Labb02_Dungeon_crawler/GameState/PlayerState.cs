using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb02_Dungeon_crawler.GameState
{
    public class PlayerState
    {
        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int Health { get; set; }
        public int VisionRadius { get; set; }

    }
}
