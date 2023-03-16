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
        public JsonResult GetMath(int number)
        {
            string ris;
            if (number % 2 == 0)
            {
                ris = "pari"; 
            }
            else
            {
                ris = "dispari";
            }
            return Json(new { output = number, ris, status = "OK" });
        }
        [HttpGet("GetFattoriale")]
        public int CalcoloFattoriale(int number)
        {
            int ris = 1;
            for (int i = 2; i <= number; i++)
            {
                ris *= i;
            }
            return ris;
    }
}
