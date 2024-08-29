using System.ComponentModel.DataAnnotations;

namespace LovchaFantasy.Models.Fantasy
{
    public class Actionn
    {
        [Key]
        public int Id { get;private set; }
        [Required]
        public string Name { get; private set; } = null!;
        public Actionn() {
            Points = new HashSet<Points>();
        }
        public Actionn(int id, string name) { Id = id; Name = name; }
        public void setName (string name) { Name = name; }
        public ICollection<Points> Points { get; set; }
    }



}
