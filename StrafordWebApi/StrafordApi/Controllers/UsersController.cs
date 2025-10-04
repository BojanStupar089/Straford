using Microsoft.AspNetCore.Mvc;

namespace StrafordApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Zvezdaleeeee");
        }
    }
}
