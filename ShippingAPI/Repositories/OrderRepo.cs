using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class OrderRepo:GenericRepo<Order>
    {
        public OrderRepo(ShippingContext db) : base(db)
        { }
    }
}
