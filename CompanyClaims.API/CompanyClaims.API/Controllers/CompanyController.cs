using Microsoft.AspNetCore.Mvc;
using CompanyClaims.Models;

namespace CompanyClaims.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(string companyName)
        {
            return Ok(new Company());
        }
    }
}
