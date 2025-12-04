using BLL.Interfaces;
using Microsoft.AspNetCore.Authentication;
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
        public async Task<IActionResult> RegisterUser()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var userId = await _bll.RegisterUserAsync(accessToken);
            return Ok(new { Id = userId });
        }
    }
}
