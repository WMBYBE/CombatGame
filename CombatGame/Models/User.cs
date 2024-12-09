namespace CombatGame.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } //login with email not required so lets omit it
        public string Password { get; set; }
        public List<Team> Teams { get; set; } = new List<Team>();
        public int TotalWins { get; set; } //tracking for badges or achievements or whatever

    }
}
