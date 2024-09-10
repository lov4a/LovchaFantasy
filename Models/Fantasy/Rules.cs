using Newtonsoft.Json.Bson;
using System.ComponentModel.DataAnnotations;

namespace LovchaFantasy.Models.Fantasy
{
    public class Rules
    {
        [Key]
        public int GameId { get; private set; }
        public Game Game { get; private set; } = null!;
        public int TeamCount { get; private set; }
        public int OneClubPlayersCount { get; private set; }
        public int GwTransfers { get; private set; }
        public int MaxTransfers { get; private set; }
        public int BenchCount { get; private set; }
        public int MaxUserTeams { get; private set; }
        public double StartBalance { get; private set; }
        public int StartUpGkCount { get; private set; }
        public int StartUpDefCount { get; private set; }
        public int StartUpMidCount { get; private set; }
        public int StartUpFwdCount { get; private set; }
        public Rules() { }
        public Rules(int gameId, int teamCount, int oneClubPlayersCount,
            int gwTransfers, int maxTransfers, int benchCount,
            int maxUserTeams, double startBalance, int startUpGkCount,
            int startUpDefCount, int startUpMidCount, int startUpFwdCount)
        {

            GameId = gameId;
            TeamCount = teamCount;
            OneClubPlayersCount = oneClubPlayersCount;
            GwTransfers = gwTransfers;
            MaxTransfers = maxTransfers;
            BenchCount = benchCount;
            MaxUserTeams = maxUserTeams;
            StartBalance = startBalance;
            StartUpGkCount = startUpGkCount;
            StartUpDefCount = startUpDefCount;
            StartUpMidCount = startUpMidCount;
            StartUpFwdCount = startUpFwdCount;

        }
        public void setGameId(int id) { GameId = id; }
        public void setTeamCount(int count) { TeamCount = count; }
        public void setOneClubPlayersCount(int count) { OneClubPlayersCount = count; }
        public void setMaxTransfers(int count) { MaxTransfers = count; }
        public void setBenchCount(int count) { BenchCount = count; }
        public void setMaxTeams(int count) { MaxUserTeams = count; }
        public void setStartBalance (double startBalance) { StartBalance = startBalance; }

    }
}
