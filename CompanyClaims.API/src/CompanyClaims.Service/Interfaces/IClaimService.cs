using System.Security.Claims;

namespace CompanyClaims.Service.Interfaces
{
    internal interface IClaimService
    {
        List<Claim> GetClaimsByCompanyName(string companyName);
        Claim GetClaimByUCR(string uniqueClaimReference);

        Claim UpdateClaim(Claim claim);
    }
}
