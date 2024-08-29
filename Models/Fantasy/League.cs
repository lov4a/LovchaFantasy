namespace LovchaFantasy.Models.Fantasy
{
    public class League
    {
        public int Id { get; private set; }
        public int GameId { get; private set; }
        public Game Game { get; private set; }
        public string Name { get; private set; } = null!;
        public string Code { get; private set; } = null!;
        public bool Main { get; private set; }
        public ICollection<UserLeagues> UserLeagues { get; set; }

        public League() {
            UserLeagues = new HashSet<UserLeagues>();
        }
        public League(int id, int gameId, string name, string code) {
            Id = id;
            GameId = gameId;
            Name = name;
            Code = code;
            UserLeagues = new HashSet<UserLeagues>();
        }
        public void setName(string name)
        {
            Name = name;
        }

    }
}
