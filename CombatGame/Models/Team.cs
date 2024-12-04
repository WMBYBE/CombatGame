namespace CombatGame.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public List<Character>? Characters { get; set; } = new List<Character>();
        public int TotalWins { get; set; } //badge or achiement tracker for that team comp
    }
}
