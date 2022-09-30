using Microsoft.AspNetCore.Mvc;

namespace ProductsManager.Controllers
{
    [Route("")]
    [ApiController]
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return Ok("ok)");
        }
    }
}
