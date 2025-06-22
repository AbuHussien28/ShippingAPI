using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.Models
{
    public class UserGroupPermission
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserGroup")]
        public int UserGroupId { get; set; }

        [ForeignKey("Permission")]
        public int PermissionId { get; set; }

        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;

        public virtual UserGroup UserGroup { get; set; } = null!;
        public virtual Permission Permission { get; set; } = null!;
    }
}
