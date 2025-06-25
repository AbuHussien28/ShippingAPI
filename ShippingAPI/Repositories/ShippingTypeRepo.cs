using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class ShippingTypeRepo : GenericRepo<ShippingType>
    {
        public ShippingTypeRepo(ShippingContext db) : base(db)
        { }
    }
}
