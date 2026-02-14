namespace Dungeon_crawler_improved.GameState
{
    public class PlayerState
    {
        public required string Name { get; set; }
        public required string ClassName { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Health { get; set; }
        public int VisionRadius { get; set; }
    }
}
