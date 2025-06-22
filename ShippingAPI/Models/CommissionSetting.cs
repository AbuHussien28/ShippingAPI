using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingAPI.Models
{
    public class CommissionSetting
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal CompanyShare { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal DelegateShare { get; set; }
        public CommissionType CommissionType { get; set; } = CommissionType.Percentage;
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

        public decimal CalculateCompanyCommission(decimal totalAmount)
        {
            return CommissionType == CommissionType.Percentage
                ? totalAmount * (CompanyShare / 100)
                : CompanyShare;
        }

        public decimal CalculateDelegateCommission(decimal totalAmount)
        {
            return CommissionType == CommissionType.Percentage
                ? totalAmount * (DelegateShare / 100)
                : DelegateShare;
        }
    }

    public enum CommissionType
    {
        [Display(Name = "Percentage")]
        Percentage = 1,  

        [Display(Name = "FixedAmount")]
        FixedAmount = 2  
    }
}
