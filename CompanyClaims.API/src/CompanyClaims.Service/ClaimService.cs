using CompanyClaims.Service.Interfaces;
using System.Security.Claims;

namespace CompanyClaims.Service
{
    public class ClaimService : IClaimService
    {
        public Claim GetClaimByUCR(string uniqueClaimReference)
        {
            throw new NotImplementedException();
        }

        public List<Claim> GetClaimsByCompanyName(string companyName)
        {
            throw new NotImplementedException();
        }

        public Claim UpdateClaim(Claim claim)
        {
            throw new NotImplementedException();
        }
    }
}
