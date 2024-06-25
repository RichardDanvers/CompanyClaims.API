using CompanyClaims.Models;
using CompanyClaims.Service.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CompanyClaims.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string companyName)
        {
            if (string.IsNullOrWhiteSpace(companyName)) return BadRequest("Company name must be provided");

            var company = await _companyService.GetCompanyByName(companyName);

            if (company == null) return NotFound($"Could not find company with name: {companyName}");

            return Ok(company);
        }
    }
}
