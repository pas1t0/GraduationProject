using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Request : BaseEntity
    {
        public int UserId { get; set; }

        public int ServiceId { get; set; }

        public int? EmployeeId { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime ServeTime { get; set; }

        public DateTime? ServedTime { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsPayed { get; set; }

        public string Address { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
