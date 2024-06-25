using CompanyClaims.Models;

namespace CompanyClaims.Service.Interfaces
{
    public interface ICompanyService
    {
        public Task<Company> GetCompanyByName(string companyName);
    }
}
