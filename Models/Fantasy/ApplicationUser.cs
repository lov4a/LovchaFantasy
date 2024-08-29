using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LovchaFantasy.Models.Fantasy
{
    [Table("AspNetUsers")]
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserTeam> UserTeams { get; set; }
        public ApplicationUser() {
            UserTeams = new HashSet<UserTeam>();
        }
    }
}
