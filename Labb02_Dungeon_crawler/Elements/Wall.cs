using System;

namespace Labb02_Dungeon_crawler.Elements
{
    public class Wall : LevelElement
    {
        public Wall(int x, int y) : base(x, y, ConsoleColor.Gray, '#')
        {
        }
    }
}

