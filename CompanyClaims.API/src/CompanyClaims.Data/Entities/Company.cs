using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyClaims.Data.Entities
{
    public class Company
    {
        int Id { get; set; }

        [MaxLength(200)]
        string Name { get; set; }

        [MaxLength(100)]
        string Address1 { get; set; }

        [MaxLength(100)]
        string Address2 { get; set; }

        [MaxLength(100)]
        string Address3 { get; set; }

        [MaxLength(100)]
        string Postcode { get; set; }

        [MaxLength(50)]
        string Country { get; set; }

        bool Active { get; set; }

        DateTime InsuranceEndDate { get; set; }
    }
}