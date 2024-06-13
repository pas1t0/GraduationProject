using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Position : BaseEntity
    {
        public int RoleId { get; set; }

        public string Title { get; set; } = null!;

        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
    }
}
