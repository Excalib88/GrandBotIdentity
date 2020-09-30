using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcAuthGuide.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : Controller
    {
        [HttpGet("admin")]
        [Authorize(Roles = RoleNames.Administrator)]
        public IActionResult Get()
        {
            return Ok("Страница администратора");
        }
        
        [HttpGet("moderator")]
        [Authorize(Roles = RoleNames.Moderator)]
        public IActionResult GetModerator()
        {
            return Ok("Страница модератора");
        }
    }
}