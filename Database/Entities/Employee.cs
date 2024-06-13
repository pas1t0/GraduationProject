using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Database.Entities
{
    public class Employee : BaseEntity
    {
        public int UserId { get; set; }

        public int PositionId { get; set; }

        [ForeignKey(nameof(UserId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public User User { get; set; }

        [ForeignKey(nameof(PositionId))]
        public Position Position { get; set; }
    }
}
