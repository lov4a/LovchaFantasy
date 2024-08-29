namespace LovchaFantasy.Models.Components
{
    public class SquadForm
    {
        public List<Footballer> GoalKeepers { get; set; } = new List<Footballer>();
        public List<Footballer> Defenders { get; set; } = new List<Footballer>();
        public List<Footballer> Midfilders{ get; set; } = new List<Footballer>();
        public List<Footballer> Forwards { get; set; } = new List<Footballer>();
        public List<Footballer> FullSquad
        {
            get
            {
                return GoalKeepers.Concat(Defenders)
                                  .Concat(Midfilders)
                                  .Concat(Forwards)
                                  .ToList();
            }
        }

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

    }
}
