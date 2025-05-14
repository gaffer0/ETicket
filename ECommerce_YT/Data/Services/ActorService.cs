using ECommerce_YT.Models;

namespace ECommerce_YT.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        void IActorService.Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        void IActorService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Actor> IActorService.GetAll()
        {
            var result = _context.Actors.ToList();
            return result;
        }

        Actor IActorService.GetById(int id)
        {
            var result = _context.Actors.FirstOrDefault(a => a.Id == id);
            return result;
        }

        Actor IActorService.Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
