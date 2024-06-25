using CompanyClaims.Models;

namespace CompanyClaims.Service.Interfaces
{
    internal interface ICompanyService
    {
        Task<Company> GetCompanyByName(string companyName);
    }
}
