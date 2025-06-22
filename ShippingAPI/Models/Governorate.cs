using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.Models
{
    public class Governorate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey("Region")]
        public int RegionId { get; set; }

        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<City> Cities { get; set; } = new List<City>();
    }
}
