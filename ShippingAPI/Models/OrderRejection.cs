using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.Models
{
    public class OrderRejection
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("RejectionReason")]
        public int RejectionReasonId { get; set; }

        public DateTime RejectedAt { get; set; } = DateTime.UtcNow;

        public string? Notes { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual RejectionReason RejectionReason { get; set; } = null!;
    }
}
