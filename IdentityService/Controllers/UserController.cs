using Mchyll.IdentityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Mchyll.IdentityService.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok(new Permission("Hei").ToString());
        }
    }
}
