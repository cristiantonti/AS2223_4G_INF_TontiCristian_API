using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_TontiCristian_API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
