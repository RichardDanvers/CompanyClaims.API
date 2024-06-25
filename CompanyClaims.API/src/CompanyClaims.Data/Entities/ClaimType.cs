using System.ComponentModel.DataAnnotations;

namespace CompanyClaims.Data.Entities
{
    public class ClaimType
    {
        int Id { get; set; }

        [MaxLength(20)]
        string Name { get; set; }
    }
}
