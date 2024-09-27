namespace LovchaFantasy.Models.Fantasy
{
    public class GameWeekPlayer
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int GameWeekId {  get; set; }
        public GameWeek GameWeek { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; } = new Position();
        public int? ClubId { get; set; }
        public Club? Club { get; set; } = new Club();
        public double Price { get; set; }
        public ICollection<UserTeamGameWeekPlayer> UserTeamGameWeekPlayers { get; set; }
        public GameWeekPlayer() {
            UserTeamGameWeekPlayers = new HashSet<UserTeamGameWeekPlayer>();
        }
        public GameWeekPlayer(int playerId, int gameWeekId, int positionId, int clubId, double price)
        {
            PlayerId = playerId;
            GameWeekId = gameWeekId;
            PositionId = positionId;
            ClubId = clubId;
            Price = price;
        }
    }
}
