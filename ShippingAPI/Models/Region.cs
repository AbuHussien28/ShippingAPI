using System.ComponentModel.DataAnnotations;

namespace ShippingAPI.Models
{
    public class Region
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Governorate> Governorates { get; set; } = new List<Governorate>();
    }

}
