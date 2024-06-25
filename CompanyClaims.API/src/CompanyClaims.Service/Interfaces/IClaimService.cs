using CompanyClaims.Models;

namespace CompanyClaims.Service.Interfaces
{
    public interface IClaimService
    {
        public Task<List<Claim>> GetClaimsByCompanyName(string companyName);
        public Task<Claim> GetClaimByUCR(string uniqueClaimReference);

        public Task<Claim> UpdateClaim(Claim claim);
    }
}
