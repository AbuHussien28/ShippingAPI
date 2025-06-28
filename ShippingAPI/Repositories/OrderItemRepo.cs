using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class OrderItemRepo : GenericRepo<OrderItem>
    {
        public OrderItemRepo(ShippingContext db) : base(db)
        {
        }
    }
}
