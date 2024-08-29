namespace LovchaFantasy.Models.Fantasy
{
    public class Position
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string ShortName { get; private set; } = null!;
        public Position() {
            Points = new HashSet<Points>();
            GameWeekPlayers = new HashSet<GameWeekPlayer>();
        }
        public Position(int id, string name, string shortName) { Id = id; Name = name; ShortName = shortName; }
        public void setName(string name) { Name = name; }
        public void setShortName(string shortName) { ShortName = shortName; }
        public ICollection<Points> Points { get; set; }
        public ICollection<GameWeekPlayer> GameWeekPlayers { get; set; }
    }
}
