using Dungeon_crawler_improved.Elements;
using System;

namespace Dungeon_crawler_improved
{
    public class Player : LevelElement
    {
        public string Name { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public int Health { get; set; }
        public Dice AttackDice { get; set; } = null!;
        public Dice DefenceDice { get; set; } = null!;
        public int VisionRadius { get; set; } = 5;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            Color = ConsoleColor.Yellow;
            Symbol = '@';
            Name = "Player";
            Health = 100;
            AttackDice = new Dice(2, 6, 2);
            DefenceDice = new Dice(2, 6, 0);
        }
    }
}