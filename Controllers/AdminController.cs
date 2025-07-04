using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")] // 🔐 Protects all endpoints in this controller for Admins only
    public class AdminController : ControllerBase
    {
        // GET: api/Admin/secret
        [HttpGet("secret")]
        public IActionResult GetSecretForAdminsOnly()
        {
            return Ok("🔐 This message is only visible to Admins 👑");
        }

        // You can add more admin-only endpoints here later
    }
}
