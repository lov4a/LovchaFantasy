namespace LovchaFantasy.Models.Fantasy
{
    public class GameClubs
    {
        public int GameId { get; private set; }
        public int ClubId { get; private set; }
        public Game Game { get; private set; } = new Game();
        public Club Club { get; private set; } = new Club();
        public GameClubs() { }
        public GameClubs(int gameId, int clubId)
        {
            GameId = gameId;
            ClubId = clubId;
        }
    }
}
