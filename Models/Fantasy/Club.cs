using System.Security.Cryptography.X509Certificates;

namespace LovchaFantasy.Models.Fantasy
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ImageId { get; set; }
        public Image Image { get; set; } = new Image();
        public ICollection<GameWeekPlayer> GameWeekPlayers { get; set; }
        public ICollection<GameClubs> GameClubs { get; set; }

        public Club() {
            GameWeekPlayers = new HashSet<GameWeekPlayer>();
            GameClubs = new HashSet<GameClubs>(); 
        }
        public Club(string name, int imageId)
        {
            Name = name;
            ImageId = imageId;
        }
    }
}
