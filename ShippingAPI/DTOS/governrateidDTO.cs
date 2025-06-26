using System.ComponentModel.DataAnnotations;

namespace ShippingAPI.DTOS
{
    public class governrateidDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;


        [Required]
        [StringLength(100)]
        public string RegionName { get; set; } = string.Empty;
    }
}
