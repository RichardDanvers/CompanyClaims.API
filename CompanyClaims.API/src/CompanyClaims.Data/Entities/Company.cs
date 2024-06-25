using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyClaims.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Address1 { get; set; }

        [MaxLength(100)]
        public string Address2 { get; set; }

        [MaxLength(100)]
        public string Address3 { get; set; }

        [MaxLength(100)]
        public string Postcode { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        public bool Active { get; set; }

        public DateTime InsuranceEndDate { get; set; }
    }
}