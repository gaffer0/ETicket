using ECommerce_YT.Data;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_YT.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
