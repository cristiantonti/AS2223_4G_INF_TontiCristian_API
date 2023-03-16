using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_TontiCristian_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("GetMath")]
        public IActionResult Index()
        {
            return View();
        }
        public string CheckEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Il numero è pari";
            }
            else
            {
                return "Il numero è dispari";
            }
        }
    }
}
