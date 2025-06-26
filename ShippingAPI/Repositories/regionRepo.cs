using ShippingAPI.Data;
using ShippingAPI.Models;


namespace ShippingAPI.Repositories
{
    public class regionRepo : GenericRepo<Region>
    {
        public regionRepo(ShippingContext db) : base(db)
        { }
        public Region? getByName(string name)
        {
            return db.Regions.Where(r => r.Name.ToLower() == name.ToLower()).FirstOrDefault();
        }

    }
}
