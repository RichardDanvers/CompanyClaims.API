using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyClaims.Data.Entities
{
    public class Claim
    {
        [Key]
        public string UCR { get; set; }

        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [ForeignKey(nameof(ClaimType))]
        public int ClaimTypeId { get; set; }
        public ClaimType ClaimType { get; set; }

        public DateTime ClaimDate { get; set; }

        public DateTime LossDate { get; set; }

        [MaxLength(100)]
        public string AssuredName { get; set; }

        public decimal IncurredLoss { get; set; }

        public bool Closed { get; set; }
    }
}

