using System.ComponentModel.DataAnnotations;

namespace ShippingAPI.DTOS
{
    public class regionidDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]

        public List<string> governrateName { get; set; }
    }
}
