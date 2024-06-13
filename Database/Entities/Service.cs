using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Service : BaseEntity
    {
        public int CategoryId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public string? ImagePath { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
