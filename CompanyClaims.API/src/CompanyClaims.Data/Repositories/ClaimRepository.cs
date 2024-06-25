using CompanyClaims.Data.Context;
using CompanyClaims.Data.Entities;
using CompanyClaims.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CompanyClaims.Data.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly CompanyClaimsDbContext _dbContext;

        public ClaimRepository(CompanyClaimsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Claim> GetClaimByUCR(string ucr) =>
            await _dbContext.Claims.FirstOrDefaultAsync(x => x.UCR == ucr);

        public async Task<IEnumerable<Claim>> GetClaimsByCompanyId(int companyId)
            => await _dbContext.Claims.Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<Claim> UpdateClaim(Claim claim)
        {
            var existingClaim = await GetClaimByUCR(claim.UCR) 
                ?? throw new NullReferenceException($"Claim with UCR: {claim.UCR} could not be found.");

            SetClaimProperties(claim, existingClaim);
            await _dbContext.SaveChangesAsync();

            return claim;
        }

        private void SetClaimProperties(Claim claim, Claim existingClaim)
        {
            existingClaim.AssuredName = claim.AssuredName;
            existingClaim.ClaimDate = claim.ClaimDate;
            existingClaim.LossDate = claim.LossDate;
            existingClaim.CompanyId = claim.CompanyId;
            existingClaim.Closed = claim.Closed;
            existingClaim.IncurredLoss = claim.IncurredLoss;
        }
    }
}
