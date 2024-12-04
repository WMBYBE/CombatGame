namespace CombatGame.Models
{
    public class Battle
    {
        public int Id { get; set; }
        public int Team1ID { get; set; }
        public int Team2ID { get; set; }
        public Team Team1 {  get; set; }
        public Team Team2 { get; set; }
        public string Result { get; set; }

    }
}
