using Microsoft.AspNetCore.Mvc;

namespace ECommerce_YT.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
