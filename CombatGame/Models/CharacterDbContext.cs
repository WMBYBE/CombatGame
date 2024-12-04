using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace CombatGame.Models
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext(DbContextOptions<CharacterDbContext> options) 
            : base(options)
        { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Moves> Moves { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1,
                    Name = "Dave",
                    HP = 10,
                    Strength = 20,
                    Agility = 10,
                    Intelligence = 7,
                    teamId = 1
                },
                 new Character
                {
                    Id = 2,
                    Name = "Tony",
                    HP = 5,
                    Strength = 5,
                    Agility = 8,
                    Intelligence = 25,
                    teamId = 1
                 },
                 new Character
                 {
                    Id = 3,
                    Name = "Peter Griffin",
                    HP = 5,
                    Strength = 5,
                    Agility = 25,
                    Intelligence = 5,
                    teamId = 1
                 },
                 new Character
                 {
                     Id = 1,
                     Name = "Kyle",
                     HP = 10,
                     Strength = 7,
                     Agility = 10,
                     Intelligence = 20,
                     teamId = 2
                 },
                 new Character
                 {
                     Id = 2,
                     Name = "Terry",
                     HP = 5,
                     Strength = 25,
                     Agility = 8,
                     Intelligence = 5,
                     teamId = 2
                 },
                 new Character
                 {
                     Id = 3,
                     Name = "Matt",
                     HP = 5,
                     Strength = 8,
                     Agility = 25,
                     Intelligence = 5,
                     teamId = 2
                 }
                );
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "Boston Beaters",
                    UserId = 1,
                    TotalWins = 0
                },
                new Team
                {
                    Id = 2,
                    Name = "Das Boyyen",
                    UserId = 2,
                    TotalWins = 10
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    userId = 1,
                    UserName = "NYnumb1",
                    Password = "321",
                    TotalWins = 0
                },
                new User
                {
                    userId = 2,
                    UserName = "GERno1",
                    Password = "123",
                    TotalWins = 10
                }
                );
        }
    }
}
