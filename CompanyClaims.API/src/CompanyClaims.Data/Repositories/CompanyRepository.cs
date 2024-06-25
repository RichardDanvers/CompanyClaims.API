using CompanyClaims.Data.Context;
using CompanyClaims.Data.Entities;
using CompanyClaims.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CompanyClaims.Data.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyClaimsDbContext _dbContext;

        public CompanyRepository(CompanyClaimsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Company> GetCompanyByName(string companyName) => 
            await _dbContext.Companies.FirstOrDefaultAsync(x => x.Name == companyName);
    }
}
