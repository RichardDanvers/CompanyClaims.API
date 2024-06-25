using CompanyClaims.Data.Context;
using CompanyClaims.Data.Entities;

namespace CompanyClaims.Data.Repositories.Interfaces
{
    public interface ICompanyRepository
    {
        public Task<Company> GetCompanyByName(string companyName);
    }
}
