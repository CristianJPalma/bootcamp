using Entity.Dtos.BaseDtos;
using Entity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Entity.Context
{
    public class ApplicationDbContext : DbContext
    {

        protected readonly IConfiguration _configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }


        // DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Shift> Shifts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Player)
                .WithOne(p => p.Users)
                .HasForeignKey<Player>(p => p.UserId);

            modelBuilder.Entity<Deck>()
                .HasOne(d => d.Card)
                .WithMany(c => c.Decks)
                .HasForeignKey(d => d.CardId);

            modelBuilder.Entity<Deck>()
                .HasOne(d => d.Player)
                .WithMany(p => p.Decks)
                .HasForeignKey(d => d.PlayerId);

            modelBuilder.Entity<Shift>()
                .HasOne(s => s.Round)
                .WithMany(r => r.Shifts)
                .HasForeignKey(s => s.RoundId);

            modelBuilder.Entity<Round>()
                .HasOne(ro => ro.Rooms)
                .WithMany(r => r.Rounds)
                .HasForeignKey(ro => ro.RoomId);

          

            modelBuilder.Entity<Room>()
               .HasMany(p => p.Rounds)
               .WithOne(r => r.Rooms)
               .HasForeignKey(r => r.RoomId);
        


            modelBuilder.Entity<Card>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Deck>().Property(d => d.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Player>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Room>().Property(r => r.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Round>().Property(ru => ru.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Shift>().Property(s => s.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());





        }
         public override int SaveChanges()
        {
            EnsureAudit();
            return base.SaveChanges();
        }
        private void EnsureAudit()
        {
            ChangeTracker.DetectChanges();
        }
        public void Dispose()
            {

            }
        }
}
