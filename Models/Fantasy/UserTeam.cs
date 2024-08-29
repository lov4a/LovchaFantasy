using System.ComponentModel.DataAnnotations;

namespace LovchaFantasy.Models.Fantasy
{
    public class UserTeam
    {
        public int Id { get; private set; }
        public int GameId { get; private set; }
        public string UserId { get; private set; }
        public ApplicationUser User { get; private set; } = new ApplicationUser();
        public Game Game { get; private set; } = new Game();
        public ICollection<UserLeagues> UserLeagues { get; set; }
        public ICollection<UserTeamBalance> UserTeamBalances { get; set; }

        public UserTeam() { 
            UserLeagues = new HashSet<UserLeagues>();
            UserTeamBalances = new HashSet<UserTeamBalance>();
        }
        public UserTeam(int id, int gameId, string userId) 
        {
            Id = id;
            GameId = gameId;
            UserId = userId;
        }


    }
}
