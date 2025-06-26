using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.DTOS
{
    public class cityDTO
    {

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
