using CompanyClaims.Data.Context;

namespace CompanyClaims.API.Configuration
{
    public static class SeedDatabase
    {
        public static void Seed(CompanyClaimsDbContext dbContext)
        {
            var claimType1 = new Data.Entities.ClaimType
            {
                Id = 1,
                Name = "Marine"
            };

            var claimType2 = new Data.Entities.ClaimType
            {
                Id = 2,
                Name = "Health"
            };

            var claimType3 = new Data.Entities.ClaimType
            {
                Id = 3,
                Name = "Home"
            };

            dbContext.ClaimTypes.Add(claimType1);
            dbContext.ClaimTypes.Add(claimType2);
            dbContext.ClaimTypes.Add(claimType3);

            var company1 = new Data.Entities.Company
            {
                Id = 1,
                Name = "TestCompany",
                Active = true,
                Address1 = "Test line 1",
                Address2 = "Test line 2",
                Address3 = "Test line 3",
                Country = "England",
                InsuranceEndDate = null,
                Postcode = "BD21TEST"
            };

            dbContext.Companies.Add(company1);


            var claim1 = new Data.Entities.Claim
            {
                UCR = "ABDFGFIWS123",
                AssuredName = "TestClaim1",
                ClaimDate = DateTime.UtcNow,
                ClaimTypeId = 1,
                Closed = false,
                CompanyId = 1
            };

            var claim2 = new Data.Entities.Claim
            {
                UCR = "ABDFGFIWS126",
                AssuredName = "TestClaim2",
                ClaimDate = DateTime.UtcNow.AddDays(-150),
                ClaimTypeId = 2,
                Closed = false,
                CompanyId = 1
            };

            dbContext.Claims.Add(claim1);
            dbContext.Claims.Add(claim2);

            dbContext.SaveChanges();
        }
    }
}
