using System.ComponentModel.DataAnnotations;

namespace ShippingAPI.DTOS
{
    public class governrateDTO
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;


        [Required]
        [StringLength(100)]
        public string RegionName { get; set; } = string.Empty;
    }
}
