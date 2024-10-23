using Microsoft.AspNetCore.Mvc;

namespace Orthodox.Api.Controllers
{
    public class PensamientoDiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
