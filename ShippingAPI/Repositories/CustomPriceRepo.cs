using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class CustomPriceRepo : GenericRepo<CustomPrice>
    {
        public CustomPriceRepo(ShippingContext db) : base(db)
        {
        }
    }
}
