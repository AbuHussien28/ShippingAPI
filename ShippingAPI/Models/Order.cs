using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey("City")]
        public int CityId { get; set; }

        [ForeignKey("Branch")]
        public int? BranchId { get; set; }

        [ForeignKey("ShippingType")]
        public int ShippingTypeId { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Weight { get; set; }

        [Column(TypeName = "Money")]
        public decimal TotalCost { get; set; }

        public string? Notes { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;
        public virtual City City { get; set; } = null!;
        public virtual Branch? Branch { get; set; }
        public virtual ShippingType ShippingType { get; set; } = null!;
        public virtual ICollection<OrderRejection> OrderRejections { get; set; } = new List<OrderRejection>();
    }
    public enum OrderStatus
    {
        Pending = 1,
        Confirmed = 2,
        InTransit = 3,
        Delivered = 4,
        Rejected = 5,
        Cancelled = 6
    }
}
