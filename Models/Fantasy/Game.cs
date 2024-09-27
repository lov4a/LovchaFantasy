using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LovchaFantasy.Models.Fantasy
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(1, int.MaxValue, ErrorMessage = "ID не может быть 0.")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public DateOnly Start { get; set; }
        [Required]
        public DateOnly End { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }

        public Game() {
            Points = new HashSet<Points>();
            Leagues = new HashSet<League>();
            UserTeams = new HashSet<UserTeam>();
            GameClubs = new HashSet<GameClubs>();
            PositionCountRules = new HashSet<PositionCountRules>();
        }
        public Game(string name, DateOnly start, DateOnly end, int imageId)
        {

            Name = name;
            Start = start;
            End = end;
            ImageId = imageId;
        }
        public Rules Rules { get; set; } = null!;
        public ICollection<Points> Points { get; set; } = null!;
        public ICollection<League> Leagues { get; set; } = null!;
        public ICollection<UserTeam> UserTeams { get; set; } = null!;
        public ICollection<GameClubs> GameClubs { get; set; } = null!;
        public ICollection<PositionCountRules> PositionCountRules { get; set; } = null!;
    }

}
