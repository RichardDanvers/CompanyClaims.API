using CompanyClaims.Data.Entities;

namespace CompanyClaims.Data.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        Task<IEnumerable<Claim>> GetClaimsByCompanyId(int companyId);
        Task<Claim> GetClaimByUCR(string ucr);
        Task<Claim> UpdateClaim(Claim claim);
    }
}
