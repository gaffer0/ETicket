using ECommerce_YT.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_YT.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allmovies = _context.Movies.Include(m => m.Cinema)
                .ToList();

            return View(allmovies);
        }
    }
}
