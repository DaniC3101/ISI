using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilizadorController : ControllerBase
    {
        // GET: api/<TestController>
        [HttpPost("insert")]
        [Authorize(Roles = "owner,user")]
        public IActionResult Insert()
        {
            var subClaim = User.FindFirst("sub")?.Value;
           

            return Ok(new
            {
                UserId = subClaim
            });

        }
    }
}
