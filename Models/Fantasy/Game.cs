using System.ComponentModel.DataAnnotations;

namespace LovchaFantasy.Models.Fantasy
{
    public class Game
    {
        [Key]
        private int Id { get; set; }
        [Required]
        private string Name { get; set; } = null!;
        [Required]
        private DateOnly Start;
        [Required]
        private DateOnly End;
        public int imageId { get; set; }
        public Image Image { get; set; }

        public Game() {
            Points = new HashSet<Points>();
            Leagues = new HashSet<League>();
            UserTeams = new HashSet<UserTeam>();
            GameClubs = new HashSet<GameClubs>();
            PositionCountRules = new HashSet<PositionCountRules>();
        }
        public Game(int id, string name, DateOnly start, DateOnly end, int ImageId)
        {

            Id = id;
            Name = name;
            Start = start;
            End = end;
            imageId = ImageId;
            Points = new HashSet<Points>();
            Leagues = new HashSet<League>();
            UserTeams = new HashSet<UserTeam>();
        }
        public int id
        {
            get => Id;
            private set => Id = value;
        }
        public string name
        {
            get => Name;
            set => Name = value;
        }
        public DateOnly start
        {
            get => Start;
            set => Start = value;
        }
        public DateOnly end
        {
            get => End;
            set => End = value;
        }
        public Rules Rules { get; set; } = null!;
        public ICollection<Points> Points { get; set; }
        public ICollection<League> Leagues { get; set; }
        public ICollection<UserTeam> UserTeams { get; set; }
        public ICollection<GameClubs> GameClubs { get; set; }
        public ICollection<PositionCountRules> PositionCountRules { get; set; }
    }

}
