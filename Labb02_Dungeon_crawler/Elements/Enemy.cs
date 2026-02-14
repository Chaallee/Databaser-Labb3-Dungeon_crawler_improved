using System;

namespace Dungeon_crawler_improved.Elements
{
    public abstract class Enemy : LevelElement
    {
        public string Name { get; protected set; } = string.Empty;
        public int Health { get; protected set; }
        public Dice AttackDice { get; protected set; } = null!;
        public Dice DefenceDice { get; protected set; } = null!;

        protected Enemy(int x, int y, ConsoleColor color, char symbol, string name, int health, Dice attackDice, Dice defenceDice)
            : base(x, y, color, symbol)
        {
            Name = name;
            Health = health;
            AttackDice = attackDice;
            DefenceDice = defenceDice;
        }

        public abstract void EnemyWalkUpdate(LevelData level, Player player);

        public void TakeDamage(int damageTaken)
        {
            Health -= damageTaken;
        }

        public bool IsDead()
        {
            return Health <= 0;
        }
    }
}