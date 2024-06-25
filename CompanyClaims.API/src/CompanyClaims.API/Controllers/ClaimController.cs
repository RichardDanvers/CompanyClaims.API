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

        [HttpGet]
        public async Task<IActionResult> Get(string UCR)
        {
            if (string.IsNullOrWhiteSpace(UCR)) return BadRequest("Unique claim reference (UCR) must be provided");

            var claim = await _claimService.GetClaimByUCR(UCR);

            if (claim == null) return NotFound($"Could not find claim with unique claim reference: {UCR}");

            return Ok(claim);
        }
    }
}
