using ECommerce_YT.Data;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_YT.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;

        public ActorController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            var actors = _context.Actors.ToList();
            return View(actors);
        }
    }
}
