using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class UserGroupRepo : GenericRepo<UserGroup>
    {
        public UserGroupRepo(ShippingContext db) : base(db)
        { }
    }
}

