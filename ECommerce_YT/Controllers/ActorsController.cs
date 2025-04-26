using ECommerce_YT.Data;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_YT.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
