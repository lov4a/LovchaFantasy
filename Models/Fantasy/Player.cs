using System.ComponentModel.DataAnnotations;

namespace LovchaFantasy.Models.Fantasy
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int? ImageId { get; set; }
        public Image Image { get; set; } = new Image();
        public ICollection<GameWeekPlayer> GameWeekPlayers { get; set; }
        public Player() { 
            GameWeekPlayers = new HashSet<GameWeekPlayer>();
        }
        public Player(string name, string surname) {
            Name = name;
            Surname = surname;
        }
    }
}
