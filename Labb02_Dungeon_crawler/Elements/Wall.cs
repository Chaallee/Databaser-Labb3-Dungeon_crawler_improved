using System;

namespace Dungeon_crawler_improved.Elements
{
    public class Wall : LevelElement
    {
        public Wall(int x, int y) : base(x, y, ConsoleColor.Gray, '#')
        {
        }
    }
}

