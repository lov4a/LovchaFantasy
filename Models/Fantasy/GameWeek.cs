using System.ComponentModel.DataAnnotations;

namespace LovchaFantasy.Models.Fantasy
{
    public class GameWeek
    {
        [Key]
        public int Id { get; private set; }
        public int Number { get; private set; }
        public int GameId { get; private set; }
        public Game Game { get; private set; } = new Game();
        public DateTime Deadline { get; private set; }
        public DateTime Start {  get; private set; }
        public bool? Completed { get; private set; }
        public ICollection<UserTeamBalance> UserTeamBalances { get; set; }
        public ICollection<GameWeekPlayer> GameWeekPlayers { get; set; }

        public GameWeek()
        {
            UserTeamBalances = new HashSet<UserTeamBalance>();
            GameWeekPlayers = new HashSet<GameWeekPlayer>();
        }
        public GameWeek(int number, int gameId, DateTime deadline, DateTime start, bool completed)
        {
            Number = number;
            GameId = gameId;
            Deadline = deadline;
            Start = start;
            Completed = completed;
        }

        public void SetDeadLine(DateTime time) { Deadline = time; }
        public void SetStart(DateTime time){ Start = time; }
        public void SetCompleted(bool completed) { Completed = completed; }
    }
}
