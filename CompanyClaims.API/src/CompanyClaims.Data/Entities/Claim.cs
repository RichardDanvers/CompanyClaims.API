using System.ComponentModel.DataAnnotations;

namespace CompanyClaims.Data.Entities
{
    public class Claim
    {
        string UCR { get; set; }

        int CompanyId { get; set; }

        Company Company { get; set; }

        DateTime ClaimDate { get; set; }

        DateTime LossDate { get; set; }

        [MaxLength(100)]
        string AssuredName { get; set; }

        decimal IncurredLoss { get; set; }

        bool Closed { get; set; }
    }
}

