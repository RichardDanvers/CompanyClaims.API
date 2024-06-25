using CompanyClaims.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyClaims.Data.Context
{
    public class CompanyClaimsDbContext : DbContext
    {
        public DbSet<Claim> Claims => Set<Claim>();
        public DbSet<ClaimType> ClaimTypes => Set<ClaimType>();
        public DbSet<Company> Companies => Set<Company>();
    }
}
