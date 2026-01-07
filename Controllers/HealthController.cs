using Microsoft.AspNetCore.Mvc;

namespace WebApi.Azure.Template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                status = "healthy",
                version = "1.0"
            });
        }
    }
}
