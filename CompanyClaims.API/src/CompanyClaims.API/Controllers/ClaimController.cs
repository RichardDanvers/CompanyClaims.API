using CompanyClaims.Models;
using CompanyClaims.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CompanyClaims.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _claimService;

        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }

        [HttpGet("{UCR}")]
        [ProducesResponseType(typeof(Claim), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Get(string UCR)
        {
            if (string.IsNullOrWhiteSpace(UCR)) return BadRequest("Unique claim reference (UCR) must be provided");

            var claim = await _claimService.GetClaimByUCR(UCR);

            if (claim == null) return NotFound($"Could not find claim with unique claim reference: {UCR}");

            return Ok(claim);
        }

        [HttpGet("GetByCompany/{companyName}")]
        [ProducesResponseType(typeof(List<Claim>), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByCompanyName(string companyName)
        {
            if (string.IsNullOrWhiteSpace(companyName)) return BadRequest("Company name must be provided");

            var claim = await _claimService.GetClaimsByCompanyName(companyName);

            if (claim == null || !claim.Any()) return NotFound($"No claims found for company: {companyName}");

            return Ok(claim);
        }

        [HttpPatch]
        [ProducesResponseType(typeof(Claim), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> UpdateClaim(Claim claim)
        {
            try
            {
                var updatedClaim = await _claimService.UpdateClaim(claim);

                return Ok(updatedClaim);
            }
            catch(NullReferenceException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
