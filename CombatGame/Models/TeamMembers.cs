using System.ComponentModel.DataAnnotations;

namespace CombatGame.Models
{
    public class TeamMembers
    {
        [Key]
        public int TeamMemberid { get; set; }
        public int CharacterId { get; set; }
        public int TeamId { get; set; }
        public Character character { get; set; }
    }
}
