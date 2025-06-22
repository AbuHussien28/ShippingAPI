using Microsoft.AspNetCore.Identity;

namespace ShippingAPI.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? CurrentToken { get; set; }
        public DateTime? TokenExpiration { get; set; }
    }
}
