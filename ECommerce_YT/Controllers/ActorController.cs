using ECommerce_YT.Data.Services;
using ECommerce_YT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_YT.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _service;

        public ActorController(IActorService service)
        {
            _service = service;
        }



        public IActionResult Index()
        {
            var actors = _service.GetAll();
            return View(actors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Actor actor) // Remove async
        {
            if (!ModelState.IsValid) return View(actor);

            _service.Add(actor); // Now matches sync method
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var actor = _service.GetById(id);
            if (actor == null) return NotFound();
            return View(actor);
        }
    }
}
