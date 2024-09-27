using LovchaFantasy.Context.Migrations;

namespace LovchaFantasy.Models.Components
{
    public class SquadForm
    {
        public List<Footballer> TeamPlayers { get; set; }  = new List<Footballer>();
        public Dictionary<int, int> OneTeamPlayers = new Dictionary<int, int>();
        public Dictionary<int, int> OnePositionPlayers = new Dictionary<int, int>();
        public double TeamCost { get; set; }

    }
    public class Footballer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? PositionId { get; set; }
        public double? Price { get; set; }
        public string? ImagePath { get; set; }
        public int? ClubId { get; set; }
        public bool Captain { get; set; }
        public bool ViceCaptain { get; set; }

    }
}
