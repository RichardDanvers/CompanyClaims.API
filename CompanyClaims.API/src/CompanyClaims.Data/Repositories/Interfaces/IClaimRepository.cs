using CompanyClaims.Data.Entities;

namespace CompanyClaims.Data.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        public Task<IEnumerable<Claim>> GetClaimsByCompanyId(int companyId);
        public Task<Claim> GetClaimByUCR(string ucr);
        public Task<Claim> UpdateClaim(Claim claim);
    }
}
