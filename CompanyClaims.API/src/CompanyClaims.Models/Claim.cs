using System.ComponentModel.DataAnnotations;

namespace CompanyClaims.Models
{
    public class Claim
    {
        [Required]
        public string UCR { get; set; }

        [Required]
        public int CompanyId { get; set; }

        public Company Company { get; set; }

        [Required]
        public int ClaimTypeId { get; set; }
        public DateTime ClaimDate { get; set; }

        public DateTime LossDate { get; set; }

        [Required]
        public string AssuredName { get; set; }

        public decimal IncurredLoss { get; set; }

        public bool Closed { get; set; } = false;

        public double ClaimAgeInDays
        {
            get => ((int)(DateTime.UtcNow - ClaimDate).TotalDays);
        }
    }
}
