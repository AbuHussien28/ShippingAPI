using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShippingAPI.DTOS
{
    public class cityidDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;


        [Required]
        [StringLength(100)]
        public string GoverrateName { get; set; }


        [Column(TypeName = "Money")]
        public decimal PricePerKg { get; set; }
    }
}
