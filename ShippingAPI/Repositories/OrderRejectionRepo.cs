using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class OrderRejectionRepo:GenericRepo<OrderRejection>
    {
        public OrderRejectionRepo(ShippingContext db) : base(db)
        { }
    }
}
