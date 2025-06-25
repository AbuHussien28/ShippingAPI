using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class UserGroupPermissionRepo:GenericRepo<UserGroupPermission>
    {
        public UserGroupPermissionRepo(ShippingContext db) : base(db)
        {
        }
    }
    
}
