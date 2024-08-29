namespace LovchaFantasy.Models.Fantasy
{
    public class Points
    {
        public int GameId { get; private set; }
        public int ActionnId { get; private set; }
        public Game Game { get; private set; } = null!;
        public Actionn Actionn { get; private set; } = null!;
        public int PositionId { get; private set; }
        public Position Position { get; private set; }
        public int Point {  get; private set; }
        public Points() { }
        public Points(int gameId, int actionnId, int positionId,int point)
        {
            GameId = gameId;
            ActionnId = actionnId;
            PositionId = positionId;
            Point = point;
        }
        public void setGameId(int gameId) { GameId = gameId; }
        public void setActionnId(int actionnId) { ActionnId = actionnId; }
        public void setPositionId(int positionId) { PositionId = positionId; }
        public void setPoint(int point) { Point = point; }
    }
}
