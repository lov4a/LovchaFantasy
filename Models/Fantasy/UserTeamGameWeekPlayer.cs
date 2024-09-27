namespace LovchaFantasy.Models.Fantasy
{
    public class UserTeamGameWeekPlayer
    {
        public int UserTeamId { get; private set; }
        public int GameId { get; private set; }
        public UserTeam UserTeam { get; private set; } = null!;
        public int PlayerId { get; private set; }
        public int GameWeekId { get; private set; }
        public GameWeekPlayer GameWeekPlayer {get; private set;} = null!;
        public bool Captain { get; private set; }
        public bool ViceCaptain { get; private set; }
        public bool Bench {  get; private set; }
        public UserTeamGameWeekPlayer() { }
        public UserTeamGameWeekPlayer(int userTeamId, int gameId, int playerId, int gameWeekId, bool captain, bool viceCaptain, bool bench ) 
        {
            UserTeamId = userTeamId;
            GameId = gameId;
            PlayerId = playerId;
            GameWeekId = gameWeekId;
            Captain = captain;
            ViceCaptain = viceCaptain;
            Bench = bench;
        }
    }
}
