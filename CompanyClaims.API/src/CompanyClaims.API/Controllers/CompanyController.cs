using CompanyClaims.Models;
using Microsoft.AspNetCore.Mvc;

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
