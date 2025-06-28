using Microsoft.EntityFrameworkCore;
using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class OrderRepo:GenericRepo<Order>
    {
        public OrderRepo(ShippingContext db) : base(db){ }

        public Order getByIdWithObj(int id)
        {
            return db.Orders.Include(o=>o.City).Include(o=>o.Governorate).Include(o=>o.TraderProfile)
                .Include(o=>o.RejectionReason).Include(o=>o.Branch).FirstOrDefault(o=>o.Id == id);
        }

    }
}
