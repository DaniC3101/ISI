using BLL;
using BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilizadorController : ControllerBase
    {
        private readonly IUtilizadorBLL _bll;

        public UtilizadorController(IUtilizadorBLL bll)
        {
            _bll = bll;
        }

        [HttpPost("register")]
        [Authorize(Roles = "owner,user")]
        public async Task<IActionResult> Insert()
        {
            var subClaim = User.FindFirst("sub")?.Value;

            if (string.IsNullOrEmpty(subClaim))
                return BadRequest("User ID claim not found.");

            await _bll.InserteUserAsync(subClaim);

            return Ok();
        }
    }
}