using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShippingAPI.Models;

namespace ShippingAPI.Data
{
    public class ShippingContext: IdentityDbContext<ApplicationUser>
    {
        public ShippingContext()
        {
            
        }
        public ShippingContext(DbContextOptions<ShippingContext> options)
            : base(options)
        {
        }
        public DbSet<Branch> Branches { get; set; } 
        public DbSet<City> Cities { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<Bank> Banks { get; set; } 
        public DbSet<CommissionSetting> CommissionSettings{ get; set; }
        public DbSet<CustomPrice> CustomPrices { get; set; }
        public DbSet<ExtraVillagePrice> ExtraVillagePrice { get; set; }
        public DbSet<FinancialTransfer> FinancialTransfers { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<OrderRejection> OrderRejection{ get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RejectionReason> RejectionReasons { get; set; }
        public DbSet<Safe> Safe { get; set; }
        public DbSet<ShippingType> ShippingTypes { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserGroupPermission> RegioUserGroupPermissions { get; set; }
        public DbSet<Weight> Weights { get; set; }

    }
}
