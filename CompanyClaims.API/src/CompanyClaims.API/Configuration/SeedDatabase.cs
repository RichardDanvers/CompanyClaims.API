using CompanyClaims.Data.Context;

namespace CompanyClaims.API.Configuration
{
    public static class SeedDatabase
    {
        public static void Seed(CompanyClaimsDbContext dbContext)
        {
            dbContext.Companies.Add(new Data.Entities.Company
            {
                Id = 1,
                Name = "test",
                Active = true
            });

            dbContext.SaveChanges();

            var x = dbContext.Companies.ToList();
        }
    }
}
