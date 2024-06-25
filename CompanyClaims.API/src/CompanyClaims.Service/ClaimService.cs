using AutoMapper;
using CompanyClaims.Data.Repositories.Interfaces;
using CompanyClaims.Service.Interfaces;
using System.Security.Claims;

namespace CompanyClaims.Service
{
    public class ClaimService : IClaimService
    {
        //todo: remember to set getter on newly mapped entity for age of claim (in days)
        private readonly IClaimRepository _claimRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public ClaimService(IClaimRepository claimRepository, IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }

        public async Task<Claim> GetClaimByUCR(string uniqueClaimReference)
        {
            var claim = await _claimRepository.GetClaimByUCR(uniqueClaimReference);

            return _mapper.Map<Claim>(claim);
        }

        public async Task<List<Claim>> GetClaimsByCompanyName(string companyName)
        {
            var company = await _companyRepository.GetCompanyByName(companyName);

            var claims = await _claimRepository.GetClaimsByCompanyId(company.Id);

            return _mapper.Map<List<Claim>>(claims);
        }

        public async Task<Claim> UpdateClaim(Claim claim)
        {
            var updatedClaim = await _claimRepository.UpdateClaim(_mapper.Map<Data.Entities.Claim>(claim));

            return _mapper.Map<Claim>(updatedClaim);
        }
    }
}
