using System.ComponentModel.DataAnnotations;

namespace ShippingAPI.DTOS
{
    public class regoinDTO
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
    
        public List<string> governrateName { get; set; }
    }
}
