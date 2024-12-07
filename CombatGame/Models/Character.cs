﻿namespace CombatGame.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Defense { get; set; }
        public List<Moves> Moves { get; set; } = new List<Moves>();
        //not sure if we should do characters are added directly to a team or you make characters and
        //can select to add them to a team
        public int teamId { get; set; }
        public Team Team { get; set; }
    }
}
