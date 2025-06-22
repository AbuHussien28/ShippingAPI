using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.Models
{
    public class UserGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string GroupName { get; set; } = string.Empty;

        [ForeignKey("User")]
        public string UserId { get; set; } = string.Empty;

        public virtual ApplicationUser User { get; set; } = null!;
        public virtual ICollection<UserGroupPermission> UserGroupPermissions { get; set; } = new List<UserGroupPermission>();
    }
}
