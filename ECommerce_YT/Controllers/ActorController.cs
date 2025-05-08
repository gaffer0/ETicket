using ECommerce_YT.Data.Services;
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
    }
}
