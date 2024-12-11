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
        public DbSet<TeamMembers> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    CharacterId = 1,
                    Name = "Dave",
                    HP = 10,
                    Strength = 20,
                    Agility = 10,
                    Intelligence = 7,
                    Defense = 10,
                    moveId = 1
                },
                 new Character
                 {
                     CharacterId = 2,
                     Name = "Tony",
                     HP = 5,
                     Strength = 5,
                     Agility = 8,
                     Intelligence = 25,
                     Defense = 10,
                     moveId = 1
                 },
                 new Character
                 {
                     CharacterId = 3,
                     Name = "Peter Griffin",
                     HP = 5,
                     Strength = 5,
                     Agility = 25,
                     Intelligence = 5,
                     Defense = 10,
                     moveId = 1
                 },
                 new Character
                 {
                     CharacterId = 4,
                     Name = "Kyle",
                     HP = 10,
                     Strength = 7,
                     Agility = 10,
                     Intelligence = 20,
                     Defense = 10,
                     moveId = 1
                 },
                 new Character
                 {
                     CharacterId = 5,
                     Name = "Terry",
                     HP = 5,
                     Strength = 25,
                     Agility = 8,
                     Intelligence = 5,
                     Defense = 10,
                     moveId = 1
                 },
                 new Character
                 {
                     CharacterId = 6,
                     Name = "Matt",
                     HP = 5,
                     Strength = 8,
                     Agility = 25,
                     Intelligence = 5,
                     Defense = 10,
                     moveId = 1
                 }
                );
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "Boston Beaters",
                    UserId = 1,
                    TotalWins = 0
                },
                new Team
                {
                    TeamId = 2,
                    Name = "Das Boyyen",
                    UserId = 2,
                    TotalWins = 10
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    UserName = "NYnumb1",
                    Password = "321",
                    TotalWins = 0
                },
                new User
                {
                    UserId = 2,
                    UserName = "GERno1",
                    Password = "123",
                    TotalWins = 10
                }
                );
            modelBuilder.Entity<Moves>().HasData(
                new Moves
                {
                    MoveId = 1,
                    Name = "Attack",
                    Description = "Basic attack",
                    Type = "Physical",
                    Power = 1,
                    speed = 1
                }
                );
            modelBuilder.Entity<TeamMembers>().HasData(
                new TeamMembers
                {
                    TeamMemberid = 1,
                    CharacterId = 1,
                    TeamId = 1
                },
                new TeamMembers
                {
                    TeamMemberid = 2,
                    CharacterId = 2,
                    TeamId = 1
                },
                 new TeamMembers
                 {
                     TeamMemberid = 3,
                     CharacterId = 3,
                     TeamId = 1
                 },
                 new TeamMembers
                 {
                     TeamMemberid = 4,
                     CharacterId = 4,
                     TeamId = 2
                 },
                 new TeamMembers
                 {
                     TeamMemberid = 5,
                     CharacterId = 5,
                     TeamId = 2
                 },
                 new TeamMembers
                 {
                     TeamMemberid = 6,
                     CharacterId = 6,
                     TeamId = 2
                 }
                );
        }
    }
}
