using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LovchaFantasy.Data
{
	public class AppplicationDbContext : IdentityDbContext
	{
		public AppplicationDbContext(DbContextOptions<AppplicationDbContext> options)
			: base(options)
		{
		}
	}
}
