using System.ComponentModel.DataAnnotations;

namespace CombatGame.Models
{
    public class Moves
    {
        [Key]
        public int MoveId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } //scaling on strength or int?
        public double Power { get; set; } //This is like the multiplier on the attack stat
        public int speed { get; set; } //Strong attacks should attack slower than weaker ones? 

    }
}
