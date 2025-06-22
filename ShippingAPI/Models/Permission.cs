using System.ComponentModel.DataAnnotations;

namespace ShippingAPI.Models
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Description { get; set; }

        public virtual ICollection<UserGroupPermission> UserGroupPermissions { get; set; } = new List<UserGroupPermission>();
    }
}
