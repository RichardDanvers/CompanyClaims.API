using CompanyClaims.Data.Context;
using CompanyClaims.Data.Repositories;
using CompanyClaims.Data.Repositories.Interfaces;
using CompanyClaims.Service;
using CompanyClaims.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CompanyClaims.API.Configuration
{
    public static class RegisterServices
    {
        public static void Register(this IServiceCollection services)
        {
            //Register services
            services.AddTransient<IClaimService, ClaimService>();
            services.AddTransient<ICompanyService, CompanyService>();

            //Register repositories
            services.AddScoped<IClaimRepository, ClaimRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();

            var inMemoryOptions = new DbContextOptionsBuilder<CompanyClaimsDbContext>()
                .UseInMemoryDatabase("CompanyClaimsTest")
                .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                .Options;

            services.AddDbContext<CompanyClaimsDbContext>(options =>
                options.UseInMemoryDatabase("CompanyClaimsTest")
                .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning)));
        }
    }
}
