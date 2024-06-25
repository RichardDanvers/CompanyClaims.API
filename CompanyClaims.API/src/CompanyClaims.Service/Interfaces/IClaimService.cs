using System.Security.Claims;

namespace CompanyClaims.Service.Interfaces
{
    public interface IClaimService
    {
        Task<List<Claim>> GetClaimsByCompanyName(string companyName);
        Task<Claim> GetClaimByUCR(string uniqueClaimReference);

        Task<Claim> UpdateClaim(Claim claim);
    }
}
