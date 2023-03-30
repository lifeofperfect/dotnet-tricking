using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
            
        }

        [HttpGet] 
        public string Index()
        {
            return "Hello world";
        }
    }
}
