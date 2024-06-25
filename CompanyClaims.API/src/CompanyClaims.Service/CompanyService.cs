using CompanyClaims.Models;
using CompanyClaims.Service.Interfaces;

namespace CompanyClaims.Service
{
    public class CompanyService : ICompanyService
    {
        public Task<Company> GetCompanyByName(string companyName)
        {
            throw new NotImplementedException();
        }
    }
}
