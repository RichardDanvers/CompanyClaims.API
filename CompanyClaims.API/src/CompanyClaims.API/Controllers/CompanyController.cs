using CompanyClaims.Models;
using CompanyClaims.Service.Interfaces;
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
            try
            {
                var company = await _companyService.GetCompanyByName(companyName);
                return Ok(company);
            }
            catch (NullReferenceException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
