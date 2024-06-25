using CompanyClaims.Data.Context;
using CompanyClaims.Data.Entities;

namespace CompanyClaims.Data.Repositories.Interfaces
{
    public interface ICompanyRepository
    {
        Task<Company> GetCompanyByName(string companyName);
    }
}
