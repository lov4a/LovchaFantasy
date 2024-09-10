using Microsoft.EntityFrameworkCore;
using LovchaFantasy.Models.Fantasy;
namespace LovchaFantasy.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> games { get; set; } = null!;
        public DbSet<Image> images { get; set; } = null!;
        public DbSet<Rules> rules { get; set; } = null!;
        public DbSet<Actionn> actions { get; set; } = null!;
        public DbSet<Points> points { get; set; } = null!;
        public DbSet<Position> positions { get; set; } = null!;
        public DbSet<League> leagues { get; set; } = null!;
        public DbSet<UserLeagues> userLeagues { get; set; } = null!;
        public DbSet<UserTeam> userTeam { get; set; } = null!;
        public DbSet<GameWeek> gameWeeks { get; set; } = null!;
        public DbSet<UserTeamBalance> userTeamBalances { get; set; } = null!;
        public DbSet<Club> clubs { get; set; } = null!;
        public DbSet<Player> players { get; set; } = null!;
        public DbSet<GameWeekPlayer> gameWeekPlayers { get; set; } = null!;
        public DbSet<GameClubs> gameClubs { get; set; } = null!;
        public DbSet<PositionCountRules> positionCountRules { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(e => e.id);

                entity.Property(e => e.id).IsRequired();

                entity.Property(e => e.name).IsRequired();

                entity.Property(e => e.start).IsRequired();

                entity.Property(e => e.end).IsRequired();

                entity.Property(e => e.imageId).IsRequired();
                entity.HasOne(e => e.Image)
                      .WithMany()
                      .HasForeignKey(e => e.imageId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Image)
                      .WithMany() 
                      .HasForeignKey(e => e.imageId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Rules>(entity =>
            {
                entity.HasKey(e => e.GameId);
                entity.HasOne(e => e.Game)
                      .WithOne(g => g.Rules)
                      .HasForeignKey<Rules>(e => e.GameId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Points>(entity =>
            {
                entity.HasKey(e => new {e.GameId, e.ActionnId, e.PositionId});

                entity.HasOne(e => e.Game)
                      .WithMany(g => g.Points)
                      .HasForeignKey(e => e.GameId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Actionn)
                      .WithMany(a => a.Points)
                      .HasForeignKey(e => e.ActionnId)
                      .OnDelete(DeleteBehavior.Cascade);
                
                entity.HasOne(e => e.Position)
                      .WithMany(g => g.Points)
                      .HasForeignKey(e => e.PositionId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<League>(entity =>
            {
                entity.HasOne(l=>l.Game)
                      .WithMany(g=>g.Leagues)
                      .HasForeignKey(l=>l.GameId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<UserLeagues>(entity =>
            {
                entity.HasKey(ul => new { ul.LeagueId, ul.UserTeamId, ul.GameId});

                entity.HasOne(ul => ul.UserTeam)
                      .WithMany(u => u.UserLeagues)
                      .HasForeignKey(ul => new { ul.UserTeamId, ul.GameId })
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ul => ul.League)
                      .WithMany(l => l.UserLeagues)
                      .HasForeignKey(ul => ul.LeagueId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers");

            modelBuilder.Entity<UserTeam>(entity =>
            {
                entity.HasKey(ut=> new {ut.Id, ut.GameId});

                entity.HasOne(ut=>ut.User)
                      .WithMany(ut=>ut.UserTeams)
                      .HasForeignKey(ut=>ut.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(ut => ut.Game)
                      .WithMany(ut => ut.UserTeams)
                      .HasForeignKey(ut => ut.GameId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserTeamBalance>(entity =>
            {
                entity.HasKey(ut => new { ut.UserTeamId, ut.GameId, ut.GameWeekId });

                entity.HasOne(ut => ut.UserTeam)
                      .WithMany(ut => ut.UserTeamBalances)
                      .HasForeignKey(ut=> new { ut.UserTeamId, ut.GameId })
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(ut => ut.GameWeek)
                      .WithMany(ut => ut.UserTeamBalances)
                      .HasForeignKey(ut => ut.GameWeekId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<GameWeekPlayer>(entity =>
            {
                entity.HasKey(gwp => new { gwp.PlayerId, gwp.GameWeekId });
                entity.HasOne(gwp => gwp.Player)
                      .WithMany(gwp => gwp.GameWeekPlayers)
                      .HasForeignKey(gwp => gwp.PlayerId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(gwp => gwp.GameWeek)
                      .WithMany(gwp => gwp.GameWeekPlayers)
                      .HasForeignKey(gwp => gwp.GameWeekId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(gwp => gwp.Position)
                      .WithMany(gwp => gwp.GameWeekPlayers)
                      .HasForeignKey(gwp => gwp.PositionId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(gwp => gwp.Club)
                      .WithMany(gwp => gwp.GameWeekPlayers)
                      .HasForeignKey(gwp => gwp.ClubId)
                      .OnDelete(DeleteBehavior.SetNull);
            });


            modelBuilder.Entity<GameClubs>(entity =>
            {
                entity.HasKey(gc => new { gc.GameId, gc.ClubId });

                entity.HasOne(gc => gc.Game)
                      .WithMany(gc => gc.GameClubs)
                      .HasForeignKey(gc => gc.GameId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(gc => gc.Club)
                      .WithMany(ut => ut.GameClubs)
                      .HasForeignKey(ut => ut.ClubId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PositionCountRules>(entity =>
            {
                entity.HasKey(pcr=> new {pcr.GameId, pcr.PositionId});

                entity.HasOne(pcr => pcr.Game)
                      .WithMany(pcr => pcr.PositionCountRules)
                      .HasForeignKey(pcr => pcr.GameId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(pcr => pcr.Position)
                      .WithMany(pcr => pcr.PositionCountRules)
                      .HasForeignKey(pcr => pcr.PositionId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
