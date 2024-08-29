namespace LovchaFantasy.Models.Components
{
    public class AddGameForm
    {
        public string Name { get; set; } = null!;
        public DateOnly Start {  get; set; }
        public DateOnly End { get; set; }
        public int TeamCount { get; set; }
        public int OneClubPlayers { get; set; }
        public int GwTransfers { get; set; }
        public int MaxTransfrs { get; set; }
        public int Bench { get; set; }
        public bool TimePoints { get; set; }
        public int MaxUserTeams { get; set; }
        public double StartBalance { get; set; }
        public int GkCount { get; set; }
        public int StartUpGkCount { get; set; }
        public int DefCount { get; set; }
        public int StartUpDefCount { get; set; }
        public int MidCount { get; set; }
        public int StartUpMidCount { get; set; }
        public int FwdCount { get; set; }
        public int StartUpFwdCount { get; set; }

        public List<ActionScore> ActionScores { get; set; } = new List<ActionScore>();
    }
    public class ActionScore
    {
        public int ActionId { get; set; }
        public int PositionId { get; set; }
        public int Score { get; set; }
    }
}
