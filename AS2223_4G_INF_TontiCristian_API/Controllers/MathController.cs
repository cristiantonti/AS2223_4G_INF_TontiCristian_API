using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_TontiCristian_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("GetMath")]
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
        [HttpGet("Delta")]
        public IActionResult Delta(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return BadRequest(new { message = "L'equazione non ha soluzioni reali" });
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return Ok(new { a, b, c, x1 = x, x2 = x, delta, type = "due radici coincidenti" });
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                if (a > 0)
                {
                    return Ok(new { a, b, c, x1, x2, delta, type = "parabola convessa" });
                }
                else
                {
                    return Ok(new { a, b, c, x1, x2, delta, type = "parabola concava" });
                }
            }
        }
    }
}
