using System.ComponentModel.DataAnnotations;

namespace CompanyClaims.Data.Entities
{
    public class ClaimType
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }
    }
}
