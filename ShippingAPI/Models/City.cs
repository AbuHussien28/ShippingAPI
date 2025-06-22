using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey("Governorate")]
        public int GovernorateId { get; set; }

        public bool IsVillage { get; set; } = false;

        [Column(TypeName = "Money")]
        public decimal PricePerKg { get; set; }

        public virtual Governorate Governorate { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
    }
}
