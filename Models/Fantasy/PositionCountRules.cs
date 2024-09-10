namespace LovchaFantasy.Models.Fantasy
{
    public class PositionCountRules
    {
        public int GameId { get; set; }
        public int PositionId { get; set; }
        public Game Game { get; set; } = new Game();
        public Position Position { get; set; } = new Position();
        public int MaxCount { get; set; }

        public PositionCountRules() { }
        public PositionCountRules(int gameId, int positionId, int maxCount) 
        {
            GameId = gameId;
            PositionId = positionId;
            MaxCount = maxCount;
        }
    }
}
