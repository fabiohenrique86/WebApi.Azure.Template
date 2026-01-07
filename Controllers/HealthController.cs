using Microsoft.AspNetCore.Mvc;

namespace WebApi.Azure.Template.Controllers
{
    public class HealthController : Controller
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
