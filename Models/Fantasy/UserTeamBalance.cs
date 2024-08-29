namespace LovchaFantasy.Models.Fantasy
{
    public class UserTeamBalance
    {
        public int UserTeamId { get; private set; }
        public int GameId { get; private set; }
        public int GameWeekId { get; private set; }
        public UserTeam UserTeam { get; private set; } = new UserTeam();
        public GameWeek GameWeek { get; private set; } = new GameWeek();
        public double Balance { get; private set; }

        public UserTeamBalance() { }
        public UserTeamBalance(int userTeamid, int gameId, int gameWeekId, double balance) {
            UserTeamId = userTeamid;
            GameId = gameId;
            GameWeekId = gameWeekId;
            Balance = balance;
        }
        public void SetBalance(double balance)
        {
            Balance = Balance;
        }
    }
}
