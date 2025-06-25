using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class CommissionSettingRepo:GenericRepo<CommissionSetting>
    {
        public CommissionSettingRepo(ShippingContext db) : base(db)
        {
        }
    
    }
}
