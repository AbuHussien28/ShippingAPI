using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.Models
{
    public class ExtraVillagePrice
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "Money")]
        public decimal Value { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}
