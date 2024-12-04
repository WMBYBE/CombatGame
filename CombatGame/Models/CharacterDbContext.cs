using Microsoft.EntityFrameworkCore;

namespace CombatGame.Models
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext(DbContextOptions<CharacterDbContext> options) 
            : base(options)
        { }

        public DbSet<Character> Characters { get; set; }

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
        }
    }
}
