using System.ComponentModel.DataAnnotations;

namespace CompanyClaims.Data.Entities
{
    public class Claim
    {
        public string UCR { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public DateTime ClaimDate { get; set; }

        public DateTime LossDate { get; set; }

        [MaxLength(100)]
        public string AssuredName { get; set; }

        public decimal IncurredLoss { get; set; }

        public bool Closed { get; set; }
    }
}

