using Microsoft.AspNetCore.Identity;

namespace LovchaFantasy.Models.Fantasy
{
    public class UserLeagues
    {
        public int LeagueId { get; private set; }
        public int UserTeamId { get; private set; }
        public int GameId { get; private set; }
        public League League { get; private set; } = new League();
        public UserTeam UserTeam { get; private set; } = new UserTeam();
        public UserLeagues(int leagueId, int userTeamId, int gameId)
        {
            LeagueId = leagueId;
            UserTeamId = userTeamId;
            GameId = gameId;
        }
    }
}
