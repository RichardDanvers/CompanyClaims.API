using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyClaims.Data.Entities
{
    internal class Company
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